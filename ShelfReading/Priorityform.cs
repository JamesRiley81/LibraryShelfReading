using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace ShelfReading
{
    public partial class Priorityform : Form
    {
        public Priorityform()
        {
            InitializeComponent();
        }
        private Bitmap bmp;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\Library Programs\ShelfReading\ShelfReading\bin\Debug\ShelfReading.accdb";
        private void Priorityform_Load(object sender, EventArgs e)
        {
            createGrid();
        }
        private void createGrid()
        {
            reportGrid.Rows.Clear();
            string command = "SELECT StudentID, [Section], [Day] FROM Reads ORDER BY [Day] ASC";
            OleDbConnection connect = new OleDbConnection(connectionString);
            OleDbCommand com = new OleDbCommand(command, connect);
            com.Connection = connect;
            connect.Open();
            OleDbDataReader read = com.ExecuteReader();
            int columnCount = read.FieldCount;
            for (int i = 0; i < columnCount; i++)
            {
                reportGrid.Columns.Add(read.GetName(i).ToString(), read.GetName(i).ToString());
            }
            string[] rows = new string[columnCount];
            if (read.HasRows)
            {
                while (read.Read())
                {
                    string day = read[2].ToString();
                    int today = DateTime.Now.DayOfYear;
                    DateTime d = Convert.ToDateTime(day);
                    if (d.DayOfYear + 14 <= today)
                    {
                        for (int k = 0; k < columnCount; k++)
                        {
                            rows[k] = read.GetString(k);
                        }
                        reportGrid.Rows.Add(rows);
                    }                   
                    else
                        continue;
                }
            }
            else
            {
                MessageBox.Show("No records located.");
            }
            connect.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string student = "*PRIORITY*";
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Was your reading on the second floor?", "Select Floor", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Floor2 form = new Floor2(student);
                form.ShowDialog();
            }
            else
            {
                ThirdFloor form = new ThirdFloor(student);
                form.ShowDialog();
            }
            createGrid();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("shelfreadingreport@gmail.com");
                mail.To.Add("baileyr@lanecc.edu");
                mail.To.Add("JamesRiley81@live.com");
                mail.To.Add("mootzs@lanecc.edu");
                mail.To.Add("kocsisc@lanecc.edu");
                bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("image.tif", ImageFormat.Tiff);
                mail.Subject = "Reports";
                mail.Body = "mail with attachment";
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("image.tif");
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("shelfreadingreport@gmail.com", "Jamesiscool");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email has been sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully email report. /r/n" + ex);
            }
        }
    }
}
