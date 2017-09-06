using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ShelfReading
{
    public class Reading
    {
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\Library Programs\ShelfReading\ShelfReading\bin\Debug\ShelfReading.accdb";
        protected OleDbConnection connect;
        protected OleDbCommand com;
        protected string command;
        protected const string SPACER = " ";
        public static string temp;
        public void setTemp(string input)
        {
            temp = input;
        }
        public string getTemp()
        {
            string output = temp;
            return output;
        }
        List<string> list = new List<string>();
        public bool Entry(string Student, string Bookcase, string Shelf, int CaseNum)
        {
            DateTime Day = DateTime.Now;
            string d = Day.ToShortDateString();
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "DELETE * FROM Reads  WHERE Section = ?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@Section", Bookcase + SPACER + Shelf);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                return false;
            } 
            connect.Close();   
            try
            {
                bool updated = false;
                command = "UPDATE Cases SET NeedRead=? WHERE CaseName=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@NeedRead", updated);
                com.Parameters.AddWithValue("@CaseName", Bookcase);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update tables, please contact admin." + ex);
            }
            connect.Close();
            try
            {
                command = "INSERT INTO Reads (StudentID, [Section], [Day], CaseName)" + "Values(?,?,?,?)";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@StudentID", Student);
                com.Parameters.AddWithValue("@Section", Bookcase + SPACER + Shelf);
                com.Parameters.AddWithValue("@Day", d);
                com.Parameters.AddWithValue("@CaseName", CaseNum);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully add record to database\r\n" + ex);
                connect.Close();
                return false;
            }
            
        }
        public List<string> SetStudents(string employment)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT Student FROM Students WHERE EmploymentStatus=? ORDER BY Student ASC";
                list = new List<string>();
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                com.Parameters.AddWithValue("@EmploymentStatus", employment);
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        string name = read[0].ToString();
                        list.Add(name);
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
                connect.Close();
                return null;
            }
        }
        public void addStudent(string student, string status, string email)
        {
            if (email == null)
            {
                email = "NO EMAIL PROVIDED OR REQUIRED";
            }
            int i = student.IndexOf(" ");
            int j = 1;
            string first = student.Substring(0,1);
            i++;
            string last = student.Substring(i, 1);
            string studentID = first + last + "0" + j.ToString();
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT [ID] FROM Students";
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        string input = read[0].ToString();
                        if (input == studentID)
                        {                          
                            j++;
                            studentID = first + last + "0" + j.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully update studentID" + ex);
                return;
            }
            connect.Close();
            try
            {
                command = "INSERT INTO Students (Student, EmploymentStatus, ID, Email)" + "Values(?,?,?,?)";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@Student", student);
                com.Parameters.AddWithValue("@EmploymentStatus", status);
                com.Parameters.AddWithValue("@ID", studentID);
                com.Parameters.AddWithValue("@Email", email);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show(student + " has been added to the list.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully add student to students list.\r\n" + ex);
                return;
            }
        }
        public void removeStudent(string student)
        {
            string removed = "(Former Student)";
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "UPDATE Students Set EmploymentStatus =? WHERE Student =?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@StudentID", removed);
                com.Parameters.AddWithValue("@Student", student);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show(student + " has been removed from the list.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully remove student from students list.\r\n" + ex);
                return;
            }
            connect.Close();
        }
        public string shelves(int bookcase, string shelf)
        {
            int divide = shelf.IndexOf('f');
            string sub = shelf.Substring(divide + 1, shelf.Length-divide-1);
            int s = int.Parse(sub);
            string section = "";
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT ShelfStart, ShelfEnd from Shelves WHERE CaseNumber=? AND Shelf=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@CaseNumber", bookcase);
                com.Parameters.AddWithValue("@Shelf", s);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string start = read[0].ToString();
                    string end = read[1].ToString();
                    section = start + " - " + end;
                }                  
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Could not successfully load section." + ex);
            }
            connect.Close();
            return section;
        }
        public int setStatus(string bookcase, string shelf)
        {
            int age = 0;
            string section = bookcase + SPACER + shelf;
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT [Day] FROM Reads WHERE [Section]=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@Section", section);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string day = read[0].ToString();
                    DateTime d = Convert.ToDateTime(day);
                    age = DateTime.Now.DayOfYear - d.DayOfYear;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\r\n");
                connect.Close();
            }
            connect.Close();
            return age;
        }
        public int convertCase(string input)
        {
            int i = input.IndexOf("e");
            i = i + 1;
            string output = input.Substring(i, input.Length - i);
            return int.Parse(output);
        }
        public List<string> Bookcase(string bcase)
        {
            string begin = "";
            string end = "";
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT CaseStart, CaseEnd from Cases WHERE CaseName =?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@CaseName", bcase);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    begin = read[0].ToString();
                    end = read[1].ToString();
                }              
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Could not successfully load section." + ex);
            }
            list = new List<string>();
            list.Add(begin);
            list.Add(end);
            connect.Close();
            return list;
        }
        public List<string> bookcases()
        {
            string to = " TO ";
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT CaseName, CaseStart, CaseEnd FROM Cases";
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    editOutput(read[0].ToString(), read[1].ToString(), read[2].ToString());
                } 
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Could not successfully load section." + ex);
            }
            connect.Close();
            return list;
        }
        public int convertShelf(string input)
        {
            int i = input.IndexOf(" ");
            i = i + 1;
            string output = input.Substring(i, input.Length - i);
            return int.Parse(output);
        }
        public void setCase()
        {
            list = new List<string>();
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT [Day], CaseName FROM Reads";
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    DateTime date = Convert.ToDateTime(read[0]);
                    if (DateTime.Now.AddDays(-14) > date)
                    {
                        list.Add(read[1].ToString());
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\r\n");
                connect.Close();
            }
            foreach (string Cases in list)
            {
                try
                {
                    int caseNum = int.Parse(Cases);
                    connect = new OleDbConnection(connectionString);
                    command = "UPDATE Cases SET NeedRead = ? WHERE [ID]= ?";
                    com = new OleDbCommand(command, connect);
                    com.Parameters.AddWithValue("@NeedRead", 1);
                    com.Parameters.AddWithValue("@ID", caseNum);
                    com.Connection = connect;
                    connect.Open();
                    com.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not update table." + ex);
                    connect.Close();
                }
            }
        }
        public bool getCase(string ID)
        {
            int caseID = convertCase(ID);
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT NeedRead FROM Cases WHERE [ID]=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@ID", caseID);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string input = read[0].ToString();
                    if (input == "True")
                    {
                        connect.Close();
                        return true;
                    }
                    else
                    {
                        connect.Close();
                        return false;
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load values. " + ex);
                connect.Close();
                return false;
            }
            return false;
        }
        public void restart(Form form)
        {
            form.Dispose();
            User form2 = new User(false);
            form2.ShowDialog();
        }
        public void loadFloor(Form form, Form form2)
        {
            form.Dispose();
            form2.ShowDialog();
        }
        public List<string> loadShelves(string caseName)
        {
            string section = "";
            int sect = 0;
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT [ID] FROM Cases WHERE CaseName=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@CaseName", caseName);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    section = read[0].ToString();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update tables, please contact admin." + ex);
                return null;
            }
            connect.Close();
            int.TryParse(section, out sect);
            try
            {
                List<string> output = new List<string>();
                list = new List<string>();
                connect = new OleDbConnection(connectionString);
                command = "SELECT CompositeKey, ShelfStart, ShelfEnd FROM Shelves WHERE CaseNumber=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@CaseNumber", sect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();     
                string spacer = " ";
                while (read.Read())
                {
                    editOutput(read[0].ToString(), read[1].ToString(), read[2].ToString());            
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;
            }
            return list;
        }
        private void editOutput(string section, string starting, string ending)
        {
            const string TO = "  TO  ";
            int count = 65;
            string input = section + starting + TO + ending;
            int i = input.Length;
            const string BREAKER = "_";
            string spacing = "";
            int j = count - i;
            if (input == "")
                return;
            for (int k = 0; k < j; k++)
                section += SPACER;
            input = section + starting + TO + ending;
            int f = input.Length;
            for (int z = 0; z < f; z++)
                spacing += BREAKER;          
            list.Add(input);
            list.Add(spacing);
        }
        public void alterCase(string bcase, string starting, string ending)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "UPDATE Cases SET CaseStart=?, CaseEnd=? WHERE CaseName=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@CaseStart", starting);
                com.Parameters.AddWithValue("@CaseEnd", ending);
                com.Parameters.AddWithValue("@CaseName", bcase);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully changed record.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully alter the range of the bookcase.  " + ex);
            }
            connect.Close();
        }
        public void alterShelf(string compKey, string starting, string ending)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "UPDATE Shelves SET ShelfStart=?, ShelfEnd=? WHERE CompositeKey=?";
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@ShelfStart", starting);
                com.Parameters.AddWithValue("@ShelfEnd", ending);
                com.Parameters.AddWithValue("@CompositeKey", compKey);
                com.Connection = connect;
                connect.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully changed record.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully alter the range of the bookcase.  " + ex);
            }
            connect.Close();
        }
    }
}
