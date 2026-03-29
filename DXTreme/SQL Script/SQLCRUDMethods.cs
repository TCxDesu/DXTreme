using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.CodeDom;
using DXTreme.Popup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Security.AccessControl;
using System.Diagnostics;

namespace DXTreme.SQL_Script
{
    internal class SQLCRUDMethods
    {
        string sql = "Data Source = ARREN\\SQLEXPRESS;Initial Catalog=DXTreme;" +
                "Integrated Security=True";

        //String sql = "Data Source = DESKTOP-F21ED7R\\SQLSERVER;Initial Catalog=DXTreme;" +
        //        "Integrated Security=True";
        SqlConnection con;

        public void connectSQL()
        {
            con = new SqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                failed f = new failed("Connection Issues", "An error occured.");
            }
        }

        public void addMember(string name, string memType, string memOption, string branch, double amount, string adminName)
        {
            try
            {
                connectSQL();
                string memberQuery = $@"INSERT INTO Members VALUES ('{name}','{memType}','{memOption}', CONVERT(date, GETDATE()), DATEADD(MONTH, 1, CONVERT(date, GETDATE())), 0)";
                SqlCommand memberCom = new SqlCommand(memberQuery, con);
                string transactionQuery = $@"INSERT INTO Transaction_History VALUES ('{adminName}', '{name}', GETDATE(), 'Applied For {memOption}', '{branch}', {amount}, 0)";
                SqlCommand transactionCom = new SqlCommand(transactionQuery, con);
                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{adminName}', 'Applied {name} For {memOption}', GETDATE(),' {branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);

                memberCom.ExecuteNonQuery();
                transactionCom.ExecuteNonQuery();
                auditCom.ExecuteNonQuery();

                memberCom.Dispose();
                transactionCom.Dispose();
                auditCom.Dispose();

                con.Close();

            }
            catch (Exception)
            {
                failed f = new failed("Member Registration", "The person you are trying to add is already a member.");
                f.Show();
            }
        }

        public void addAccount(string username, string password, string branch, string staffName, int accType)
        {
            try
            {
                connectSQL();
                //username, password, branch, account type, status, archived
                //0 = staff, 1 = manager, 2 = super admin (if needed)

                string addminQuery = $@"INSERT INTO Accounts VALUES ('{username}','{password}', '{branch}', {accType}, 0, 0)";
                SqlCommand addminCom = new SqlCommand(addminQuery, con);
                addminCom.ExecuteNonQuery();

                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Created an Admin Account ({username})', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);
                auditCom.ExecuteNonQuery();

                string auditQuery2 = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Assigned ({username}) to {branch} Branch', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom2 = new SqlCommand(auditQuery2, con);
                auditCom2.ExecuteNonQuery();

                addminCom.Dispose();
                auditCom.Dispose();
                auditCom2.Dispose();

                con.Close();

                succes s = new succes("Account Creation", "Account successfully created.");
            }
            catch (Exception ex)
            {
                failed f = new failed("Account Creation", "Account username already exists.");
                f.Show();
            }
        }

        public bool addEquipmentToList(string equipName, string branch, string staffName)
        {
            try
            {
                connectSQL();

                string addminQuery = $@"INSERT INTO EquipmentList VALUES ('{equipName}', '{branch}')";
                SqlCommand addminCom = new SqlCommand(addminQuery, con);
                addminCom.ExecuteNonQuery();

                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Added {equipName} on the list of equipments.', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);
                auditCom.ExecuteNonQuery();

                string auditQuery2 = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Listed {equipName} to {branch}.', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom2 = new SqlCommand(auditQuery2, con);
                auditCom2.ExecuteNonQuery();

                addminCom.Dispose();
                auditCom.Dispose();
                auditCom2.Dispose();

                succes s = new succes("Equipment Listing", "Equipment has been added.");
                s.ShowDialog();

                con.Close();



                return true;
            }
            catch (Exception ex)
            {
                failed f = new failed("Equipment Listing", "Equipment already exist on the selected branch.");
                f.ShowDialog();
                return false;
            }
        }

        public void addEquipmentToMaintenance(string equipName, string condition, string datetime, string branch, string staffName)
        {
            try
            {
                connectSQL();

                string addminQuery = $@"INSERT INTO EquipmentMaintenance VALUES ('{equipName}', '{condition}', '{datetime}', '{branch}', 0)";
                SqlCommand addminCom = new SqlCommand(addminQuery, con);
                addminCom.ExecuteNonQuery();

                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Added {equipName} on the list of maintenance.', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);
                auditCom.ExecuteNonQuery();

                string auditQuery2 = $@"INSERT INTO Data_Log VALUES ('{staffName}', 'Listed {equipName} to {branch}.', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom2 = new SqlCommand(auditQuery2, con);
                auditCom2.ExecuteNonQuery();

                addminCom.Dispose();
                auditCom.Dispose();
                auditCom2.Dispose();

                con.Close();

                succes s = new succes("Equipment Maintenance", "Equipment has been listed.");
            }
            catch (Exception ex)
            {
                failed f = new failed("Equipment Maintenance", "An error occured.");
                f.Show();
            }
        }

