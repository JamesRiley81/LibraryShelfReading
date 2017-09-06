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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\Library Programs\ShelfReading\ShelfReading\bin\Debug\ShelfReading.accdb";
        private Bitmap bmp;
        private OleDbConnection connect = new OleDbConnection();
        private OleDbCommand com = new OleDbCommand();
        private string command;
        private List<string> list = new List<string>();
        Reading read = new Reading();
        private void createGrid()
        {
            reportGrid.Rows.Clear();
            command = "SELECT [Section], [Day] FROM Reads";
            connect = new OleDbConnection(connectionString);
            com = new OleDbCommand(command, connect);
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
                    string day = read[1].ToString();
                    DateTime d = Convert.ToDateTime(day);
                    DateTime today = DateTime.Now;
                    today = today.AddDays(-14);
                    if (d.DayOfYear <= today.DayOfYear)
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
        private void Report_Load(object sender, EventArgs e)
        {
            createGrid();
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument2.Print();
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
        private void printDocument2_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            string admin = "Admin";
            try
            {                
                command = "SELECT Email FROM Students WHERE EmploymentStatus=?";
                connect = new OleDbConnection(connectionString);
                com = new OleDbCommand(command, connect);
                com.Parameters.AddWithValue("@EmplomentStatus", admin);
                com.Connection = connect;
                connect.Open();
                OleDbDataReader read = com.ExecuteReader() ;
                while (read.Read())
                {
                    string email = read[0].ToString();
                    list.Add(email);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully set emails.  Please contact admin" + ex);
                connect.Close();
                return;
            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("shelfreadingreport@gmail.com");
                foreach (string address in list)
                {
                    mail.To.Add(address);
                }

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
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not successfully email report. /r/n" + ex);
                connect.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            admin form = new admin();
            read.loadFloor(this, form);
        }  
    }
}
