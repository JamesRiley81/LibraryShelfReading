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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        List<string> list;
        Reading read = new Reading();
        private string student;
        private const string PRIORITY = "*PRIORITY*";
        private const string WORKSTUDY = "Workstudy";
        private const string ADMIN = "Admin";
        private void admin_Load(object sender, EventArgs e)
        {
            createList();
            clearAdmin();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (studentTextBox.Text == "")
            {
                MessageBox.Show("You must enter a name to be added to the student list before attempting to add!");
                return;
            }
            else
            {
                read.addStudent(studentTextBox.Text, WORKSTUDY, null);
                createList();
            }
        }
        private void createList()
        {
            studentListBox.Items.Clear();
            studentTextBox.Clear();
            list = read.SetStudents(WORKSTUDY);
            foreach (string student in list)
            {
                studentListBox.Items.Add(student);
            }
        }
        private void createAdminList()
        {
            adminListBox.Items.Clear();
            adminNameTextBox.Clear();
            adminListBox.Items.Clear();
            list = read.SetStudents(ADMIN);
            foreach (string student in list)
            {
                adminListBox.Items.Add(student);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a student from the list first.");
                return;
            }
            string student = studentListBox.SelectedItem.ToString();
            if (student == PRIORITY)
            {
                MessageBox.Show("Can not delete PRIORITY student, used to add priority shelves to reports!");
                return;
            }
            read.removeStudent(student);
            createList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.Show();
        }

        private void cleaningAddButton_Click(object sender, EventArgs e)
        {
            addChores form = new addChores();
            form.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            User form = new User(false);
            read.loadFloor(this, form);
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            clearStudent();           
            createAdminList();
        }

        private void studentAddRemoveButton_Click(object sender, EventArgs e)
        {
            clearAdmin();
            createList();
        }
        private void clearStudent()
        {
            addStudentPanel.Hide();
            removeStudentPanel.Hide();
            addAdminPanel.Show();
            removeAdminPanel.Show();
        }
        private void clearAdmin()
        {
            addAdminPanel.Hide();
            removeAdminPanel.Hide();
            addStudentPanel.Show();
            removeStudentPanel.Show();
        }

        private void adminList_Click(object sender, EventArgs e)
        {
            if (adminNameTextBox.Text == "")
            {
                MessageBox.Show("You must enter a name to be added to the student list before attempting to add!");
                return;
            }
            else
            {
                read.addStudent(adminNameTextBox.Text, ADMIN, emailTextBox.Text);
                createList();
            }
        }

        private void removeadminButton_Click(object sender, EventArgs e)
        {
            if (adminListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a student from the list first.");
                return;
            }
            string student = adminListBox.SelectedItem.ToString();
            if (student == PRIORITY)
            {
                MessageBox.Show("Can not delete PRIORITY student, used to add priority shelves to reports!");
                return;
            }
            read.removeStudent(student);
            createAdminList();
        }

        private void changeRangeButton_Click(object sender, EventArgs e)
        {
            AlterRanges form = new AlterRanges();
            read.loadFloor(this, form);
        }
    }
}
