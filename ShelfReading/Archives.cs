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
    public partial class Archives : Form
    {
        private string s;
        private int bookcase = 0;
        private string b = "";
        ToolTip tooltip = new ToolTip();
        Reading read = new Reading();
        private const int EIGHTEEN = 18;
        private const int SIX = 6;
        private const int TWELVE = 12;
        private const int NINE = 9;
        private const int SEVEN = 7;
        private const int EIGHT = 8;
        private const int THREE = 3;
        private int caseNum;
        private List<string> list = new List<string>();
        public Archives(string student)
        {
            s = student;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void createRange(string bookcase)
        {
            tooltip = new ToolTip();
            list = read.Bookcase(bookcase);
            string begin = list[0];
            string end = list[1];
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            tooltip.Show(begin + " TO " + end, this, x + 10, y);
        }  
        private void Reserves_MouseHover(object sender, EventArgs e)
        {
            createRange(Case109.Name);
        }

        private void PW1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case110.Text);
        }

        private void PW2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case111.Text);
        }

        private void PW3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case112.Text);
        }

        private void PW4_MouseHover(object sender, EventArgs e)
        {
            createRange(Case113.Text);
        }

        private void PW5_MouseHover(object sender, EventArgs e)
        {
            createRange(Case114.Text);
        }

        private void PW6_MouseHover(object sender, EventArgs e)
        {
            createRange(Case115.Text);
        }

        private void MVP1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case116.Text);
        }

        private void DVD4_MouseHover(object sender, EventArgs e)
        {
            createRange(Case117.Text);
        }

        private void DVD5_MouseHover(object sender, EventArgs e)
        {
            createRange(Case118.Text);
        }

        private void DVD6_MouseHover(object sender, EventArgs e)
        {
            createRange(Case119.Text);
        }

        private void Telecourse1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case120.Text);
        }

        private void Telecourse2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case121.Text);
        }

        private void Telecourse3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case122.Text);
        }

        private void DVD1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case123.Text);
        }

        private void DVD2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case124.Text);
        }

        private void DVD3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case125.Text);
        }

        private void ListeningCDs_MouseHover(object sender, EventArgs e)
        {
            createRange(Case126.Text);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            tooltip.Dispose();
        }

        private void clearTooltip()
        {
            tooltip.Dispose();
        }

        private void Reserves_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW1_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW2_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW3_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW4_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW5_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void PW6_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void MVP1_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD4_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD5_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD6_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Telecourse1_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Telecourse2_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Telecourse3_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD1_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD2_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void DVD3_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void ListeningCDs_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case109_Click(object sender, EventArgs e)
        {
            string b = Case109.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case109.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, EIGHTEEN, caseNum);
            b = Case109.Text;
            form.ShowDialog(); 
        }

        private void Case110_Click(object sender, EventArgs e)
        {
            string b = Case110.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case110.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case110.Text;
            form.ShowDialog(); 
        }

        private void Case111_Click(object sender, EventArgs e)
        {
            string b = Case111.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case111.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case111.Text;
            form.ShowDialog(); 
        }

        private void Case112_Click(object sender, EventArgs e)
        {
            string b = Case112.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case112.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case112.Text;
            form.ShowDialog(); 
        }

        private void Case113_Click(object sender, EventArgs e)
        {
            string b = Case113.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case113.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, NINE, caseNum);
            b = Case113.Text;
            form.ShowDialog();
        }

        private void Case114_Click(object sender, EventArgs e)
        {
            string b = Case114.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case114.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, NINE, caseNum);
            b = Case114.Text;
            form.ShowDialog();
        }

        private void Case115_Click(object sender, EventArgs e)
        {
            string b = Case115.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case115.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, NINE, caseNum);
            b = Case115.Text;
            form.ShowDialog();
        }

        private void Case116_Click(object sender, EventArgs e)
        {
            string b = Case116.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case116.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWELVE, caseNum);
            b = Case116.Text;
            form.ShowDialog();
        }

        private void Case117_Click(object sender, EventArgs e)
        {
            string b = Case117.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case117.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            b = Case117.Text;
            form.ShowDialog();
        }

        private void Case118_Click(object sender, EventArgs e)
        {
            string b = Case118.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case118.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            b = Case118.Text;
            form.ShowDialog();
        }

        private void Case119_Click(object sender, EventArgs e)
        {
            string b = Case119.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case119.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            b = Case119.Text;
            form.ShowDialog();
        }

        private void Case120_Click(object sender, EventArgs e)
        {
            string b = Case120.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case120.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            b = Case120.Text;
            form.ShowDialog();
        }

        private void Case121_Click(object sender, EventArgs e)
        {
            string b = Case121.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case121.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWELVE, caseNum);
            b = Case121.Text;
            form.ShowDialog();
        }

        private void Case122_Click(object sender, EventArgs e)
        {
            string b = Case122.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case122.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWELVE, caseNum);
            b = Case122.Text;
            form.ShowDialog();
        }

        private void Case123_Click(object sender, EventArgs e)
        {
            string b = Case123.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case123.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, SEVEN, caseNum);
            b = Case123.Text;
            form.ShowDialog();
        }

        private void Case124_Click(object sender, EventArgs e)
        {
            string b = Case124.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case124.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, SEVEN, caseNum);
            b = Case124.Text;
            form.ShowDialog();
        }

        private void Case125_Click(object sender, EventArgs e)
        {
            string b = Case125.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case125.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, SEVEN, caseNum);
            b = Case125.Text;
            form.ShowDialog();
        }

        private void Case126_Click(object sender, EventArgs e)
        {
            string b = Case126.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case126.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, THREE, caseNum);
            b = Case126.Text;
            form.ShowDialog();
        }

        private void Archives_Load(object sender, EventArgs e)
        {
            if (read.getCase(Case109.Name) == true)
            {
                Case109.ForeColor = Color.Black;
                Case109.BackColor = Color.Red;
            }
            if (read.getCase(Case110.Name) == true)
            {
                Case110.ForeColor = Color.Black;
                Case110.BackColor = Color.Red;
            }
            if (read.getCase(Case111.Name) == true)
            {
                Case111.ForeColor = Color.Black;
                Case111.BackColor = Color.Red;
            }
            if (read.getCase(Case112.Name) == true)
            {
                Case112.ForeColor = Color.Black;
                Case112.BackColor = Color.Red;
            }
            if (read.getCase(Case113.Name) == true)
            {
                Case113.ForeColor = Color.Black;
                Case113.BackColor = Color.Red;
            }
            if (read.getCase(Case114.Name) == true)
            {
                Case114.ForeColor = Color.Black;
                Case114.BackColor = Color.Red;
            }
            if (read.getCase(Case115.Name) == true)
            {
                Case115.ForeColor = Color.Black;
                Case115.BackColor = Color.Red;
            }
            if (read.getCase(Case116.Name) == true)
            {
                Case116.ForeColor = Color.Black;
                Case116.BackColor = Color.Red;
            }
            if (read.getCase(Case117.Name) == true)
            {
                Case117.ForeColor = Color.Black;
                Case117.BackColor = Color.Red;
            }
            if (read.getCase(Case118.Name) == true)
            {
                Case118.ForeColor = Color.Black;
                Case118.BackColor = Color.Red;
            }
            if (read.getCase(Case119.Name) == true)
            {
                Case119.ForeColor = Color.Black;
                Case119.BackColor = Color.Red;
            }
            if (read.getCase(Case120.Name) == true)
            {
                Case120.ForeColor = Color.Black;
                Case120.BackColor = Color.Red;
            }
            if (read.getCase(Case121.Name) == true)
            {
                Case121.ForeColor = Color.Black;
                Case121.BackColor = Color.Red;
            }
            if (read.getCase(Case122.Name) == true)
            {
                Case122.ForeColor = Color.Black;
                Case122.BackColor = Color.Red;
            }
            if (read.getCase(Case123.Name) == true)
            {
                Case123.ForeColor = Color.Black;
                Case123.BackColor = Color.Red;
            }
            if (read.getCase(Case124.Name) == true)
            {
                Case124.ForeColor = Color.Black;
                Case124.BackColor = Color.Red;
            }
            if (read.getCase(Case125.Name) == true)
            {
                Case125.ForeColor = Color.Black;
                Case125.BackColor = Color.Red;
            }
            if (read.getCase(Case126.Name) == true)
            {
                Case126.ForeColor = Color.Black;
                Case126.BackColor = Color.Red;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionality not yet implemented!");
            return;
        }
    }
}
