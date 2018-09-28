using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManager
{
    public partial class SellLeave : MetroFramework.Controls.MetroUserControl
    {
        public SellLeave()
        {
            InitializeComponent();
        }

        private void SellLeave_Load(object sender, EventArgs e)
        {
            AddEmp2 ae = new AddEmp2();
            ae.FLeave();
            LoanLeaveC llc = new LoanLeaveC();
            
            if (llc.YYear > Convert.ToInt32(DateTime.Now.ToString("yyyy")))
            {
                llc.YYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                llc.LeaveD = llc.LeaveD + 100;  
                //AddEmp2 ae1 = new AddEmp2();
                ae.AddLe();
                metroLabel3.Text = Convert.ToString(llc.LeaveD);
            }
            else
            {
                metroLabel3.Text = Convert.ToString(llc.LeaveD);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LoanLeaveC llc = new LoanLeaveC();
                AddEmp2 ae3 = new AddEmp2();
                ae3.FLeave();
                if (llc.LeaveD <= 30)
                    MessageBox.Show("Not Enough Leave Days");
                else if ((llc.LeaveD - Convert.ToInt32(metroTextBox2.Text)) <= 30)
                    MessageBox.Show("Not Enough Leave Days");
                else
                {
                    metroLabel6.Text = Convert.ToString(llc.LeaveD - Convert.ToInt32(metroTextBox2.Text));
                    metroLabel8.Text = Convert.ToString(Convert.ToInt32(metroTextBox2.Text) * 250);

                }
            }
            catch
            { MessageBox.Show("Error", "Error"); }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            SignInEmp si = new SignInEmp();
            LoanLeaveC llc = new LoanLeaveC();
            AddEmp2 ae3 = new AddEmp2();
            if (si.Pass == metroTextBox1.Text)
            {
                llc.LeaveD = llc.LeaveD - Convert.ToInt32(metroTextBox2.Text);


                llc.LeSell = Convert.ToInt32(metroTextBox2.Text) * 250;
                metroLabel8.Text = Convert.ToString(Convert.ToInt32(metroTextBox2.Text) * 250);
                ae3.AddLe();
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmp2 ae = new AddEmp2();
                ae.FLeave();
                LoanLeaveC llc = new LoanLeaveC();
                metroLabel3.Text = Convert.ToString(llc.LeaveD);
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroLabel6.Text = "-----";
                metroLabel6.Text = "-----";
            }
            catch
            { MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Graphics g = f.CreateGraphics();
            bmp = new Bitmap(f.Size.Width, f.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(f.Location.X, f.Location.Y, 0, 0, f.Size);
            printPreviewDialog1.ShowDialog();

            Form2 f3 = new Form2();
            Form1 f2 = new Form1(f3);
            f3.change();
        }

    }
}
