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
    public partial class _30ShelfForm : Form
    {
        private string s;
        private string b;
        private int c;
        private const int AGE1 = 6;
        private const int AGE2 = 12;
        private string shelf;
        private bool c1 = false;
        private bool c2 = false;
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
        private bool c15 = false;
        private bool c16 = false;
        private bool c17 = false;
        private bool c18 = false;
        private bool c19 = false;
        private bool c20 = false;
        private bool c21 = false;
        private bool c22 = false;
        private bool c23 = false;
        private bool c24 = false;
        private bool c25 = false;
        private bool c26 = false;
        private bool c27 = false;
        private bool c28 = false;
        private bool c29 = false;
        private bool c30 = false;
        private bool c31 = false;
        private bool c32 = false;
        private bool c33 = false;
        private bool c34 = false;
        private int cNumber;
        private bool c35 = false;
        private const int SHIFT = 44;
        public _30ShelfForm(string student, int Case, string bookcase, int shelves, int CaseNumber)
        {
            s = student;
            b = bookcase;
            c = Case;
            cNumber = CaseNumber;
            InitializeComponent();
            int x = checkBox6.Location.X;
            int y = checkBox6.Location.Y;
            if (shelves == 35)
            {
                checkBox7.Location = new Point(x, y + SHIFT);
                x = checkBox8.Location.X;
                y = checkBox8.Location.Y;
                checkBox8.Location = new Point(x, y - SHIFT);
                checkBox9.Location = new Point(x, y);
                checkBox10.Location = new Point(x, y + SHIFT);
                checkBox11.Location = new Point(x, y + SHIFT * 2);
                checkBox12.Location = new Point(x, y + SHIFT * 3);
                checkBox13.Location = new Point(x, y + SHIFT * 4);
                checkBox14.Location = new Point(x, y + SHIFT * 5);
                x = checkBox15.Location.X;
                y = checkBox15.Location.Y;
                checkBox15.Location = new Point(x, y - SHIFT * 2);
                checkBox16.Location = new Point(x, y - SHIFT);
                checkBox17.Location = new Point(x, y);
                checkBox18.Location = new Point(x, y + SHIFT);
                checkBox19.Location = new Point(x, y + SHIFT * 2);
                checkBox20.Location = new Point(x, y + SHIFT * 3);
                checkBox21.Location = new Point(x, y + SHIFT * 4);
                x = checkBox22.Location.X;
                y = checkBox22.Location.Y;
                checkBox22.Location = new Point(x, y - SHIFT * 3);
                checkBox23.Location = new Point(x, y - SHIFT * 2);
                checkBox24.Location = new Point(x, y - SHIFT);
                checkBox25.Location = new Point(x, y);
                checkBox26.Location = new Point(x, y + SHIFT );
                checkBox27.Location = new Point(x, y + SHIFT * 2);
                checkBox28.Location = new Point(x, y + SHIFT * 3);
                x = checkBox29.Location.X;
                y = checkBox29.Location.Y;
                checkBox29.Location = new Point(x, y - SHIFT * 4);
                checkBox30.Location = new Point(x, y - SHIFT * 3);
                checkBox31.Location = new Point(x, y - SHIFT * 2);
                checkBox32.Location = new Point(x, y - SHIFT);
                checkBox33.Location = new Point(x, y);
                checkBox34.Location = new Point(x, y + SHIFT);
                checkBox35.Location = new Point(x, y + SHIFT * 2);
                checkBox31.Visible = true;
                checkBox32.Visible = true;
                checkBox33.Visible = true;
                checkBox34.Visible = true;
                checkBox35.Visible = true;
            }
            if (shelves == 33)
            {
                checkBox7.Location = new Point(x, y + SHIFT);
                x = checkBox8.Location.X;
                y = checkBox8.Location.Y;
                checkBox8.Location = new Point(x, y - SHIFT);
                checkBox9.Location = new Point(x, y);
                checkBox10.Location = new Point(x, y + SHIFT);
                checkBox11.Location = new Point(x, y + SHIFT * 2);
                checkBox12.Location = new Point(x, y + SHIFT * 3);
                checkBox13.Location = new Point(x, y + SHIFT * 4);
                checkBox14.Location = new Point(x, y + SHIFT * 5);
                x = checkBox15.Location.X;
                y = checkBox15.Location.Y;
                checkBox15.Location = new Point(x, y - SHIFT * 2);
                checkBox16.Location = new Point(x, y - SHIFT);
                checkBox17.Location = new Point(x, y);
                checkBox18.Location = new Point(x, y + SHIFT);
                checkBox19.Location = new Point(x, y + SHIFT * 2);
                checkBox20.Location = new Point(x, y + SHIFT * 3);
                checkBox21.Location = new Point(x, y + SHIFT * 4);
                x = checkBox22.Location.X;
                y = checkBox22.Location.Y;
                checkBox22.Location = new Point(x, y - SHIFT * 3);
                checkBox23.Location = new Point(x, y - SHIFT * 2);
                checkBox24.Location = new Point(x, y - SHIFT);
                checkBox25.Location = new Point(x, y);
                checkBox26.Location = new Point(x, y + SHIFT);
                checkBox27.Location = new Point(x, y + SHIFT * 2);
                x = checkBox28.Location.X;
                y = checkBox29.Location.Y;
                checkBox28.Location = new Point(x, y - SHIFT * 4);
                checkBox29.Location = new Point(x, y - SHIFT * 3);
                checkBox30.Location = new Point(x, y - SHIFT * 2);
                checkBox31.Location = new Point(x, y - SHIFT);
                checkBox32.Location = new Point(x, y);
                checkBox33.Location = new Point(x, y + SHIFT);
                checkBox31.Visible = true;
                checkBox32.Visible = true;
                checkBox33.Visible = true;
            }
            if (shelves == 28)
            {
                y = shelfrangePrompt.Location.Y;
                x = shelfrangePrompt.Location.X;
                shelfrangePrompt.Location = new Point(x - SHIFT, y);
                y = sectionLabel.Location.Y;
                x = sectionLabel.Location.X;
                sectionLabel.Location = new Point(x - SHIFT, y);
                y = saveButton.Location.Y;
                saveButton.Location = new Point(x - SHIFT, y);
                y = exitButton.Location.Y;
                x = exitButton.Location.X;
                exitButton.Location = new Point(x - SHIFT, y);
                x = checkBox6.Location.X;
                y = checkBox6.Location.Y;
                checkBox7.Location = new Point(x, y + SHIFT);
                x = checkBox8.Location.X;
                y = checkBox8.Location.Y;
                checkBox8.Location = new Point(x, y - SHIFT);
                checkBox9.Location = new Point(x, y);
                checkBox10.Location = new Point(x, y + SHIFT);
                checkBox11.Location = new Point(x, y + SHIFT * 2);
                checkBox12.Location = new Point(x, y + SHIFT * 3);
                checkBox13.Location = new Point(x, y + SHIFT * 4);
                checkBox14.Location = new Point(x, y + SHIFT * 5);
                x = checkBox15.Location.X;
                y = checkBox15.Location.Y;
                checkBox15.Location = new Point(x, y - SHIFT * 2);
                checkBox16.Location = new Point(x, y - SHIFT);
                checkBox17.Location = new Point(x, y);
                checkBox18.Location = new Point(x, y + SHIFT);
                checkBox19.Location = new Point(x, y + SHIFT * 2);
                checkBox20.Location = new Point(x, y + SHIFT * 3);
                checkBox21.Location = new Point(x, y + SHIFT * 4);
                x = checkBox22.Location.X;
                y = checkBox22.Location.Y;
                checkBox22.Location = new Point(x, y - SHIFT * 3);
                checkBox23.Location = new Point(x, y - SHIFT * 2);
                checkBox24.Location = new Point(x, y - SHIFT);
                checkBox25.Location = new Point(x, y);
                checkBox26.Location = new Point(x, y + SHIFT);
                checkBox27.Location = new Point(x, y + SHIFT * 2);
                checkBox28.Location = new Point(x, y + SHIFT * 3);
                x = checkBox29.Location.X;
                y = checkBox29.Location.Y;
                checkBox29.Visible = false;
                checkBox30.Visible = false;          
            }
            if (shelves == 25)
            {
                x = checkBox6.Location.X;
                y = checkBox6.Location.Y;
                checkBox7.Location = new Point(x, y + SHIFT);
                x = checkBox8.Location.X;
                y = checkBox8.Location.Y;
                checkBox8.Location = new Point(x, y - SHIFT);
                checkBox9.Location = new Point(x, y);
                checkBox10.Location = new Point(x, y + SHIFT);
                checkBox11.Location = new Point(x, y + SHIFT * 2);
                checkBox12.Location = new Point(x, y + SHIFT * 3);
                checkBox13.Location = new Point(x, y + SHIFT * 4);
                checkBox14.Location = new Point(x, y + SHIFT * 5);
                x = checkBox15.Location.X;
                y = checkBox15.Location.Y;
                checkBox16.Location = new Point(x, y + SHIFT);
                checkBox17.Location = new Point(x, y + SHIFT * 2);
                checkBox18.Location = new Point(x, y + SHIFT * 3);
                checkBox19.Location = new Point(x, y + SHIFT *4);
                x = checkBox24.Location.X;
                y = checkBox24.Location.Y;
                checkBox25.Location = new Point(x, y + SHIFT);
                checkBox26.Visible = false;
                checkBox27.Visible = false;
                checkBox28.Visible = false;
                checkBox29.Visible = false;
                checkBox30.Visible = false;

            }
            if (shelves == 282)
            {
                x = checkBox13.Location.X;
                y = checkBox13.Location.Y;
                checkBox13.Location = new Point(x, y + SHIFT);
                checkBox14.Location = new Point(x, y + SHIFT * 2);
                checkBox15.Location = new Point(x, y + SHIFT * 3);
                checkBox16.Location = new Point(x, y + SHIFT * 4);
                checkBox17.Location = new Point(x, y + SHIFT * 5);
                x = checkBox19.Location.X;
                y = checkBox19.Location.Y;
                checkBox18.Location = new Point(x, y + SHIFT);
                checkBox19.Location = new Point(x, y + SHIFT * 2);
                checkBox20.Location = new Point(x, y + SHIFT * 3);
                checkBox21.Location = new Point(x, y + SHIFT * 4);
                checkBox22.Location = new Point(x, y + SHIFT * 5);
                x = checkBox25.Location.X;
                y = checkBox25.Location.Y;
                checkBox23.Location = new Point(x, y);
                checkBox24.Location = new Point(x, y + SHIFT);
                checkBox25.Location = new Point(x, y + SHIFT * 2);
                checkBox26.Location = new Point(x, y + SHIFT * 3);
                checkBox27.Location = new Point(x, y + SHIFT * 4);
                checkBox28.Location = new Point(x, y + SHIFT *5);
                checkBox29.Visible = false;
                checkBox30.Visible = false;
            }
        }
        Reading read = new Reading();
        private void _30ShelfForm_Load(object sender, EventArgs e)
        {
            setColors();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Black;
                checkBox1.BackColor = Color.White;
                c1 = true;
            }
            if (!checkBox1.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox1.BackColor = Color.Green;
                    checkBox1.ForeColor = Color.White;
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
        private void setColors()
        {
            string shelf = checkBox1.Text;
            int age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox1.BackColor = Color.Green;
                checkBox1.ForeColor = Color.White;
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
                checkBox2.ForeColor = Color.White;
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
                checkBox3.ForeColor = Color.White;
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
                checkBox4.ForeColor = Color.White;
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
                checkBox5.ForeColor = Color.White;
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
                checkBox6.ForeColor = Color.White;
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
                checkBox7.ForeColor = Color.White;
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
                checkBox8.ForeColor = Color.White;
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
                checkBox9.ForeColor = Color.White;
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
                checkBox10.ForeColor = Color.White;
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
                checkBox11.ForeColor = Color.White;
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
                checkBox12.ForeColor = Color.White;
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
                checkBox13.ForeColor = Color.White;
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
                checkBox14.ForeColor = Color.White;
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
            shelf = checkBox15.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox15.BackColor = Color.Green;
                checkBox15.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox15.BackColor = Color.Yellow;
                checkBox15.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox15.ForeColor = Color.Black;
                checkBox15.BackColor = Color.Red;
            }
            shelf = checkBox16.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox16.BackColor = Color.Green;
                checkBox16.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox16.BackColor = Color.Yellow;
                checkBox16.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox16.ForeColor = Color.Black;
                checkBox16.BackColor = Color.Red;
            }
            shelf = checkBox17.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox17.BackColor = Color.Green;
                checkBox17.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox17.BackColor = Color.Yellow;
                checkBox17.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox17.ForeColor = Color.Black;
                checkBox17.BackColor = Color.Red;
            }
            shelf = checkBox18.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox18.BackColor = Color.Green;
                checkBox18.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox18.BackColor = Color.Yellow;
                checkBox18.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox18.ForeColor = Color.Black;
                checkBox18.BackColor = Color.Red;
            }
            shelf = checkBox19.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox19.BackColor = Color.Green;
                checkBox19.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox19.BackColor = Color.Yellow;
                checkBox19.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox19.ForeColor = Color.Black;
                checkBox19.BackColor = Color.Red;
            }
            shelf = checkBox20.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox20.BackColor = Color.Green;
                checkBox20.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox20.BackColor = Color.Yellow;
                checkBox20.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox20.ForeColor = Color.Black;
                checkBox20.BackColor = Color.Red;
            }
            shelf = checkBox21.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox21.BackColor = Color.Green;
                checkBox21.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox21.BackColor = Color.Yellow;
                checkBox21.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox21.ForeColor = Color.Black;
                checkBox21.BackColor = Color.Red;
            }
            shelf = checkBox22.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox22.BackColor = Color.Green;
                checkBox22.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox22.BackColor = Color.Yellow;
                checkBox22.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox22.ForeColor = Color.Black;
                checkBox22.BackColor = Color.Red;
            }
            shelf = checkBox23.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox23.BackColor = Color.Green;
                checkBox23.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox23.BackColor = Color.Yellow;
                checkBox23.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox23.ForeColor = Color.Black;
                checkBox23.BackColor = Color.Red;
            }
            shelf = checkBox24.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox24.BackColor = Color.Green;
                checkBox24.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox24.BackColor = Color.Yellow;
                checkBox24.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox24.ForeColor = Color.Black;
                checkBox24.BackColor = Color.Red;
            }
            shelf = checkBox25.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox25.BackColor = Color.Green;
                checkBox25.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox25.BackColor = Color.Yellow;
                checkBox25.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox25.ForeColor = Color.Black;
                checkBox25.BackColor = Color.Red;
            }
            shelf = checkBox26.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox26.BackColor = Color.Green;
                checkBox26.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox26.BackColor = Color.Yellow;
                checkBox26.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox26.ForeColor = Color.Black;
                checkBox26.BackColor = Color.Red;
            }
            shelf = checkBox27.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox27.BackColor = Color.Green;
                checkBox27.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox27.BackColor = Color.Yellow;
                checkBox27.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox27.ForeColor = Color.Black;
                checkBox27.BackColor = Color.Red;
            }
            shelf = checkBox28.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox28.BackColor = Color.Green;
                checkBox28.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox28.BackColor = Color.Yellow;
                checkBox28.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox28.ForeColor = Color.Black;
                checkBox28.BackColor = Color.Red;
            }
            shelf = checkBox29.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox29.BackColor = Color.Green;
                checkBox29.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox29.BackColor = Color.Yellow;
                checkBox29.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox29.ForeColor = Color.Black;
                checkBox29.BackColor = Color.Red;
            }
            shelf = checkBox30.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox30.BackColor = Color.Green;
                checkBox30.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox30.BackColor = Color.Yellow;
                checkBox30.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox30.ForeColor = Color.Black;
                checkBox30.BackColor = Color.Red;
            }
            shelf = checkBox31.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox31.BackColor = Color.Green;
                checkBox31.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox31.BackColor = Color.Yellow;
                checkBox31.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox31.ForeColor = Color.Black;
                checkBox31.BackColor = Color.Red;
            }
            shelf = checkBox32.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox32.BackColor = Color.Green;
                checkBox32.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox32.BackColor = Color.Yellow;
                checkBox32.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox32.ForeColor = Color.Black;
                checkBox32.BackColor = Color.Red;
            }
            shelf = checkBox33.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox33.BackColor = Color.Green;
                checkBox33.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox33.BackColor = Color.Yellow;
                checkBox33.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox33.ForeColor = Color.Black;
                checkBox33.BackColor = Color.Red;
            }
            shelf = checkBox34.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox34.BackColor = Color.Green;
                checkBox34.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox34.BackColor = Color.Yellow;
                checkBox34.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox34.ForeColor = Color.Black;
                checkBox34.BackColor = Color.Red;
            }
            shelf = checkBox35.Text;
            age = read.setStatus(b, shelf);
            if (age <= AGE1)
            {
                checkBox35.BackColor = Color.Green;
                checkBox35.ForeColor = Color.White;
            }
            else if (age > AGE1 && age <= AGE2)
            {
                checkBox35.BackColor = Color.Yellow;
                checkBox35.ForeColor = Color.Gray;
            }
            else if (age > AGE2)
            {
                checkBox35.ForeColor = Color.Black;
                checkBox35.BackColor = Color.Red;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.ForeColor = Color.Black;
                checkBox2.BackColor = Color.White;
                c2 = true;
            }
            if (!checkBox2.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox2.BackColor = Color.Green;
                    checkBox2.ForeColor = Color.White;
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.ForeColor = Color.Black;
                checkBox3.BackColor = Color.White;
                c3 = true;
            }
            if (!checkBox3.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox3.BackColor = Color.Green;
                    checkBox3.ForeColor = Color.White;
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.ForeColor = Color.Black;
                checkBox4.BackColor = Color.White;
                c4 = true;
            }
            if (!checkBox4.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox4.BackColor = Color.Green;
                    checkBox4.ForeColor = Color.White;
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
            if (checkBox5.Checked)
            {
                checkBox5.ForeColor = Color.Black;
                checkBox5.BackColor = Color.White;
                c5 = true;
            }
            if (!checkBox5.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox5.BackColor = Color.Green;
                    checkBox5.ForeColor = Color.White;
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
            if (checkBox6.Checked)
            {
                checkBox6.ForeColor = Color.Black;
                checkBox6.BackColor = Color.White;
                c6 = true;
            }
            if (!checkBox6.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox6.BackColor = Color.Green;
                    checkBox6.ForeColor = Color.White;
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
            if (checkBox7.Checked)
            {
                checkBox7.ForeColor = Color.Black;
                checkBox7.BackColor = Color.White;
                c7 = true;
            }
            if (!checkBox7.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox7.BackColor = Color.Green;
                    checkBox7.ForeColor = Color.White;
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
            if (checkBox8.Checked)
            {
                checkBox8.ForeColor = Color.Black;
                checkBox8.BackColor = Color.White;
                c8 = true;
            }
            if (!checkBox8.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox8.BackColor = Color.Green;
                    checkBox8.ForeColor = Color.White;
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
            if (checkBox9.Checked)
            {
                checkBox9.ForeColor = Color.Black;
                checkBox9.BackColor = Color.White;
                c9 = true;
            }
            if (!checkBox9.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox9.BackColor = Color.Green;
                    checkBox9.ForeColor = Color.White;
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
            if (checkBox10.Checked)
            {
                checkBox10.ForeColor = Color.Black;
                checkBox10.BackColor = Color.White;
                c10 = true;
            }
            if (!checkBox10.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox10.BackColor = Color.Green;
                    checkBox10.ForeColor = Color.White;
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
            if (checkBox11.Checked)
            {
                checkBox11.ForeColor = Color.Black;
                checkBox11.BackColor = Color.White;
                c11 = true;
            }
            if (!checkBox11.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox11.BackColor = Color.Green;
                    checkBox11.ForeColor = Color.White;
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
            if (checkBox12.Checked)
            {
                checkBox12.ForeColor = Color.Black;
                checkBox12.BackColor = Color.White;
                c12 = true;
            }
            if (!checkBox12.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox12.BackColor = Color.Green;
                    checkBox12.ForeColor = Color.White;
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
            if (checkBox13.Checked)
            {
                checkBox13.ForeColor = Color.Black;
                checkBox13.BackColor = Color.White;
                c13 = true;
            }
            if (!checkBox13.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox13.BackColor = Color.Green;
                    checkBox13.ForeColor = Color.White;
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
            if (checkBox14.Checked)
            {
                checkBox14.ForeColor = Color.Black;
                checkBox14.BackColor = Color.White;
                c14 = true;
            }
            if (!checkBox14.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox14.BackColor = Color.Green;
                    checkBox14.ForeColor = Color.White;
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

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox15.ForeColor = Color.Black;
                checkBox15.BackColor = Color.White;
                c15 = true;
            }
            if (!checkBox15.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox15.BackColor = Color.Green;
                    checkBox15.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox15.BackColor = Color.Yellow;
                    checkBox15.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox15.ForeColor = Color.Black;
                    checkBox15.BackColor = Color.Red;
                }
                c15 = false;
            }   
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox16.ForeColor = Color.Black;
                checkBox16.BackColor = Color.White;
                c16 = true;
            }
            if (!checkBox16.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox16.BackColor = Color.Green;
                    checkBox16.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox16.BackColor = Color.Yellow;
                    checkBox16.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox16.ForeColor = Color.Black;
                    checkBox16.BackColor = Color.Red;
                }
                c16 = false;
            }   
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox17.ForeColor = Color.Black;
                checkBox17.BackColor = Color.White;
                c17 = true;
            }
            if (!checkBox17.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox17.BackColor = Color.Green;
                    checkBox17.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox17.BackColor = Color.Yellow;
                    checkBox17.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox17.ForeColor = Color.Black;
                    checkBox17.BackColor = Color.Red;
                }
                c17 = false;
            }   
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox18.ForeColor = Color.Black;
                checkBox18.BackColor = Color.White;
                c18 = true;
            }
            if (!checkBox18.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox18.BackColor = Color.Green;
                    checkBox18.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox18.BackColor = Color.Yellow;
                    checkBox18.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox18.ForeColor = Color.Black;
                    checkBox18.BackColor = Color.Red;
                }
                c18 = false;
            }   
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox19.ForeColor = Color.Black;
                checkBox19.BackColor = Color.White;
                c19 = true;
            }
            if (!checkBox19.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox19.BackColor = Color.Green;
                    checkBox19.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox19.BackColor = Color.Yellow;
                    checkBox19.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox19.ForeColor = Color.Black;
                    checkBox19.BackColor = Color.Red;
                }
                c19 = false;
            }   
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                checkBox20.ForeColor = Color.Black;
                checkBox20.BackColor = Color.White;
                c20 = true;
            }
            if (!checkBox20.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox20.BackColor = Color.Green;
                    checkBox20.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox20.BackColor = Color.Yellow;
                    checkBox20.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox20.ForeColor = Color.Black;
                    checkBox20.BackColor = Color.Red;
                }
                c20 = false;
            }   
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                checkBox21.ForeColor = Color.Black;
                checkBox21.BackColor = Color.White;
                c21 = true;
            }
            if (!checkBox21.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox21.BackColor = Color.Green;
                    checkBox21.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox21.BackColor = Color.Yellow;
                    checkBox21.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox21.ForeColor = Color.Black;
                    checkBox21.BackColor = Color.Red;
                }
                c21 = false;
            }   
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox22.ForeColor = Color.Black;
                checkBox22.BackColor = Color.White;
                c22 = true;
            }
            if (!checkBox22.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox22.BackColor = Color.Green;
                    checkBox22.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox22.BackColor = Color.Yellow;
                    checkBox22.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox22.ForeColor = Color.Black;
                    checkBox22.BackColor = Color.Red;
                }
                c22 = false;
            }   
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                checkBox23.ForeColor = Color.Black;
                checkBox23.BackColor = Color.White;
                c23 = true;
            }
            if (!checkBox23.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox23.BackColor = Color.Green;
                    checkBox23.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox23.BackColor = Color.Yellow;
                    checkBox23.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox23.ForeColor = Color.Black;
                    checkBox23.BackColor = Color.Red;
                }
                c23 = false;
            }   
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox24.ForeColor = Color.Black;
                checkBox24.BackColor = Color.White;
                c24 = true;
            }
            if (!checkBox24.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox24.BackColor = Color.Green;
                    checkBox24.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox24.BackColor = Color.Yellow;
                    checkBox24.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox24.ForeColor = Color.Black;
                    checkBox24.BackColor = Color.Red;
                }
                c24 = false;
            }   
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox25.ForeColor = Color.Black;
                checkBox25.BackColor = Color.White;
                c25 = true;
            }
            if (!checkBox25.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox25.BackColor = Color.Green;
                    checkBox25.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox25.BackColor = Color.Yellow;
                    checkBox25.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox25.ForeColor = Color.Black;
                    checkBox25.BackColor = Color.Red;
                }
                c25 = false;
            }   
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                checkBox26.ForeColor = Color.Black;
                checkBox26.BackColor = Color.White;
                c26 = true;
            }
            if (!checkBox26.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox26.BackColor = Color.Green;
                    checkBox26.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox26.BackColor = Color.Yellow;
                    checkBox26.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox26.ForeColor = Color.Black;
                    checkBox26.BackColor = Color.Red;
                }
                c26 = false;
            }   
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                checkBox27.ForeColor = Color.Black;
                checkBox27.BackColor = Color.White;
                c27 = true;
            }
            if (!checkBox27.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox27.BackColor = Color.Green;
                    checkBox27.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox27.BackColor = Color.Yellow;
                    checkBox27.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox27.ForeColor = Color.Black;
                    checkBox27.BackColor = Color.Red;
                }
                c27 = false;
            }   
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                checkBox28.ForeColor = Color.Black;
                checkBox28.BackColor = Color.White;
                c28 = true;
            }
            if (!checkBox28.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox28.BackColor = Color.Green;
                    checkBox28.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox28.BackColor = Color.Yellow;
                    checkBox28.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox28.ForeColor = Color.Black;
                    checkBox28.BackColor = Color.Red;
                }
                c28 = false;
            }   
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                checkBox29.ForeColor = Color.Black;
                checkBox29.BackColor = Color.White;
                c29 = true;
            }
            if (!checkBox29.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox29.BackColor = Color.Green;
                    checkBox29.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox29.BackColor = Color.Yellow;
                    checkBox29.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox29.ForeColor = Color.Black;
                    checkBox29.BackColor = Color.Red;
                }
                c29 = false;
            }   
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                checkBox30.ForeColor = Color.Black;
                checkBox30.BackColor = Color.White;
                c30 = true;
            }
            if (!checkBox30.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox30.BackColor = Color.Green;
                    checkBox30.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox30.BackColor = Color.Yellow;
                    checkBox30.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox30.ForeColor = Color.Black;
                    checkBox30.BackColor = Color.Red;
                }
                c30 = false;
            }   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1 == true)
                {
                    shelf = checkBox1.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c2 == true)
                {
                    shelf = checkBox2.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c3 == true)
                {
                    shelf = checkBox3.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c4 == true)
                {
                    shelf = checkBox1.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c5 == true)
                {
                    shelf = checkBox5.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c6 == true)
                {
                    shelf = checkBox6.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c7 == true)
                {
                    shelf = checkBox7.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c8 == true)
                {
                    shelf = checkBox8.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c9 == true)
                {
                    shelf = checkBox9.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c10 == true)
                {
                    shelf = checkBox10.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c11 == true)
                {
                    shelf = checkBox11.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c12 == true)
                {
                    shelf = checkBox12.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c13 == true)
                {
                    shelf = checkBox13.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c14 == true)
                {
                    shelf = checkBox14.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c15 == true)
                {
                    shelf = checkBox15.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c16 == true)
                {
                    shelf = checkBox16.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c17 == true)
                {
                    shelf = checkBox17.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c18 == true)
                {
                    shelf = checkBox18.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c19 == true)
                {
                    shelf = checkBox19.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c20 == true)
                {
                    shelf = checkBox20.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c21 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c22 == true)
                {
                    shelf = checkBox22.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c23 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c24 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c25 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c26 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c27 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c28 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c29 == true)
                {
                    shelf = checkBox21.Text;
                    read.Entry(s, b, shelf, cNumber);
                }
                if (c30 == true)
                {
                    shelf = checkBox21.Text;
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

        private void checkBox15_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox15.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox16_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox16.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox17_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox17.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox18_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox18.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox19_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox19.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox20_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox20.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox21_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox21.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox22_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox22.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox23_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox23.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox24_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox24.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox25_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox25.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox26_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox26.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox27_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox27.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox28_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox28.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox29_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox29.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox30_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox30.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                checkBox31.ForeColor = Color.Black;
                checkBox31.BackColor = Color.White;
                c31 = true;
            }
            if (!checkBox31.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox31.BackColor = Color.Green;
                    checkBox31.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox31.BackColor = Color.Yellow;
                    checkBox31.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox31.ForeColor = Color.Black;
                    checkBox31.BackColor = Color.Red;
                }
                c31 = false;
            }          
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                checkBox32.ForeColor = Color.Black;
                checkBox32.BackColor = Color.White;
                c32 = true;
            }
            if (!checkBox32.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox32.BackColor = Color.Green;
                    checkBox32.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox32.BackColor = Color.Yellow;
                    checkBox32.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox32.ForeColor = Color.Black;
                    checkBox32.BackColor = Color.Red;
                }
                c32 = false;
            }          
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
            {
                checkBox33.ForeColor = Color.Black;
                checkBox33.BackColor = Color.White;
                c33 = true;
            }
            if (!checkBox33.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox33.BackColor = Color.Green;
                    checkBox33.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox33.BackColor = Color.Yellow;
                    checkBox33.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox33.ForeColor = Color.Black;
                    checkBox33.BackColor = Color.Red;
                }
                c33 = false;
            }          
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                checkBox34.ForeColor = Color.Black;
                checkBox34.BackColor = Color.White;
                c34 = true;
            }
            if (!checkBox34.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox34.BackColor = Color.Green;
                    checkBox34.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox34.BackColor = Color.Yellow;
                    checkBox34.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox34.ForeColor = Color.Black;
                    checkBox34.BackColor = Color.Red;
                }
                c34 = false;
            }          
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                checkBox35.ForeColor = Color.Black;
                checkBox35.BackColor = Color.White;
                c35 = true;
            }
            if (!checkBox35.Checked)
            {
                int age = read.setStatus(b, shelf);
                if (age <= AGE1)
                {
                    checkBox35.BackColor = Color.Green;
                    checkBox35.ForeColor = Color.White;
                }
                else if (age > AGE1 && age <= AGE2)
                {
                    checkBox35.BackColor = Color.Yellow;
                    checkBox35.ForeColor = Color.Gray;
                }
                else if (age > AGE2)
                {
                    checkBox35.ForeColor = Color.Black;
                    checkBox35.BackColor = Color.Red;
                }
                c35 = false;
            }          
        }

        private void checkBox31_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox31.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox32_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox32.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox33_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox33.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox34_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox34.Text;
            sectionLabel.Text = read.shelves(c, shelf);
        }

        private void checkBox35_MouseHover(object sender, EventArgs e)
        {
            shelf = checkBox35.Text;
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
                checkBox15.Checked = true;
                checkBox16.Checked = true;
                checkBox17.Checked = true;
                checkBox18.Checked = true;
                checkBox19.Checked = true;
                checkBox20.Checked = true;
                checkBox21.Checked = true;
                checkBox22.Checked = true;
                checkBox23.Checked = true;
                checkBox24.Checked = true;
                checkBox25.Checked = true;
                checkBox26.Checked = true;
                checkBox27.Checked = true;
                checkBox28.Checked = true;
                checkBox29.Checked = true;
                checkBox30.Checked = true;
                checkBox31.Checked = true;
                checkBox32.Checked = true;
                checkBox33.Checked = true;
                checkBox34.Checked = true;
                checkBox35.Checked = true;
            }
            else
            {
                allCheckBox.Text = "Select all";
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
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
            }
        }
    }
}
