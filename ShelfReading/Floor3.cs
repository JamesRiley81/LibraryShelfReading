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
    public partial class ThirdFloor : Form
    {
        private string s;
        private int bookcase;
        private string b = "";
        private int caseNum;
        ToolTip tooltip = new ToolTip();
        Reading read = new Reading();
        private List<string> list = new List<string>();
        public ThirdFloor(string student)
        {
            InitializeComponent();
            s = student;
            
        }
        private void goToSecondFloor_Click(object sender, EventArgs e)
        {
            Floor2 form = new Floor2(s);
            form.ShowDialog();
            this.Close();
        }

        private void case61Button_Click(object sender, EventArgs e)
        {
            b = Case61.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case61.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case61Button_MouseHover(object sender, EventArgs e)
        {
            createRange(Case1.Name);
        }

        private void case68Button_MouseHover(object sender, EventArgs e)
        {
            createRange(Case2.Name);
        }
        private void createRange(string bookcase)
        {
            tooltip = new ToolTip();
            time.Stop();
            list = read.Bookcase(bookcase);
            string begin = list[0];
            string end = list[1];
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            tooltip.Show(begin + " TO " + end, this, x + 10, y);
            time.Start();
        }    

        private void case55Button_MouseHover(object sender, EventArgs e)
        {
            createRange(Case57.Name);
        }

        private void case56Button_MouseHover(object sender, EventArgs e)
        {
            createRange(Case58.Name);
        }
        private void case16Button_Click(object sender, EventArgs e)
        {
            b = Case16.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case16.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case15Button_Click(object sender, EventArgs e)
        {
            b = Case15.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case15.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case14Button_Click(object sender, EventArgs e)
        {
            b = Case14.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case14.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case13Button_Click(object sender, EventArgs e)
        {
            b = Case13.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case13.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case12Button_Click(object sender, EventArgs e)
        {
            b = Case12.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case12.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case11Button_Click(object sender, EventArgs e)
        {
            b = Case11.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case11.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 25, caseNum);
            form.ShowDialog();
        }

        private void case10Button_Click(object sender, EventArgs e)
        {
            b = Case10.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case10.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void case1Button_Click(object sender, EventArgs e)
        {
            b = Case1.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case1.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case8Button_Click(object sender, EventArgs e)
        {
            b = Case8.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case8.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case7Button_Click(object sender, EventArgs e)
        {
            b = Case7.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case7.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void case6Button_Click(object sender, EventArgs e)
        {
            b = Case6.Name; 
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case6.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void case5Button_Click(object sender, EventArgs e)
        {
            b = Case5.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case5.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case4Button_Click(object sender, EventArgs e)
        {
            b = Case4.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case4.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case3Button_Click(object sender, EventArgs e)
        {
            b = Case3.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case3.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void case2Button_Click(object sender, EventArgs e)
        {
            b = Case2.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case2.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }
        private void case9Button_Click(object sender, EventArgs e)
        {
            b = Case9.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case9.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case22Button_Click_1(object sender, EventArgs e)
        {
            b = Case22.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case22.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case23Button_Click(object sender, EventArgs e)
        {
            b = Case23.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case23.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case24Button_Click(object sender, EventArgs e)
        {
            b = Case24.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case24.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case25Button_Click_1(object sender, EventArgs e)
        {
            b = Case25.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case25.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case26Button_Click_1(object sender, EventArgs e)
        {
            b = Case26.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case26.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case27Button_Click(object sender, EventArgs e)
        {
            b = Case27.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case27.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case28Button_Click(object sender, EventArgs e)
        {
            b = Case28.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case28.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case29Button_Click_1(object sender, EventArgs e)
        {
            b = Case29.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case29.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 33, caseNum);
            form.ShowDialog();
        }

        private void case1Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case1.Name);
        }

        private void case2Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case2.Name);
        }

        private void case3Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case3.Name);
        }

        private void case4Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case4.Name);
        }

        private void case5Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case5.Name);
        }

        private void case6Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case6.Name);
        }

        private void case7Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case7.Name);
        }

        private void case8Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case8.Name);
        }

        private void case9Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case9.Name);
        }

        private void case10Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case10.Name);
        }

        private void case11Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case11.Name);
        }

        private void case12Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case12.Name);
        }

        private void case13Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case13.Name);
        }

        private void case14Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case14.Name);
        }

        private void case15Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case15.Name);
        }

        private void case16Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case16.Name);
        }

        private void case17Button_Click_1(object sender, EventArgs e)
        {
            b = Case17.Name;
            caseNum = read.convertCase(Case17.Name);
            bookcase = read.convertCase(b);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case18Button_Click_1(object sender, EventArgs e)
        {
            b = Case18.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case18.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case19Button_Click(object sender, EventArgs e)
        {
            b = Case19.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case19.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case20Button_Click(object sender, EventArgs e)
        {
            b = Case20.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case20.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case21Button_Click(object sender, EventArgs e)
        {
            b = Case21.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case21.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case17Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case17.Name);
        }

        private void case18Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case18.Name);
        }

        private void case19Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case19.Name);
        }

        private void case20Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case20.Name);
        }

        private void case21Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case21.Name);
        }

        private void case22Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case22.Name);
        }

        private void case23Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case23.Name);
        }

        private void case24Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case24.Name);
        }

        private void case25Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case25.Name);
        }

        private void case26Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case26.Name);
        }

        private void case27Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case27.Name);
        }

        private void case28Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case28.Name);
        }

        private void case29Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case29.Name);
        }

        private void case30Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case30.Name);
        }

        private void case31Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case31.Name);
        }

        private void case32Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case32.Name);
        }

        private void case33Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case33.Name);
        }

        private void case34Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case34.Name);
        }

        private void case30Button_Click_1(object sender, EventArgs e)
        {
            b = Case30.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case30.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 25, caseNum);
            form.ShowDialog();
        }

        private void case31Button_Click_1(object sender, EventArgs e)
        {
            b = Case31.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case31.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 024, caseNum);
            form.ShowDialog();
        }

        private void case32Button_Click_1(object sender, EventArgs e)
        {
            b = Case32.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case32.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void case33Button_Click_1(object sender, EventArgs e)
        {
            b = Case33.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case33.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 21, caseNum);
            form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Case34_Click(object sender, EventArgs e)
        {
            b = Case34.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case34.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 20, caseNum);
            form.ShowDialog();
        }

        private void Case35_Click(object sender, EventArgs e)
        {
            b = Case35.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case35.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 20, caseNum);
            form.ShowDialog();
        }

        private void Case34_MouseHover(object sender, EventArgs e)
        {
            createRange(Case34.Name);
        }

        private void Case36_Click(object sender, EventArgs e)
        {
            b = Case36.Name;
            caseNum = read.convertCase(Case36.Name);
            bookcase = read.convertCase(b);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 20, caseNum);
            form.ShowDialog();
        }

        private void Case35_MouseHover(object sender, EventArgs e)
        {
            createRange(Case35.Name);
        }

        private void Case36_MouseHover(object sender, EventArgs e)
        {
            createRange(Case36.Name);
        }

        private void Case37_Click(object sender, EventArgs e)
        {
            b = Case37.Name;
            bookcase = read.convertCase(b);          
            caseNum = read.convertCase(Case37.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case37_MouseHover(object sender, EventArgs e)
        {
            createRange(Case37.Name);
        }

        private void Case38_Click(object sender, EventArgs e)
        {
            b = Case38.Name;
            bookcase = read.convertCase(b);          
            caseNum = read.convertCase(Case38.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case38_MouseHover(object sender, EventArgs e)
        {
            createRange(Case38.Name);
        }

        private void Case39_Click(object sender, EventArgs e)
        {
            b = Case39.Name;
            bookcase = read.convertCase(b);           
            caseNum = read.convertCase(Case39.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case40_Click(object sender, EventArgs e)
        {
            b = Case40.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case40.Name);          
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case40_MouseHover(object sender, EventArgs e)
        {
            createRange(Case40.Name);
        }

        private void Case39_MouseHover(object sender, EventArgs e)
        {
            createRange(Case31.Name);
        }

        private void Case41_Click(object sender, EventArgs e)
        {
            b = Case41.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case41.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case41_MouseHover(object sender, EventArgs e)
        {
            createRange(Case41.Name);
        }

        private void Case42_Click(object sender, EventArgs e)
        {
            b = Case42.Name;
            bookcase = read.convertCase(b);           
            caseNum = read.convertCase(Case42.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case42_MouseHover(object sender, EventArgs e)
        {
            createRange(Case42.Name);
        }

        private void Case43_Click(object sender, EventArgs e)
        {
            b = Case43.Name;
            bookcase = read.convertCase(b);         
            caseNum = read.convertCase(Case43.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case44_Click(object sender, EventArgs e)
        {
            b = Case44.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case44.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case45_Click(object sender, EventArgs e)
        {
            b = Case45.Text;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case45.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case46_Click(object sender, EventArgs e)
        {
            b = Case46.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case46.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case47_Click(object sender, EventArgs e)
        {
            b = Case47.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case47.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void case48Button_Click(object sender, EventArgs e)
        {
            b = Case48.Name;
            bookcase = read.convertCase(b);           
            caseNum = read.convertCase(Case48.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case49Button_Click(object sender, EventArgs e)
        {
            b = Case49.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case49.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case50_Click(object sender, EventArgs e)
        {
            b = Case50.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case50.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case51_Click(object sender, EventArgs e)
        {
            b = Case51.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case51.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case52_Click(object sender, EventArgs e)
        {
            b = Case52.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case52.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case53Button_Click(object sender, EventArgs e)
        {
            b = Case53.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case53.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void case54Button_Click(object sender, EventArgs e)
        {
            b = Case54.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case54.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case55_Click(object sender, EventArgs e)
        {
            b = Case55.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case55.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case55_MouseHover(object sender, EventArgs e)
        {
            createRange(Case55.Name);
        }

        private void Case54_MouseHover(object sender, EventArgs e)
        {
            createRange(Case54.Name);
        }

        private void Case53_MouseHover(object sender, EventArgs e)
        {
            createRange(Case53.Name);
        }

        private void Case52_MouseHover(object sender, EventArgs e)
        {
            createRange(Case52.Name);
        }

        private void Case51_MouseHover(object sender, EventArgs e)
        {
            createRange(Case51.Name);
        }

        private void Case50_MouseHover(object sender, EventArgs e)
        {
            createRange(Case50.Name);
        }

        private void Case49_MouseHover(object sender, EventArgs e)
        {
            createRange(Case49.Name);
        }

        private void Case48_MouseHover(object sender, EventArgs e)
        {
            createRange(Case48.Name);
        }

        private void Case47_MouseHover(object sender, EventArgs e)
        {
            createRange(Case47.Name);
        }

        private void Case46_MouseHover(object sender, EventArgs e)
        {
            createRange(Case46.Name);
        }

        private void Case45_MouseHover(object sender, EventArgs e)
        {
            createRange(Case45.Name);
        }

        private void Case44_MouseHover(object sender, EventArgs e)
        {
            createRange(Case44.Name);
        }

        private void Case43_MouseHover(object sender, EventArgs e)
        {
            createRange(Case43.Name);
        }

        private void case56Button_MouseHover_1(object sender, EventArgs e)
        {
            createRange(Case56.Name);
        }

        private void Case57_MouseHover(object sender, EventArgs e)
        {
            createRange(Case57.Name);
        }

        private void Case58_MouseHover(object sender, EventArgs e)
        {
            createRange(Case58.Name);
        }

        private void Case59_MouseHover(object sender, EventArgs e)
        {
            createRange(Case59.Name);
        }

        private void Case60_MouseHover(object sender, EventArgs e)
        {
            createRange(Case60.Name);
        }

        private void Case61_MouseHover(object sender, EventArgs e)
        {
            createRange(Case61.Name);
        }

        private void Case62_MouseHover(object sender, EventArgs e)
        {
            createRange(Case62.Name);
        }

        private void Case63_MouseHover(object sender, EventArgs e)
        {
            createRange(Case63.Name);
        }

        private void Case65_MouseHover(object sender, EventArgs e)
        {
            createRange(Case65.Name);
        }

        private void Case66_MouseHover(object sender, EventArgs e)
        {
            createRange(Case66.Name);
        }

        private void Case67_MouseHover(object sender, EventArgs e)
        {
            createRange(Case67.Name);
        }

        private void Case68_MouseHover(object sender, EventArgs e)
        {
            createRange(Case68.Name);
        }

        private void Case69_MouseHover(object sender, EventArgs e)
        {
            createRange(Case69.Name);
        }

        private void Case70_MouseHover(object sender, EventArgs e)
        {
            createRange(Case70.Name);
        }

        private void Case64_MouseHover(object sender, EventArgs e)
        {
            createRange(Case64.Name);
        }

        private void Case56_Click(object sender, EventArgs e)
        {
            b = Case56.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case56.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case57_Click(object sender, EventArgs e)
        {
            b = Case57.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case57.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case58_Click(object sender, EventArgs e)
        {
            b = Case58.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case58.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case59_Click(object sender, EventArgs e)
        {
            b = Case59.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case59.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case60_Click(object sender, EventArgs e)
        {
            b = Case60.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case60.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case61_Click(object sender, EventArgs e)
        {
            b = Case61.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case61.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case62_Click(object sender, EventArgs e)
        {
            b = Case62.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case62.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case63_Click(object sender, EventArgs e)
        {
            b = Case63.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case63.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case64_Click(object sender, EventArgs e)
        {
            b = Case64.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case1.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 28, caseNum);
            form.ShowDialog();
        }

        private void Case65_Click(object sender, EventArgs e)
        {
            b = Case65.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case65.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 25, caseNum);
            form.ShowDialog();
        }

        private void Case66_Click(object sender, EventArgs e)
        {
            b = Case66.Name;
            caseNum = read.convertCase(Case66.Name);
            bookcase = read.convertCase(b);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 282, caseNum);
            form.ShowDialog();
        }

        private void Case67_Click(object sender, EventArgs e)
        {
            b = Case67.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case67.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 30, caseNum);
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tooltip.Dispose();
        }
        private void clearTooltip()
        {
            tooltip.Dispose();
        }

        private void Case1_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case2_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case3_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case4_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case5_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case6_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case7_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case8_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case9_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case10_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case11_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case12_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case13_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case14_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case15_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case16_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case17_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case18_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case19_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case20_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case21_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case22_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case23_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case24_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case25_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case26_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case27_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case28_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case29_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case30_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case30_MouseHover(object sender, EventArgs e)
        {
            createRange(Case30.Name);
        }

        private void Case31_MouseHover(object sender, EventArgs e)
        {
            createRange(Case31.Name);
        }

        private void Case31_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case32_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case33_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case34_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case35_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case36_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case37_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case38_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case39_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case40_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case41_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case42_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case43_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case44_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case45_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case46_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case47_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case48_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case49_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case50_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case51_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case52_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case53_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case54_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case55_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case56_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case57_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case58_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case59_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case60_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case61_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case62_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case63_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case64_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case65_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case66_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case67_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case68_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case69_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case70_MouseLeave(object sender, EventArgs e)
        {
            clearTooltip();
        }

        private void Case69_Click(object sender, EventArgs e)
        {
            b = Case69.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case61.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void Case70_Click(object sender, EventArgs e)
        {
            b = Case70.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case70.Name);
            _30ShelfForm form = new _30ShelfForm(s, bookcase, b, 35, caseNum);
            form.ShowDialog();
        }

        private void Case68_Click(object sender, EventArgs e)
        {
            b = Case68.Name;
            bookcase = read.convertCase(b);
            caseNum = read.convertCase(Case68.Name);
            _20ShelfForm form = new _20ShelfForm(s, bookcase, b, 24, caseNum);
            form.ShowDialog();
        }

        private void ThirdFloor_Load(object sender, EventArgs e)
        {
            if (read.getCase(Case1.Name)==true)
            {
                Case1.ForeColor = Color.Black;
                Case1.BackColor = Color.Red;
            }
            if (read.getCase(Case2.Name) == true)
            {
                Case2.ForeColor = Color.Black;
                Case2.BackColor = Color.Red;
            }
            if (read.getCase(Case3.Name) == true)
            {
                Case3.ForeColor = Color.Black;
                Case3.BackColor = Color.Red;
            }
            if (read.getCase(Case4.Name) == true)
            {
                Case4.ForeColor = Color.Black;
                Case4.BackColor = Color.Red;
            }
            if (read.getCase(Case5.Name) == true)
            {
                Case5.ForeColor = Color.Black;
                Case5.BackColor = Color.Red;
            }
            if (read.getCase(Case6.Name) == true)
            {
                Case6.ForeColor = Color.Black;
                Case6.BackColor = Color.Red;
            }
            if (read.getCase(Case7.Name) == true)
            {
                Case7.ForeColor = Color.Black;
                Case7.BackColor = Color.Red;
            }
            if (read.getCase(Case8.Name) == true)
            {
                Case8.ForeColor = Color.Black;
                Case8.BackColor = Color.Red;
            }
            if (read.getCase(Case9.Name) == true)
            {
                Case9.ForeColor = Color.Black;
                Case9.BackColor = Color.Red;
            }
            if (read.getCase(Case10.Name) == true)
            {
                Case10.ForeColor = Color.Black;
                Case10.BackColor = Color.Red;
            }
            if (read.getCase(Case11.Name) == true)
            {
                Case11.ForeColor = Color.Black;
                Case11.BackColor = Color.Red;
            }
            if (read.getCase(Case12.Name) == true)
            {
                Case12.ForeColor = Color.Black;
                Case12.BackColor = Color.Red;
            }
            if (read.getCase(Case13.Name) == true)
            {
                Case13.ForeColor = Color.Black;
                Case13.BackColor = Color.Red;
            }
            if (read.getCase(Case14.Name) == true)
            {
                Case14.ForeColor = Color.Black;
                Case14.BackColor = Color.Red;
            }
            if (read.getCase(Case15.Name) == true)
            {
                Case15.ForeColor = Color.Black;
                Case15.BackColor = Color.Red;
            }
            if (read.getCase(Case16.Name) == true)
            {
                Case16.ForeColor = Color.Black;
                Case16.BackColor = Color.Red;
            }
            if (read.getCase(Case17.Name) == true)
            {
                Case17.ForeColor = Color.Black;
                Case17.BackColor = Color.Red;
            }
            if (read.getCase(Case18.Name) == true)
            {
                Case18.ForeColor = Color.Black;
                Case18.BackColor = Color.Red;
            }
            if (read.getCase(Case19.Name) == true)
            {
                Case19.ForeColor = Color.Black;
                Case19.BackColor = Color.Red;
            }
            if (read.getCase(Case20.Name) == true)
            {
                Case20.ForeColor = Color.Black;
                Case20.BackColor = Color.Red;
            }
            if (read.getCase(Case21.Name) == true)
            {
                Case21.ForeColor = Color.Black;
                Case21.BackColor = Color.Red;
            }
            if (read.getCase(Case22.Name) == true)
            {
                Case22.ForeColor = Color.Black;
                Case22.BackColor = Color.Red;
            }
            if (read.getCase(Case23.Name) == true)
            {
                Case23.ForeColor = Color.Black;
                Case23.BackColor = Color.Red;
            }
            if (read.getCase(Case24.Name) == true)
            {
                Case24.ForeColor = Color.Black;
                Case24.BackColor = Color.Red;
            }
            if (read.getCase(Case25.Name) == true)
            {
                Case25.ForeColor = Color.Black;
                Case25.BackColor = Color.Red;
            }
            if (read.getCase(Case26.Name) == true)
            {
                Case26.ForeColor = Color.Black;
                Case26.BackColor = Color.Red;
            }
            if (read.getCase(Case27.Name) == true)
            {
                Case27.ForeColor = Color.Black;
                Case27.BackColor = Color.Red;
            }
            if (read.getCase(Case28.Name) == true)
            {
                Case28.ForeColor = Color.Black;
                Case28.BackColor = Color.Red;
            }
            if (read.getCase(Case29.Name) == true)
            {
                Case29.ForeColor = Color.Black;
                Case29.BackColor = Color.Red;
            }
            if (read.getCase(Case30.Name) == true)
            {
                Case30.ForeColor = Color.Black;
                Case30.BackColor = Color.Red;
            }
            if (read.getCase(Case31.Name) == true)
            {
                Case31.ForeColor = Color.Black;
                Case31.BackColor = Color.Red;
            }
            if (read.getCase(Case32.Name) == true)
            {
                Case32.ForeColor = Color.Black;
                Case32.BackColor = Color.Red;
            }
            if (read.getCase(Case33.Name) == true)
            {
                Case33.ForeColor = Color.Black;
                Case33.BackColor = Color.Red;
            }
            if (read.getCase(Case34.Name) == true)
            {
                Case34.ForeColor = Color.Black;
                Case34.BackColor = Color.Red;
            }
            if (read.getCase(Case35.Name) == true)
            {
                Case35.ForeColor = Color.Black;
                Case35.BackColor = Color.Red;
            }
            if (read.getCase(Case36.Name) == true)
            {
                Case36.ForeColor = Color.Black;
                Case36.BackColor = Color.Red;
            }
            if (read.getCase(Case37.Name) == true)
            {
                Case37.ForeColor = Color.Black;
                Case37.BackColor = Color.Red;
            }
            if (read.getCase(Case38.Name) == true)
            {
                Case38.ForeColor = Color.Black;
                Case38.BackColor = Color.Red;
            }
            if (read.getCase(Case39.Name) == true)
            {
                Case39.ForeColor = Color.Black;
                Case39.BackColor = Color.Red;
            }
            if (read.getCase(Case40.Name) == true)
            {
                Case40.ForeColor = Color.Black;
                Case40.BackColor = Color.Red;
            }
            if (read.getCase(Case41.Name) == true)
            {
                Case41.ForeColor = Color.Black;
                Case41.BackColor = Color.Red;
            }
            if (read.getCase(Case42.Name) == true)
            {
                Case42.ForeColor = Color.Black;
                Case42.BackColor = Color.Red;
            }
            if (read.getCase(Case43.Name) == true)
            {
                Case43.ForeColor = Color.Black;
                Case43.BackColor = Color.Red;
            }
            if (read.getCase(Case43.Name) == true)
            {
                Case43.ForeColor = Color.Black;
                Case43.BackColor = Color.Red;
            }
            if (read.getCase(Case44.Name) == true)
            {
                Case44.ForeColor = Color.Black;
                Case44.BackColor = Color.Red;
            }
            if (read.getCase(Case45.Name) == true)
            {
                Case45.ForeColor = Color.Black;
                Case45.BackColor = Color.Red;
            }
            if (read.getCase(Case46.Name) == true)
            {
                Case46.ForeColor = Color.Black;
                Case46.BackColor = Color.Red;
            }
            if (read.getCase(Case47.Name) == true)
            {
                Case47.ForeColor = Color.Black;
                Case47.BackColor = Color.Red;
            }
            if (read.getCase(Case48.Name) == true)
            {
                Case48.ForeColor = Color.Black;
                Case48.BackColor = Color.Red;
            }
            if (read.getCase(Case49.Name) == true)
            {
                Case49.ForeColor = Color.Black;
                Case49.BackColor = Color.Red;
            }
            if (read.getCase(Case50.Name) == true)
            {
                Case50.ForeColor = Color.Black;
                Case50.BackColor = Color.Red;
            }
            if (read.getCase(Case51.Name) == true)
            {
                Case51.ForeColor = Color.Black;
                Case51.BackColor = Color.Red;
            }
            if (read.getCase(Case52.Name) == true)
            {
                Case52.ForeColor = Color.Black;
                Case52.BackColor = Color.Red;
            }
            if (read.getCase(Case53.Name) == true)
            {
                Case53.ForeColor = Color.Black;
                Case53.BackColor = Color.Red;
            }
            if (read.getCase(Case54.Name) == true)
            {
                Case54.ForeColor = Color.Black;
                Case54.BackColor = Color.Red;
            }
            if (read.getCase(Case55.Name) == true)
            {
                Case55.ForeColor = Color.Black;
                Case55.BackColor = Color.Red;
            }
            if (read.getCase(Case56.Name) == true)
            {
                Case56.ForeColor = Color.Black;
                Case56.BackColor = Color.Red;
            }
            if (read.getCase(Case57.Name) == true)
            {
                Case57.ForeColor = Color.Black;
                Case57.BackColor = Color.Red;
            }
            if (read.getCase(Case58.Name) == true)
            {
                Case58.ForeColor = Color.Black;
                Case58.BackColor = Color.Red;
            }
            if (read.getCase(Case59.Name) == true)
            {
                Case59.ForeColor = Color.Black;
                Case59.BackColor = Color.Red;
            }
            if (read.getCase(Case60.Name) == true)
            {
                Case61.ForeColor = Color.Black;
                Case61.BackColor = Color.Red;
            }
            if (read.getCase(Case62.Name) == true)
            {
                Case62.ForeColor = Color.Black;
                Case62.BackColor = Color.Red;
            }
            if (read.getCase(Case63.Name) == true)
            {
                Case63.ForeColor = Color.Black;
                Case63.BackColor = Color.Red;
            }
            if (read.getCase(Case64.Name) == true)
            {
                Case64.ForeColor = Color.Black;
                Case64.BackColor = Color.Red;
            }
            if (read.getCase(Case65.Name) == true)
            {
                Case65.ForeColor = Color.Black;
                Case65.BackColor = Color.Red;
            }
            if (read.getCase(Case66.Name) == true)
            {
                Case66.ForeColor = Color.Black;
                Case66.BackColor = Color.Red;
            }
            if (read.getCase(Case67.Name) == true)
            {
                Case67.ForeColor = Color.Black;
                Case67.BackColor = Color.Red;
            }
            if (read.getCase(Case68.Name) == true)
            {
                Case68.ForeColor = Color.Black;
                Case68.BackColor = Color.Red;
            }
            if (read.getCase(Case69.Name) == true)
            {
                Case69.ForeColor = Color.Black;
                Case69.BackColor = Color.Red;
            }
            if (read.getCase(Case70.Name) == true)
            {
                Case70.ForeColor = Color.Black;
                Case70.BackColor = Color.Red;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            read.restart(this);
            User form = new User(false);
            form.ShowDialog();
            this.Close();
            return;
        }

        private void Case33_MouseHover(object sender, EventArgs e)
        {
            createRange(Case33.Name);
        }

        private void Case32_MouseHover(object sender, EventArgs e)
        {
            createRange(Case32.Name);
        }
    }
}
