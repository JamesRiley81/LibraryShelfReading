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
    public partial class AlterRanges : Form
    {
        public AlterRanges()
        {
            InitializeComponent();
        }
        private Reading read = new Reading();
        private int divisor = 2;
        private List<string> list = new List<string>();
        private void AlterRanges_Load(object sender, EventArgs e)
        {
            list.Clear();
            list = read.bookcases();
            foreach(string Case in list)
            {
                casesListBox.Items.Add(Case);
            }
        }

        private void changeCaseButton_Click(object sender, EventArgs e)
        {
            if (casesListBox.SelectedIndex % divisor == 1 )
            {
                MessageBox.Show("Please select case from listbox!");
                return;
            }
            if (casesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must make a selection from the listbox first!");
                return;
            }
            string selected = casesListBox.SelectedItem.ToString();
            int i = selected.IndexOf(" ");
            string sub1 = selected.Substring(0, i);
            int j = sub1.Length + 25;
            string sub2 = selected.Substring(j, selected.Length - j);
            string x = Microsoft.VisualBasic.Interaction.InputBox("You have currently selected case: "   + sub1 + "\r\nWith a range of: " + sub2 + "\r\n\r\nPlease input a new start location for this shelf", "Alter Range", "");
            if (x == "")
            {
                MessageBox.Show("No changes made.");
                return;
            }
            string y = Microsoft.VisualBasic.Interaction.InputBox("Please input a new end location for this shelf.", "Alter Range", "");
            if (y == "")
            {
                MessageBox.Show("No changes made.");
                return;
            }
            else
            {
                read.alterCase(sub1, x, y);
                casesView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            User form = new User(false);
            read.loadFloor(this, form);
        }

        private void changeShelfButton_Click(object sender, EventArgs e)
        {
            if (casesListBox.SelectedIndex % divisor == 1)
            {
                MessageBox.Show("Please select case from listbox!");
                return;
            }
            if (casesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must make a selection from the listbox first!");
                return;
            }
            read.setTemp(casesListBox.SelectedItem.ToString());
            shelvesView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            AlterRanges form = new AlterRanges();
            read.loadFloor(this, form);
        }

        private void selectShelfButton_Click(object sender, EventArgs e)
        {
            if (casesListBox.SelectedIndex % divisor == 1)
            {
                MessageBox.Show("Please select a shelf from listbox!");
                return;
            }
            if (casesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must make a selection from the listbox first!");
                return;
            }
            string selected = casesListBox.SelectedItem.ToString();
            int i = selected.IndexOf(" ");
           string sub1 = selected.Substring(0, i);
            
            int j = sub1.Length + 25;
            string sub2 = selected.Substring(j, selected.Length - j);
            string x = Microsoft.VisualBasic.Interaction.InputBox("You have currently selected shelf: " + sub1 + "\r\nWith a range of: " + sub2 + "\r\n\r\nPlease input a new start location for this shelf", "Alter Range", "");
            if (x == "")
            {
                MessageBox.Show("No changes made.");
                return;
            }
            string y = Microsoft.VisualBasic.Interaction.InputBox("Please input a new end location for this shelf.", "Alter Range", "");
            if (y == "")
            {
                MessageBox.Show("No changes made.");
                return;
            }
            else
            {               
                read.alterShelf(sub1, x, y);
                shelvesView();
            }
        }

        private void backToCasesButton_Click(object sender, EventArgs e)
        {
            casesView();
        }
        private void shelvesView()
        {
            changeCaseButton.Visible = false;
            changeShelfButton.Visible = false;
            selectShelfButton.Visible = true;
            backToCasesButton.Visible = true;
            changeCaseButton.SendToBack();
            string selected = read.getTemp();
            casesListBox.Items.Clear();
            int i = selected.IndexOf(" ");
            string sub1 = selected.Substring(0, i);
            list = read.loadShelves(sub1);
            foreach (string input in list)
            {
                casesListBox.Items.Add(input);
            }
        }
        private void casesView()
        {
            list.Clear();
            list = read.bookcases();
            casesListBox.Items.Clear();
            foreach (string Case in list)
            {
                casesListBox.Items.Add(Case);
            }
            changeCaseButton.Visible = true;
            changeShelfButton.Visible = true;
            selectShelfButton.Visible = false;
            backToCasesButton.Visible = false;
            backToCasesButton.SendToBack();
        }
    }
}
