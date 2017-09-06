using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelfReading
{
    public partial class TaskForm : Form
    {
        private bool misc = false;
        private string password = "Jamesiscool";
        private Reading read = new Reading();
        public TaskForm()
        {
            InitializeComponent();
        }

        private void readingButton_Click(object sender, EventArgs e)
        {
            User form = new User(misc);
            form.ShowDialog();
            this.Close();
        }

        private void miscButton_Click(object sender, EventArgs e)
        {
            misc = true;         
            User form = new User(misc);
            form.ShowDialog();
            this.Close();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            read.setCase();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            string x = Microsoft.VisualBasic.Interaction.InputBox("Please input admin password", "Credentials", "");
            if (x == "")
            {
                return;
            }
            if (x != password)
            {
                DialogResult r = MessageBox.Show("Incorrect password, please try again.", "Confirmation", MessageBoxButtons.OKCancel);
                if (r == DialogResult.Cancel)
                {
                    Form form = this.FindForm();
                    read.restart(form);
                }
                else
                    x = Microsoft.VisualBasic.Interaction.InputBox("Please input admin password", "Credentials", "");
            }
            else
            {
                admin Admin = new admin();
                Admin.ShowDialog();
                this.Close();
            }
        }
    }
}
