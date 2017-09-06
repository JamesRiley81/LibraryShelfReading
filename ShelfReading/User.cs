using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ShelfReading
{
    public partial class User : Form
    {
        private bool cleaning = false;
        public User(bool misc)
        {
            InitializeComponent();
            cleaning = misc;
        }
        private Reading read = new Reading();
        private List<string> students;
        private string student = "";
        private const string WORKSTUDY = "Workstudy";
        private void User_Load(object sender, EventArgs e)
        {
            students = read.SetStudents(WORKSTUDY);
            foreach (string student in students)
            {
                studentListBox.Items.Add(student);
            }
        }
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Please confirm your name\r\n" + studentListBox.SelectedItem.ToString(), "Confirmation", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    student = studentListBox.SelectedItem.ToString();
                    if (cleaning == false)
                    {
                        DialogResult result = new DialogResult();
                        result = MessageBox.Show("Was your reading on the second floor?", "Select Floor", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Floor2 form = new Floor2(student);
                            read.loadFloor(this, form);                        
                            this.Close();
                        }
                        else
                        {
                            ThirdFloor form = new ThirdFloor(student);
                            read.loadFloor(this, form);
                            this.Close();
                        }
                    }
                    else
                    {
                        ChoresForm form = new ChoresForm(student);
                        form.ShowDialog();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select your name.");
                    return;
                }
            }            
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
