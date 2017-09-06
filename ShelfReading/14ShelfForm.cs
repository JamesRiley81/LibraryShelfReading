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
    public partial class _14ShelfForm : Form
    {
        private string s;
        private string b;
        private string shelf;
        private int c;
        private const int AGE1 = 6;
        private const int AGE2 = 12;
        private bool c1 = false;
        private bool c2 = false;
        private int x;
        private int y;
        private const int SHIFT = 44;
        private bool c3 = false;
        private bool c4 = false;
        private bool c5 = false;
        private bool c6 = false;
        private bool c7 = false;
        private bool c8 = false;
        private bool c9 = false;
        private bool c10 = false;
        private bool c11 = false;
        private bool c12 = false;
        private bool c13 = false;
        private bool c14 = false;
        private int cNumber;
        public _14ShelfForm(string student, int Case, string bookcase, int shelves, int CaseNumber)
        {
            c = Case;
            s = student;
            b = bookcase;
            cNumber = CaseNumber;
            InitializeComponent();
            if (shelves == 7)
            {
                x = checkBox1.Location.X;
                x = x + SHIFT;
                checkBox1.Location = new Point(x, checkBox1.Location.Y);
                checkBox2.Location = new Point(x, checkBox2.Location.Y);
                checkBox3.Location = new Point(x, checkBox3.Location.Y);
                checkBox4.Location = new Point(x, checkBox4.Location.Y);
                checkBox5.Location = new Point(x, checkBox5.Location.Y);
                checkBox6.Location = new Point(x, checkBox6.Location.Y);
                checkBox7.Location = new Point(x, checkBox7.Location.Y);
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                checkBox11.Visible = false;
                checkBox12.Visible = false;
                checkBox13.Visible = false;
                checkBox14.Visible = false;
            }
            if (shelves == 3)
            {
                x = checkBox1.Location.X;
                x = x + SHIFT;
                checkBox1.Location = new Point(x, checkBox1.Location.Y);
                checkBox2.Location = new Point(x, checkBox2.Location.Y);
                checkBox3.Location = new Point(x, checkBox3.Location.Y);
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                checkBox11.Visible = false;
                checkBox12.Visible = false;
                checkBox13.Visible = false;
                checkBox14.Visible = false;
            }
        }     
        Reading read = new Reading();
      
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            shelf = checkBox1.Text;
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Black;
                checkBox1.BackColor = Color.LightBlue;
                c1 = true;
            }
            if (!checkBox1.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox1.BackColor = Color.Green;
                    checkBox1.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox1.BackColor = Color.Yellow;
                    checkBox1.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox1.ForeColor = Color.Black;
                    checkBox1.BackColor = Color.Red;
                }
                c1 = false;
            }          
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            shelf = checkBox2.Text;
            if (checkBox2.Checked)
            {
                checkBox2.BackColor = Color.LightBlue;
                checkBox2.ForeColor = Color.Black;
                c2 = true;
            }
            if (!checkBox2.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox2.BackColor = Color.Green;
                    checkBox2.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox2.BackColor = Color.Yellow;
                    checkBox2.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox2.ForeColor = Color.Black;
                    checkBox2.BackColor = Color.Red;
                }
                c2 = false;
            }   
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            shelf = checkBox3.Text;
            if (checkBox3.Checked)
            {
                checkBox3.BackColor = Color.LightBlue;
                checkBox3.ForeColor = Color.Black;
                c3 = true;
            }
            if (!checkBox3.Checked)
            {

                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox3.BackColor = Color.Green;
                    checkBox3.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox3.BackColor = Color.Yellow;
                    checkBox3.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox3.ForeColor = Color.Black;
                    checkBox3.BackColor = Color.Red;
                }
                c3 = false;
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            shelf = checkBox4.Text;
            if (checkBox4.Checked)
            {
                checkBox4.BackColor = Color.LightBlue;
                checkBox4.ForeColor = Color.Black;
                c4 = true;
            }
            if (!checkBox4.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox4.BackColor = Color.Green;
                    checkBox4.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox4.BackColor = Color.Yellow;
                    checkBox4.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox4.ForeColor = Color.Black;
                    checkBox4.BackColor = Color.Red;
                }
                c4 = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox5.Text;
            if (checkBox5.Checked)
            {
                checkBox5.BackColor = Color.LightBlue;
                checkBox5.ForeColor = Color.Black;
                c5 = true;
            }
            if (!checkBox5.Checked)
            {

                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox5.BackColor = Color.Green;
                    checkBox5.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox5.BackColor = Color.Yellow;
                    checkBox5.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox5.ForeColor = Color.Black;
                    checkBox5.BackColor = Color.Red;
                }
                c5 = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox6.Text;
            if (checkBox6.Checked)
            {
                checkBox6.BackColor = Color.LightBlue;
                checkBox6.ForeColor = Color.Black;
                c6 = true;
            }
            if (!checkBox6.Checked)
            {

                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox6.BackColor = Color.Green;
                    checkBox6.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox6.BackColor = Color.Yellow;
                    checkBox6.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox6.ForeColor = Color.Black;
                    checkBox6.BackColor = Color.Red;
                }
                c6 = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox7.Text;
            if (checkBox7.Checked)
            {
                checkBox7.BackColor = Color.LightBlue;
                checkBox7.ForeColor = Color.Black;
                c7 = true;
            }
            if (!checkBox7.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox7.BackColor = Color.Green;
                    checkBox7.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox7.BackColor = Color.Yellow;
                    checkBox7.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox7.ForeColor = Color.Black;
                    checkBox7.BackColor = Color.Red;
                }
                c7 = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox8.Text;
            if (checkBox8.Checked)
            {
                checkBox8.BackColor = Color.LightBlue;
                checkBox8.ForeColor = Color.Black;
                c8 = true;
            }
            if (!checkBox8.Checked)
            {

                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox8.BackColor = Color.Green;
                    checkBox8.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox8.BackColor = Color.Yellow;
                    checkBox8.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox8.ForeColor = Color.Black;
                    checkBox8.BackColor = Color.Red;
                }
                c8 = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox9.Text;
            if (checkBox9.Checked)
            {
                checkBox9.BackColor = Color.LightBlue;
                checkBox9.ForeColor = Color.Black;
                c9 = true;
            }
            if (!checkBox9.Checked)
            {

                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox9.BackColor = Color.Green;
                    checkBox9.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox9.BackColor = Color.Yellow;
                    checkBox9.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox9.ForeColor = Color.Black;
                    checkBox9.BackColor = Color.Red;
                }
                c9 = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox10.Text;
            if (checkBox10.Checked)
            {
                checkBox10.BackColor = Color.LightBlue;
                checkBox10.ForeColor = Color.Black;
                c10 = true;
            }
            if (!checkBox10.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox10.BackColor = Color.Green;
                    checkBox10.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox10.BackColor = Color.Yellow;
                    checkBox10.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox10.ForeColor = Color.Black;
                    checkBox10.BackColor = Color.Red;
                }
                c10 = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox11.Text;
            if (checkBox11.Checked)
            {
                checkBox11.BackColor = Color.LightBlue;
                checkBox11.ForeColor = Color.Black;
                c11 = true;
            }
            if (!checkBox11.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox11.BackColor = Color.Green;
                    checkBox11.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox11.BackColor = Color.Yellow;
                    checkBox11.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox11.ForeColor = Color.Black;
                    checkBox11.BackColor = Color.Red;
                }
                c11 = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox12.Text;
            if (checkBox12.Checked)
            {
                checkBox12.BackColor = Color.LightBlue;
                checkBox12.ForeColor = Color.Black;
                c12 = true;
            }
            if (!checkBox12.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox12.BackColor = Color.Green;
                    checkBox12.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox12.BackColor = Color.Yellow;
                    checkBox12.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox12.ForeColor = Color.Black;
                    checkBox12.BackColor = Color.Red;
                }
                c12 = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox13.Text;
            if (checkBox13.Checked)
            {
                checkBox13.BackColor = Color.LightBlue;
                checkBox13.ForeColor = Color.Black;
                c13 = true;
            }
            if (!checkBox13.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox13.BackColor = Color.Green;
                    checkBox13.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox13.BackColor = Color.Yellow;
                    checkBox13.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox13.ForeColor = Color.Black;
                    checkBox13.BackColor = Color.Red;
                }
                c13 = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            shelf = checkBox14.Text;
            if (checkBox14.Checked)
            {
                checkBox14.BackColor = Color.LightBlue;
                checkBox14.ForeColor = Color.Black;
                c14 = true;
            }
            if (!checkBox14.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox14.BackColor = Color.Green;
                    checkBox14.ForeColor = Color.Blue;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox14.BackColor = Color.Yellow;
                    checkBox14.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox14.ForeColor = Color.Black;
                    checkBox14.BackColor = Color.Red;
                }
                c14 = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1 == true)
                {
                    string shelf = checkBox1.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c2 == true)
                {
                    string shelf = checkBox2.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c3 == true)
                {
                    string shelf = checkBox3.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c4 == true)
                {
                    string shelf = checkBox4.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c5 == true)
                {
                    string shelf = checkBox5.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c6 == true)
                {
                    string shelf = checkBox6.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c7 == true)
                {
                    string shelf = checkBox7.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c8 == true)
                {
                    string shelf = checkBox8.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c9 == true)
                {
                    string shelf = checkBox9.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c10 == true)
                {
                    string shelf = checkBox10.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c11 == true)
                {
                    string shelf = checkBox11.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c12 == true)
                {
                    string shelf = checkBox12.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c13 == true)
                {
                    string shelf = checkBox12.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c14 == true)
                {
                    string shelf = checkBox14.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                MessageBox.Show("Records have been successfully added.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not enter values into records/r/n" + ex);
                this.Close();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _14ShelfForm_Load(object sender, EventArgs e)
        {
            string shelf = checkBox1.Text;
            int age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox1.BackColor = Color.Green;
                checkBox1.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox1.BackColor = Color.Yellow;
                checkBox1.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox1.ForeColor = Color.Black;
                checkBox1.BackColor = Color.Red;
            }
            shelf = checkBox2.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox2.BackColor = Color.Green;
                checkBox2.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox2.BackColor = Color.Yellow;
                checkBox2.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox2.ForeColor = Color.Black;
                checkBox2.BackColor = Color.Red;
            }
            shelf = checkBox3.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox3.BackColor = Color.Green;
                checkBox3.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox3.BackColor = Color.Yellow;
                checkBox3.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox3.ForeColor = Color.Black;
                checkBox3.BackColor = Color.Red;
            }
            shelf = checkBox4.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox4.BackColor = Color.Green;
                checkBox4.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox4.BackColor = Color.Yellow;
                checkBox4.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox4.ForeColor = Color.Black;
                checkBox4.BackColor = Color.Red;
            }
            shelf = checkBox5.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox5.BackColor = Color.Green;
                checkBox5.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox5.BackColor = Color.Yellow;
                checkBox5.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox5.ForeColor = Color.Black;
                checkBox5.BackColor = Color.Red;
            }
            shelf = checkBox6.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox6.BackColor = Color.Green;
                checkBox6.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox6.BackColor = Color.Yellow;
                checkBox6.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox6.ForeColor = Color.Black;
                checkBox6.BackColor = Color.Red;
            }
            shelf = checkBox7.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox7.BackColor = Color.Green;
                checkBox7.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox7.BackColor = Color.Yellow;
                checkBox7.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox7.ForeColor = Color.Black;
                checkBox7.BackColor = Color.Red;
            }
            shelf = checkBox8.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox8.BackColor = Color.Green;
                checkBox8.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox8.BackColor = Color.Yellow;
                checkBox8.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox8.ForeColor = Color.Black;
                checkBox8.BackColor = Color.Red;
            }
            shelf = checkBox9.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox9.BackColor = Color.Green;
                checkBox9.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox9.BackColor = Color.Yellow;
                checkBox9.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox9.ForeColor = Color.Black;
                checkBox9.BackColor = Color.Red;
            }
            shelf = checkBox10.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox10.BackColor = Color.Green;
                checkBox10.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox10.BackColor = Color.Yellow;
                checkBox10.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox10.ForeColor = Color.Black;
                checkBox10.BackColor = Color.Red;
            }
            shelf = checkBox11.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox11.BackColor = Color.Green;
                checkBox11.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox11.BackColor = Color.Yellow;
                checkBox11.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox11.ForeColor = Color.Black;
                checkBox11.BackColor = Color.Red;
            }
            shelf = checkBox12.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox12.BackColor = Color.Green;
                checkBox12.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox12.BackColor = Color.Yellow;
                checkBox12.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox12.ForeColor = Color.Black;
                checkBox12.BackColor = Color.Red;
            }
            shelf = checkBox13.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox13.BackColor = Color.Green;
                checkBox13.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox13.BackColor = Color.Yellow;
                checkBox13.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox13.ForeColor = Color.Black;
                checkBox13.BackColor = Color.Red;
            }
            shelf = checkBox14.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox14.BackColor = Color.Green;
                checkBox14.ForeColor = Color.Blue;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox14.BackColor = Color.Yellow;
                checkBox14.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox14.ForeColor = Color.Black;
                checkBox14.BackColor = Color.Red;
            }
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox1.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox2.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox3_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox3.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox4_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox4.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox5_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox5.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox6_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox6.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox7_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox7.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox8_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox8.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox9_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox9.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox10_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox10.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox11_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox11.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox12_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox12.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox13_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox13.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox14_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox14.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked)
            {
                allCheckBox.Text = "Uncheck all.";
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
                checkBox11.Checked = true;
                checkBox12.Checked = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true;
            }
            else
            {
                allCheckBox.Text = "Check all.";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
            }

        }

        
    }
}
