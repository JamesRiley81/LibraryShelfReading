using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShelfReading
{
    public partial class addChores : Form
    {
        public addChores()
        {
            InitializeComponent();
        }
        private Reading read = new Reading();
        private Chores chores = new Chores();
        private List<string> list = new List<string>();
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\Library Programs\ShelfReading\ShelfReading\bin\Debug\ShelfReading.accdb";
        protected OleDbConnection connect;
        protected string command;
        protected OleDbCommand com;
        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addChores_Load(object sender, EventArgs e)
        {
            try
            {
                connect = new OleDbConnection(connectionString);
                command = "SELECT Description FROM Materials";
                com = new OleDbCommand(command, connect);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string output = read[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            } 
        }
    }
}
