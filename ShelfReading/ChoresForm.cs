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
    public partial class ChoresForm : Form
    {
        private Chores chores = new Chores();
        private List<string> c = new List<string>();
        private string s = "";
        private string h1 = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
        private string h2 = "PRIORITY         TASK             ";
        public ChoresForm(string student)
        {
            s = student;
            InitializeComponent();
        }
       
        private void Chores_Load(object sender, EventArgs e)
        {
            chores.changePriority();
            loadChores();
        }

        private void choresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choresListBox.SelectedIndex < 2)
            {
                MessageBox.Show("Please select a task from the listbox!");
                return;
            }
            directionsTextBox.Text = "";      
            string input = choresListBox.SelectedItem.ToString();
            int i = input.Length;
            int j = input.IndexOf("*");
            j++;
            string sub1 = input.Substring(j, i - j);
            string directions = chores.getDirections(sub1);
            string materials = chores.getMaterials(sub1);
            directions = directions.Replace("*", "\r\n");
            directionsTextBox.Text = directions;
            materialsTextBox.Text = ""; ;
            materials = materials.Replace("-", "\r\n");
            materialsTextBox.Text = materials;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int reset = 5;
            DateTime present = DateTime.Now;
            chores.updatePriority(present, reset, choresListBox.SelectedItem.ToString());
            choresListBox.Items.Clear();
            loadChores();
        }
        private void loadChores()
        {
            c = chores.getChores();
            choresListBox.Items.Add(h2);
            choresListBox.Items.Add(h1);

            foreach (string chore in c)
            {
                choresListBox.Items.Add(chore);
            }
        }
    }
}
