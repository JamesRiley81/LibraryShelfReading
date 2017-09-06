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
    public partial class Floor2 : Form
    {
        private string s;
        private const int EIGHT = 8;
        private const int NINE = 9;
        private const int TWO = 2;
        private const int SIX = 6;
        private const int SEVEN = 7;
        private const int FOURTEEN = 14;
        private const int FOUR = 4;
        private int bookcase;
        private string b = "";
        private int caseNum;
        private List<string> list = new List<string>();
        ToolTip tooltip = new ToolTip();
        Reading read = new Reading();
        public Floor2(string student)
        {
            InitializeComponent();
            s = student;
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
            time.Start();
        }  
        private void mags1Button_Click(object sender, EventArgs e)
        {
            string b = Case94.Name;
            bookcase = read.convertCase(b);
            b = Case94.Text;
            caseNum = read.convertCase(Case94.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);           
            form.ShowDialog();   
        }

        private void mags2Button_Click(object sender, EventArgs e)
        {
            string b = Case95.Name;
            bookcase = read.convertCase(b);
            b = Case95.Text;
            caseNum = read.convertCase(Case95.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);          
            form.ShowDialog();  
        }

        private void mags3Button_Click(object sender, EventArgs e)
        {
            string b = Case96.Name;
            bookcase = read.convertCase(b);
            b = Case96.Text;
            caseNum = read.convertCase(Case96.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);           
            form.ShowDialog();  
        }

        private void mags4Button_Click(object sender, EventArgs e)
        {
            string b = Case97.Name;
            bookcase = read.convertCase(b);
            b = Case97.Text;
            caseNum = read.convertCase(Case97.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);           
            form.ShowDialog();  
        }

        private void mags5Button_Click(object sender, EventArgs e)
        {
            string b = Case98.Name;
            bookcase = read.convertCase(b);
            b = Case98.Text;
            caseNum = read.convertCase(Case98.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);          
            form.ShowDialog();  
        }

        private void ya1Button_Click(object sender, EventArgs e)
        {
            string b = Case105.Name;
            bookcase = read.convertCase(b);
            b = Case105.Text;
            caseNum = read.convertCase(Case105.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, NINE, caseNum);            
            form.ShowDialog();  
        }
        private void ya2Button_Click(object sender, EventArgs e)
        {
            string b = Case106.Name;
            bookcase = read.convertCase(b);
            b = Case106.Text;
            caseNum = read.convertCase(Case106.Name);
            _9ShelfForm form = new _9ShelfForm(s,bookcase, b, NINE, caseNum);           
            form.ShowDialog();  
        }

        private void over1Button_Click(object sender, EventArgs e)
        {
            string b = Case99.Name;
            bookcase = read.convertCase(b);
            b = Case99.Text;
            caseNum = read.convertCase(Case99.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase,  b, SEVEN, caseNum);          
            form.ShowDialog();  
        }

        private void over2Button_Click(object sender, EventArgs e)
        {
            string b = Case100.Name;
            bookcase = read.convertCase(b);
            b = Case100.Text;
            caseNum = read.convertCase(Case100.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            form.ShowDialog();  
        }

        private void ref1Button_Click(object sender, EventArgs e)
        {
            string b = Case71.Name;
            bookcase = read.convertCase(b);
            b = Case71.Text;
            caseNum = read.convertCase(Case71.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase,  b, EIGHT, caseNum);            
            form.ShowDialog();  
        }

        private void ref2Button_Click(object sender, EventArgs e)
        {
            string b = Case72.Name;
            bookcase = read.convertCase(b);
            b = Case72.Text;
            caseNum = read.convertCase(Case72.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);        
            form.ShowDialog();  
        }

        private void ref3Button_Click(object sender, EventArgs e)
        {
            string b = Case73.Name;
            bookcase = read.convertCase(b);
            b = Case73.Text;
            caseNum = read.convertCase(Case73.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, FOUR, caseNum);            
            form.ShowDialog();  
        }

        private void ref4Button_Click(object sender, EventArgs e)
        {
            string b = Case74.Name;
            bookcase = read.convertCase(b);
            b = Case74.Text;
            caseNum = read.convertCase(Case74.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, FOUR, caseNum);           
            form.ShowDialog();  
        }

        private void ref5Button_Click(object sender, EventArgs e)
        {
            string b = Case75.Name;
            bookcase = read.convertCase(b);
            b = Case75.Text;
            caseNum = read.convertCase(Case75.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);           
            form.ShowDialog();  
        }

        private void ref6Button_Click(object sender, EventArgs e)
        {
            string b = Case76.Name;
            bookcase = read.convertCase(b);
            b = Case76.Text;
            caseNum = read.convertCase(Case76.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);          
            form.ShowDialog();  
        }

        private void ref7Button_Click(object sender, EventArgs e)
        {
            string b = Case77.Name;
            bookcase = read.convertCase(b);
            b = Case77.Text;
            caseNum = read.convertCase(Case77.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, FOUR, caseNum);          
            form.ShowDialog();  
        }

        private void ref8Button_Click(object sender, EventArgs e)
        {
            string b = Case78.Name;
            bookcase = read.convertCase(b);
            b = Case78.Text;
            caseNum = read.convertCase(Case78.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, FOUR, caseNum);          
            form.ShowDialog();  
        }

        private void ref9Button_Click(object sender, EventArgs e)
        {
            string b = Case79.Name;
            bookcase = read.convertCase(b);
            b = Case79.Text;
            caseNum = read.convertCase(Case79.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);           
            form.ShowDialog();  
        }

        private void ref10Button_Click(object sender, EventArgs e)
        {
            string b = Case80.Name;
            bookcase = read.convertCase(b);
            b = Case80.Text;
            caseNum = read.convertCase(Case80.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            form.ShowDialog();  
        }

        private void new1Button_Click(object sender, EventArgs e)
        {
            string b = Case89.Name;
            bookcase = read.convertCase(b);
            b = Case89.Text;
            caseNum = read.convertCase(Case89.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);            
            form.ShowDialog();
        }

        private void new2Button_Click(object sender, EventArgs e)
        {
            string b = Case90.Name;
            bookcase = read.convertCase(b);
            b = Case90.Text;
            caseNum = read.convertCase(Case90.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);           
            form.ShowDialog();
        }

        private void pic1Button_Click(object sender, EventArgs e)
        {
            string b = Case81.Name;
            bookcase = read.convertCase(b);
            b = Case81.Text;
            caseNum = read.convertCase(Case81.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);           
            form.ShowDialog();
        }

        private void pic2Button_Click(object sender, EventArgs e)
        {
            string b = Case82.Name;
            bookcase = read.convertCase(b);
            b = Case82.Text;
            caseNum = read.convertCase(Case82.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);          
            form.ShowDialog();
        }

        private void pic3Button_Click(object sender, EventArgs e)
        {
            string b = Case83.Name;
            bookcase = read.convertCase(b);
            b = Case83.Text;
            caseNum = read.convertCase(Case83.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);          
            form.ShowDialog();
        }

        private void pic4Button_Click(object sender, EventArgs e)
        {
            string b = Case84.Name;
            bookcase = read.convertCase(b);
            b = Case84.Text;
            caseNum = read.convertCase(Case84.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);           
            form.ShowDialog();
        }

        private void pic5Button_Click(object sender, EventArgs e)
        {
            string b = Case85.Name;
            bookcase = read.convertCase(b);
            b = Case85.Text;
            caseNum = read.convertCase(Case85.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);            
            form.ShowDialog();
        }

        private void pic6Button_Click(object sender, EventArgs e)
        {
            string b = Case86.Name;
            bookcase = read.convertCase(b);
            b = Case86.Text;
            caseNum = read.convertCase(Case86.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);           
            form.ShowDialog();
        }

        private void pic7Button_Click(object sender, EventArgs e)
        {
            string b = Case87.Name;
            bookcase = read.convertCase(b);
            b = Case87.Text;
            caseNum = read.convertCase(Case87.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);          
            form.ShowDialog();
        }

        private void pic8Button_Click(object sender, EventArgs e)
        {
            string b = Case88.Name;
            bookcase = read.convertCase(b);
            b = Case88.Text;
            caseNum = read.convertCase(Case88.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, TWO, caseNum);           
            form.ShowDialog();
        }

        private void pop1Button_Click(object sender, EventArgs e)
        {
            string b = Case107.Name;
            bookcase = read.convertCase(b);
            b = Case107.Text;
            caseNum = read.convertCase(Case107.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);          
            form.ShowDialog();
        }

        private void popular2Button_Click(object sender, EventArgs e)
        {
            string b = Case108.Name;
            bookcase = read.convertCase(b);
            b = Case108.Text;
            caseNum = read.convertCase(Case108.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);           
            form.ShowDialog();
        }

        private void goToThirdFloor_Click(object sender, EventArgs e)
        {
            ThirdFloor form = new ThirdFloor(s);
            form.ShowDialog();
            this.Close();
        }
        private void esl1Button_Click(object sender, EventArgs e)
        {
            string b = Case103.Name;
            bookcase = read.convertCase(b);
            b = Case103.Text;
            caseNum = read.convertCase(Case103.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            form.ShowDialog();
        }

        private void esl2Button_Click(object sender, EventArgs e)
        {
            string b = Case104.Name;
            bookcase = read.convertCase(b);
            b = Case104.Text;
            caseNum = read.convertCase(Case104.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, EIGHT, caseNum);
            form.ShowDialog();
        }
        private void dvd1_Click(object sender, EventArgs e)
        {
            string b = Case101.Name;
            bookcase = read.convertCase(b);
            b = Case101.Text;
            caseNum = read.convertCase(Case101.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, FOURTEEN, caseNum);
            form.ShowDialog();
        }

        private void dvd2_Click(object sender, EventArgs e)
        {
            string b = Case102.Name;
            bookcase = read.convertCase(b);
            b = Case102.Text;
            caseNum = read.convertCase(Case102.Name);
            _14ShelfForm form = new _14ShelfForm(s, bookcase, b, FOURTEEN, caseNum);
            form.ShowDialog();
        }

        private void archivesButton_Click(object sender, EventArgs e)
        {
            Archives form = new Archives(s);
            form.ShowDialog();
        }

        private void Ref1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case71.Text);
        }

        private void case72Button_MouseHover(object sender, EventArgs e)
        {
            createRange(Case72.Text);
        }

        private void Ref3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case73.Text);
        }

        private void Ref4_MouseHover(object sender, EventArgs e)
        {
            createRange(Case74.Text);
        }

        private void Ref5_MouseHover(object sender, EventArgs e)
        {
            createRange(Case75.Text);
        }

        private void Ref6_MouseHover(object sender, EventArgs e)
        {
            createRange(Case76.Text);
        }

        private void Ref7_MouseHover(object sender, EventArgs e)
        {
            createRange(Case77.Text);
        }

        private void Ref8_MouseHover(object sender, EventArgs e)
        {
            createRange(Case78.Text);
        }

        private void Ref9_MouseHover(object sender, EventArgs e)
        {
            createRange(Case79.Text);
        }

        private void Ref10_MouseHover(object sender, EventArgs e)
        {
            createRange(Case80.Text);
        }

        private void Pic1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case81.Text);
        }

        private void Pic2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case82.Text);
        }

        private void Pic3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case83.Text);
        }

        private void Pic4_MouseHover(object sender, EventArgs e)
        {
            createRange(Case84.Text);
        }

        private void Pic5_MouseHover(object sender, EventArgs e)
        {
            createRange(Case85.Text);
        }

        private void Pic6_MouseHover(object sender, EventArgs e)
        {
            createRange(Case86.Text);
        }

        private void Pic7_MouseHover(object sender, EventArgs e)
        {
            createRange(Case87.Text);
        }

        private void Pic8_MouseHover(object sender, EventArgs e)
        {
            createRange(Case88.Text);
        }

        private void New1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case89.Text);
        }

        private void New2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case90.Text);
        }

        private void News1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case91.Text);
        }

        private void News2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case92.Text);
        }

        private void News3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case93.Text);
        }

        private void Mags1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case94.Text);
        }

        private void News1_Click(object sender, EventArgs e)
        {
            string b = Case91.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case91.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case91.Text;
            form.ShowDialog(); 
        }

        private void News2_Click(object sender, EventArgs e)
        {
            string b = Case92.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case92.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case92.Text;
            form.ShowDialog(); 
        }

        private void News3_Click(object sender, EventArgs e)
        {
            string b = Case93.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case93.Name);
            _9ShelfForm form = new _9ShelfForm(s, bookcase, b, SIX, caseNum);
            b = Case93.Text;
            form.ShowDialog();  
        }

        private void Mags2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case95.Text);
        }

        private void Mags3_MouseHover(object sender, EventArgs e)
        {
            createRange(Case96.Text);
        }

        private void Mags4_MouseHover(object sender, EventArgs e)
        {
            createRange(Case97.Text);
        }

        private void Mags5_MouseHover(object sender, EventArgs e)
        {
            createRange(Case98.Text);
        }

        private void Over1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case99.Text);
        }

        private void Over2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case100.Text);
        }

        private void Display1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case101.Text);
        }

        private void Display2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case102.Text);
        }

        private void ESL1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case103.Text);
        }

        private void ESL2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case104.Text);
        }

        private void YA1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case105.Text);
        }

        private void YA2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case106.Text);
        }

        private void Pop1_MouseHover(object sender, EventArgs e)
        {
            createRange(Case107.Text);
        }

        private void Pop2_MouseHover(object sender, EventArgs e)
        {
            createRange(Case108.Text);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            tooltip.Dispose();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clearTooltip()
        {
            tooltip.Dispose();
        }

        private void Case71_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case72_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case73_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case74_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case75_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case76_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case77_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case78_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case79_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case80_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case81_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case82_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case83_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case84_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case85_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case86_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case87_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case88_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case89_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case90_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case91_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case92_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case93_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case94_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case95_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case96_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case97_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case98_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case99_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case100_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case101_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Cse102_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case103_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case104_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case105_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case106_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case107_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case108_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Floor2_Load(object sender, EventArgs e)
        {
            if (read.getCase(Case71.Name) == true)
            {
                Case71.ForeColor = Color.Black;
                Case71.BackColor = Color.Red;
            }
            if (read.getCase(Case72.Name) == true)
            {
                Case72.ForeColor = Color.Black;
                Case72.BackColor = Color.Red;
            }
            if (read.getCase(Case73.Name) == true)
            {
                Case73.ForeColor = Color.Black;
                Case73.BackColor = Color.Red;
            }
            if (read.getCase(Case74.Name) == true)
            {
                Case74.ForeColor = Color.Black;
                Case74.BackColor = Color.Red;
            }
            if (read.getCase(Case75.Name) == true)
            {
                Case75.ForeColor = Color.Black;
                Case75.BackColor = Color.Red;
            }
            if (read.getCase(Case76.Name) == true)
            {
                Case76.ForeColor = Color.Black;
                Case76.BackColor = Color.Red;
            }
            if (read.getCase(Case77.Name) == true)
            {
                Case77.ForeColor = Color.Black;
                Case77.BackColor = Color.Red;
            }
            if (read.getCase(Case78.Name) == true)
            {
                Case78.ForeColor = Color.Black;
                Case78.BackColor = Color.Red;
            }
            if (read.getCase(Case79.Name) == true)
            {
                Case79.ForeColor = Color.Black;
                Case79.BackColor = Color.Red;
            }
            if (read.getCase(Case80.Name) == true)
            {
                Case80.ForeColor = Color.Black;
                Case80.BackColor = Color.Red;
            }
            if (read.getCase(Case81.Name) == true)
            {
                Case81.ForeColor = Color.Black;
                Case81.BackColor = Color.Red;
            }
            if (read.getCase(Case82.Name) == true)
            {
                Case82.ForeColor = Color.Black;
                Case82.BackColor = Color.Red;
            }
            if (read.getCase(Case83.Name) == true)
            {
                Case83.ForeColor = Color.Black;
                Case83.BackColor = Color.Red;
            }
            if (read.getCase(Case84.Name) == true)
            {
                Case84.ForeColor = Color.Black;
                Case84.BackColor = Color.Red;
            }
            if (read.getCase(Case85.Name) == true)
            {
                Case85.ForeColor = Color.Black;
                Case85.BackColor = Color.Red;
            }
            if (read.getCase(Case86.Name) == true)
            {
                Case86.ForeColor = Color.Black;
                Case86.BackColor = Color.Red;
            }
            if (read.getCase(Case87.Name) == true)
            {
                Case87.ForeColor = Color.Black;
                Case87.BackColor = Color.Red;
            }
            if (read.getCase(Case88.Name) == true)
            {
                Case88.ForeColor = Color.Black;
                Case88.BackColor = Color.Red;
            }
            if (read.getCase(Case89.Name) == true)
            {
                Case89.ForeColor = Color.Black;
                Case89.BackColor = Color.Red;
            }
            if (read.getCase(Case90.Name) == true)
            {
                Case90.ForeColor = Color.Black;
                Case90.BackColor = Color.Red;
            }
            if (read.getCase(Case91.Name) == true)
            {
                Case91.ForeColor = Color.Black;
                Case91.BackColor = Color.Red;
            }
            if (read.getCase(Case92.Name) == true)
            {
                Case92.ForeColor = Color.Black;
                Case92.BackColor = Color.Red;
            }
            if (read.getCase(Case93.Name) == true)
            {
                Case93.ForeColor = Color.Black;
                Case93.BackColor = Color.Red;
            }
            if (read.getCase(Case94.Name) == true)
            {
                Case94.ForeColor = Color.Black;
                Case94.BackColor = Color.Red;
            }
            if (read.getCase(Case95.Name) == true)
            {
                Case95.ForeColor = Color.Black;
                Case95.BackColor = Color.Red;
            }
            if (read.getCase(Case96.Name) == true)
            {
                Case96.ForeColor = Color.Black;
                Case96.BackColor = Color.Red;
            }
            if (read.getCase(Case97.Name) == true)
            {
                Case97.ForeColor = Color.Black;
                Case97.BackColor = Color.Red;
            }
            if (read.getCase(Case98.Name) == true)
            {
                Case98.ForeColor = Color.Black;
                Case98.BackColor = Color.Red;
            }
            if (read.getCase(Case99.Name) == true)
            {
                Case99.ForeColor = Color.Black;
                Case99.BackColor = Color.Red;
            }
            if (read.getCase(Case100.Name) == true)
            {
                Case100.ForeColor = Color.Black;
                Case100.BackColor = Color.Red;
            }
            if (read.getCase(Case101.Name) == true)
            {
                Case101.ForeColor = Color.Black;
                Case101.BackColor = Color.Red;
            }
            if (read.getCase(Case102.Name) == true)
            {
                Case102.ForeColor = Color.Black;
                Case102.BackColor = Color.Red;
            }
            if (read.getCase(Case103.Name) == true)
            {
                Case103.ForeColor = Color.Black;
                Case103.BackColor = Color.Red;
            }
            if (read.getCase(Case104.Name) == true)
            {
                Case104.ForeColor = Color.Black;
                Case104.BackColor = Color.Red;
            }
            if (read.getCase(Case105.Name) == true)
            {
                Case105.ForeColor = Color.Black;
                Case105.BackColor = Color.Red;
            }
            if (read.getCase(Case106.Name) == true)
            {
                Case106.ForeColor = Color.Black;
                Case106.BackColor = Color.Red;
            }
            if (read.getCase(Case107.Name) == true)
            {
                Case107.ForeColor = Color.Black;
                Case107.BackColor = Color.Red;
            }
            if (read.getCase(Case108.Name) == true)
            {
                Case108.ForeColor = Color.Black;
                Case108.BackColor = Color.Red;
            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            User form = new User(false);
            read.restart(this);
        }
    }
}
