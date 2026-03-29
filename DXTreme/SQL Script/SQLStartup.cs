using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom;

namespace DXTreme.SQL_Script
{
    internal class SQLStartup
    {

        String sql = "Data Source = ARREN\\SQLEXPRESS;Initial Catalog=DXTreme;" +
                "Integrated Security=True";
        //String sql = "Data Source = DESKTOP-F21ED7R\\SQLSERVER;Initial Catalog=DXTreme;" +
        //        "Integrated Security=True";
        SqlConnection con;

        public SQLStartup()
        {
            connectSQL();
            createAccountsTable();
            createMembersTable();
            createMembersAttendance();
            createListOfEquipments();
            createEquipmentMaintenance();
            createTransactionTable();
            createDataLog();
            createArchive();
            createProcedure();
            closeSQL();
        }

        public void connectSQL()
        {
            con = new SqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
            }
        }

        public void createAccountsTable()
        {
            try
            {
                string query = @"CREATE TABLE Accounts (" +
               "Usernames VARCHAR(20) NOT NULL," +
               "Passwords VARCHAR(20) NOT NULL," +
               "Branch VARCHAR(255) NOT NULL," +
               "Account_Type int NOT NULL," +
               "Status INT NOT NULL," +
               "isArchived INT NOT NULL," +
               "PRIMARY KEY(Usernames)" +
               ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                string query2 = @$"INSERT INTO Accounts VALUES (" +
                    "'SuperAdmin', 'SamplePassword', 'DXtreme Fitness Gym - Mabolo Branch', 2, 0, 0" +
                    ")";
                SqlCommand com2 = new SqlCommand(query2, con);
                com2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createListOfEquipments()
        {
            try
            {
                string query = @"CREATE TABLE EquipmentList (" +
               "EquipmentName VARCHAR(35) NOT NULL," +
               "Branch VARCHAR(50)" +
               ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
            }
            addUniqueEquipment();
        }
        public void addUniqueEquipment()
        {

            try
            {
                string query = @"CREATE UNIQUE INDEX unique_equipment " +
                    "ON EquipmentList (EquipmentName, Branch)";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createEquipmentMaintenance()
        {
            try
            {
                string query = @"CREATE TABLE EquipmentMaintenance (" +
               "EquipmentName VARCHAR(35)," +
               "Condition VARCHAR(45) NOT NULL," +
               "Date_and_Time DATETIME NOT NULL," +
               "Branch VARCHAR(50)," +
               "isArchived INT," +
               "FOREIGN KEY (EquipmentName, Branch)" +
               "REFERENCES EquipmentList (EquipmentName, Branch) ON UPDATE CASCADE" +
               ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createTransactionTable()
        {
            try
            {
                string query = "CREATE TABLE Transaction_History (" +
                    "Transaction_ID int IDENTITY(1,1)," +
                    "Staff_in_Charge VARCHAR(20) FOREIGN KEY REFERENCES Accounts(Usernames) ON UPDATE CASCADE," +
                    "Client VARCHAR(30) FOREIGN KEY REFERENCES Members(Member_Name) ON UPDATE CASCADE," +
                    "Date_and_Time DATETIME," +
                    "Activity VARCHAR(255)," +
                    "Branch VARCHAR(50)," +
                    "Amount MONEY," +
                    "isArchived INT NOT NULL," +
                    "PRIMARY KEY(Transaction_ID)" +
                    ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createDataLog()
        {
            try
            {
                string query = "CREATE TABLE Data_Log (" +
                    "Data_Log_ID int IDENTITY(1,1)," +
                    "Staff_in_Charge VARCHAR(20) FOREIGN KEY REFERENCES Accounts(Usernames) ON UPDATE CASCADE," +
                    "Activity VARCHAR(255)," +
                    "Date_and_Time DATETIME," +
                    "Branch VARCHAR(50),"+ 
                    "isArchived INT NOT NULL," +
                    "PRIMARY KEY(Data_Log_ID)" +
                    ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createMembersTable()
        {
            try
            {
                string query = @"CREATE TABLE Members (" +
               "Member_Name VARCHAR(30)," +
               "Membership_Type VARCHAR(20)," +
               "Membership_Option VARCHAR(25)," +
               "Date_of_Membership DATE," +
               "Date_of_Expiration DATE," +
               "isArchived INT NOT NULL," +
               "PRIMARY KEY(Member_Name)" +
               ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createMembersAttendance()
        {
            try
            {
                string query = @"CREATE TABLE MembersAttendance (" +
               "Member_Name VARCHAR(30) FOREIGN KEY REFERENCES Members(Member_Name) ON UPDATE CASCADE," +
               "Attendance_Type VARCHAR(20) NOT NULL," +
               "Date_of_Attendance DATE NOT NULL," +
               "Attendance INT NOT NULL, " +
               "isArchived INT NOT NULL" +
               ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createArchive()
        {
            try
            {
                string query = "CREATE TABLE ArchivedData (" +
                    "RefName VARCHAR(30)," +
                    "RefTable VARCHAR(30)," +
                    "DateAndTime DATETIME," +
                    ")";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void createProcedure()
        {
            try
            {
                string query =
                "CREATE PROCEDURE AddAttendance @MemberName varchar(30), @AttendanceType varchar(20)" +
                "\r\nAS" +
                "\r\nBEGIN" +
                "\r\n\tDECLARE @BaseDate DATE" +
                "\r\n\t SET @BaseDate = (SELECT TOP 1 Date_Of_Attendance FROM MembersAttendance WHERE MemberName = @MemberName ORDER BY Date_Of_Attendance DESC)" +
                "\r\n\tIF @BaseDate IS NULL" +
                    "\r\n\tBEGIN" +
                        "\r\n\tSET @BaseDate = Convert(date, getdate())" +
                    "\r\n\tEND" +
                "\r\n    DECLARE @Days int" +
                "\r\n\tDECLARE @EndDate date" +
                "\r\n\r\n\t" +
                "IF (@AttendanceType LIKE '%Monthly%')" +
                "\r\n\t" +
                "BEGIN\r\n\t" +
                "    SET @EndDate = DATEADD(MONTH, 1, @BaseDate)" +
                "\r\n    END" +
                "\r\n\tELSE IF (@AttendanceType LIKE '%Yearly%')" +
                "\r\n\tBEGIN" +
                "\r\n\t    SET @EndDate = DATEADD(YEAR, 1, @BaseDate)" +
                "\r\n\tEND" +
                "\r\n\tELSE" +
                "\r\n\tBEGIN" +
                "\r\n\t    SET @EndDate = DATEADD(DAY, 0, @BaseDate)" +
                "\r\n\t" +
                "END" +
                "\r\n\r\n\tSET @Days = DATEDIFF(DAY, @BaseDate, @EndDate)" +
                "\r\n\tDECLARE @i AS int = 0" +
                "\r\n\r\n\tWHILE (@i <= @Days)" +
                "\r\n\tBEGIN" +
                "\r\n\t        INSERT INTO MembersAttendance VALUES " +
                "\r\n\t\t    (@MemberName, @AttendanceType, DATEADD(day, @i, @BaseDate), 0)" +
                "\r\n\t\t\tSET @i = @i + 1" +
                "\r\n\tEND" +
                "\r\nEND";

                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void closeSQL()
        {
            con.Close();
        }
    }
}