        public ArrayList retrieveTableRows(string tableName)
        {
            connectSQL();
            ArrayList rows = new ArrayList();

            string tableRow = $@"SELECT * FROM {tableName}";
            SqlCommand tableCom = new SqlCommand(tableRow, con);
            SqlDataReader reader = tableCom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rows.Add(reader[i].ToString());
                }
            }

            con.Close();
            tableCom.Dispose();
            reader.Close();

            return rows;
        }

        public ArrayList retrieveTableRows(string columns, string tableName)
        {
            connectSQL();
            ArrayList rows = new ArrayList();

            string tableRow = $@"SELECT {columns} FROM {tableName}";
            SqlCommand tableCom = new SqlCommand(tableRow, con);
            SqlDataReader reader = tableCom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rows.Add(reader[i].ToString());
                }
            }

            con.Close();
            tableCom.Dispose();
            reader.Close();

            return rows;
        }

        public ArrayList retrieveTableRows(string columns, string tableName, string condition)
        {
            ArrayList rows = new ArrayList();
            try
            {
                connectSQL();


            string tableRow = $@"SELECT {columns} FROM {tableName} WHERE {condition}";
            SqlCommand tableCom = new SqlCommand(tableRow, con);
            SqlDataReader reader = tableCom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rows.Add(reader[i].ToString());
                }
            }

            con.Close();
            tableCom.Dispose();
            reader.Close();
            }
            catch (Exception)
            {
            }

            return rows;
        }

        public ArrayList retrieveTableRows(string columns, string tableName, string join, string toJoin, string condition)
        {
            connectSQL();
            ArrayList rows = new ArrayList();

            string tableRow = $@"SELECT {columns} FROM {tableName} {join} {toJoin} WHERE {condition}";
            SqlCommand tableCom = new SqlCommand(tableRow, con);
            SqlDataReader reader = tableCom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rows.Add(reader[i].ToString());
                }
            }

            con.Close();
            tableCom.Dispose();
            reader.Close();

            return rows;
        }

        public void archiveData(string tableName, string toCheck, string adminName, string username, string branch)
        {
            try
            {
                updateSelection(tableName, "isArchived = 1", toCheck, adminName, "Archived " + username + " from " + tableName, branch);

                connectSQL();
                string archiveQuery = $@"INSERT INTO ArchivedData VALUES ('{username}', '{tableName}', GETDATE())";
                SqlCommand archiveCom = new SqlCommand(archiveQuery, con);
                archiveCom.ExecuteNonQuery();

                con.Close();

                succes s = new succes("Archiving of Data", "Successfully archived.");
                s.ShowDialog();

                archiveCom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                failed f = new failed("Archiving of Data", "An error occurred.");
                f.ShowDialog();
            }
        }
        public void deleteSelection(string tableName, string toCheck, string adminName, string username, string branch)
        {
            try
            {
                connectSQL();

                string tableRow = $@"DELETE FROM {tableName} WHERE {toCheck}";
                SqlCommand tableCom = new SqlCommand(tableRow, con);
                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{adminName}', 'Deleted an Account ({username})', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);



                tableCom.ExecuteNonQuery();
                auditCom.ExecuteNonQuery();

                con.Close();

                succes s = new succes("Deletion of Data", "Successfully deleted.");
                s.ShowDialog();

                auditCom.Dispose();
                tableCom.Dispose();
            }
            catch (Exception)
            {
                failed f = new failed("Deletion of Data", "An error occurred.");
                f.ShowDialog();
            }
        }

        public void updateSelection(string tableName, string changes, string condition, string username, string activity, string branch)
        {
            try
            {
                connectSQL();


                string tableRow = $@"UPDATE {tableName} SET {changes} WHERE {condition}";
                SqlCommand tableCom = new SqlCommand(tableRow, con);
                string auditQuery = $@"INSERT INTO Data_Log VALUES ('{username}', '{activity}', GETDATE(), '{branch}', 0)";
                SqlCommand auditCom = new SqlCommand(auditQuery, con);


                tableCom.ExecuteNonQuery();
                auditCom.ExecuteNonQuery();

                con.Close();

                auditCom.Dispose();
                tableCom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                failed f = new failed("Update of Data", "An error occurred.");
                f.ShowDialog();
            }
        }
    }
}
