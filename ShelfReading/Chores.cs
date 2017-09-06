using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ShelfReading
{
    class Chores
    {
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Library Programs\ShelfReading\ShelfReading\bin\Debug\ShelfReading.accdb";
        protected OleDbConnection connect;
        protected OleDbConnection connect2;
        protected OleDbCommand com;
        private const string PRIORITY = "*PRIORITY*";
        protected string command;
        protected const string SPACER = "               *";
        List<string> list;
        private string task;
        public bool addChores(int priority, string task, string comments, string due)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "INSERT INTO Tasks (Priority, Task, Comments, Materials)" + "Values(?, ?, ?, ?)";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@Priority", priority);
                com.Parameters.AddWithValue("@Task", task);
                com.Parameters.AddWithValue("@Comments", comments);
                com.Parameters.AddWithValue("Materials", due);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch (Exception ex)
            {
                connect.Close();
                return false;
            }
        }
        public List<string> getChores()
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT Priority, Task FROM Tasks ORDER BY Priority ASC";
                list = new List<string>();
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        string priority = read[0].ToString();
                        task = read[1].ToString();
                        list.Add(priority + SPACER + task);
                    }
                }
                else
                    MessageBox.Show("No records found.  Please contact admin.");
                connect.Close();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not succesfully load students from list.\r\n" + ex);
                return null;
            }
        }
        public string getDirections(string selection)
        {
            connect = new OleDbConnection(connectionString);
            command = "SELECT Comments FROM Tasks WHERE Task =?";
            string output = "-";
            com = new OleDbCommand(command, connect);
            com.Parameters.AddWithValue("@Task", selection);
            com.Connection = connect;
            connect.Open();
            OleDbDataReader read = com.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    output += read[0].ToString();
                    for (int i = 0; i < output.Length; i++)
                    {
                        if (output[i] == '.')
                        {
                            output = output.Replace(".", "\r\n");
                        }
                        else
                            continue;
                    }                   
                }
            }
            else
            {
                connect.Close();
                return null;
            }
            return output;
        }
        public string getMaterials(string selection)
        {
            connect = new OleDbConnection(connectionString);
            command = "SELECT Materials FROM Tasks WHERE Task =?";
            string output = "-";
            com = new OleDbCommand(command, connect);
            com.Parameters.AddWithValue("@Task", selection);
            com.Connection = connect;
            connect.Open();
            OleDbDataReader read = com.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    output += read[0].ToString();
                    for (int i = 0; i < output.Length; i++)
                    {
                        if (output[i] == '.')
                        {
                            output = output.Replace(".", "\r\n");
                        }
                        else
                            continue;
                    }
                }
            }
            else
            {
                connect.Close();
                return null;
            }
            connect.Close();
            return output;
        }
        public void updatePriority(DateTime work, int prior, string task)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "UPDATE Tasks SET Priority =?, [Date]=? WHERE Task=?";
                int i = task.IndexOf("*");
                i++;
                task = task.Substring(i, task.Length - i);
                var d = work.Date;
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@Priority", prior);
                com.Parameters.AddWithValue("@Date", d);
                com.Parameters.AddWithValue("@Task", task);
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record has been updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record was not updated " + ex);
                connect.Close();
            }
        }
        public void changePriority()
        {
            DateTime n = DateTime.Now;
            int day = n.DayOfYear;
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT Task, [Day] FROM Tasks";
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.HasRows)
                {
                    string task = read[0].ToString();
                    string input = read[1].ToString();
                    int i = task.IndexOf("*");
                    i++;
                    task = task.Substring(i, task.Length - i);
                    DateTime d = Convert.ToDateTime(input);
                    int num = d.DayOfYear;
                    int output = day - num;
                    if (output > 5)
                        output = 1;
                    else
                    {
                        output = 5 - output;
                    }
                    connect2 = new OleDbConnection(connectionString);
                    command = "Update Tasks SET Priority=? WHERE Task=?";
                    com = new OleDbCommand(command, connect2);
                    com.Connection = connect2;
                    com.Parameters.AddWithValue("@Priority", output);
                    com.Parameters.AddWithValue("@Task", task);
                    connect2.Open();
                    com.ExecuteNonQuery();
                    connect2.Close();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                connect.Close();
            }
        }
    }
}
