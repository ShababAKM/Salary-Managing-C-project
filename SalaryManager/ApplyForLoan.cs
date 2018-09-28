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
    public partial class ApplyForLoan : MetroFramework.Controls.MetroUserControl
    {
        public ApplyForLoan()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ApplyForLoan_Load(object sender, EventArgs e)
        {
            metroTile1.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddEmp2 ae = new AddEmp2();
            LoanLeaveC llc = new LoanLeaveC();
            ae.FindL();
            if (metroTextBox2.Text != null && metroRadioButton2.Checked == true && metroRadioButton1.Checked == false)
            {
                try
                {   
                    if (llc.LoanA > 0)
                        MetroFramework.MetroMessageBox.Show(this, "Please Pay Privious amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (llc.LoanA == 0 && Convert.ToInt32(metroTextBox2.Text) > llc.SaveA)
                         MetroFramework.MetroMessageBox.Show(this, "Your current savings Account is " + llc.SaveA + " You cannot borrow more than that.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Convert.ToInt32(metroTextBox2.Text) > 50000)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "You are not Allowed to borrow more than 50000 at once", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "All is Ok From The Checking", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch { MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (metroTextBox2.Text != null && metroRadioButton1.Checked == true && metroRadioButton2.Checked == false)
            {
                if (Convert.ToInt32(metroTextBox2.Text) > 40000)
                    MetroFramework.MetroMessageBox.Show(this, "You are not Allowed to borrow more than 40000 at once", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (llc.LoanA > 0)
                    MetroFramework.MetroMessageBox.Show(this, "Please Pay Privious amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroFramework.MetroMessageBox.Show(this, "All is Ok From The Checking", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if(metroRadioButton1.Checked == true && metroRadioButton2.Checked == true)
                MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
                MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MetroFramework.MetroMessageBox.Show(this, "All is Ok From The Checking", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AddEmp2 ae = new AddEmp2();
            LoanLeaveC llc = new LoanLeaveC();
            ae.FindL();
            if (metroTextBox2.Text != null && metroRadioButton2.Checked == true && metroRadioButton1.Checked == false)
            {
                try
                {
                    if (llc.LoanA > 0)
                        MetroFramework.MetroMessageBox.Show(this, "Please Pay Privious amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (llc.LoanA == 0 && Convert.ToInt32(metroTextBox2.Text) > llc.SaveA)
                        MetroFramework.MetroMessageBox.Show(this, "Your current savings Account is " + llc.SaveA + " You cannot borrow more than that.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Convert.ToInt32(metroTextBox2.Text) > 50000)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "You are not Allowed to borrow more than 50000 at once", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (llc.SaveA < Convert.ToInt32(metroTextBox2.Text))
                        { MetroFramework.MetroMessageBox.Show(this, "Not Enough Savings Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {
                            llc.LoanA = Convert.ToInt32(metroTextBox2.Text);
                            llc.PayA = Convert.ToInt32(metroTextBox3.Text);
                            llc.SaveA = llc.SaveA - Convert.ToInt32(metroTextBox2.Text);
                            llc.TPA = Convert.ToInt32(metroTextBox2.Text);
                            MetroFramework.MetroMessageBox.Show(this, "Loan Taken,please take PrintOut", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ae.AddL();
                            metroTile1.Enabled = true;
                            metroTile2.Enabled = false;

                        }

                    }
                }
                catch { MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (metroTextBox2.Text != null && metroRadioButton1.Checked == true && metroRadioButton2.Checked == false)
            {
                try
                {
                    if (Convert.ToInt32(metroTextBox2.Text) > 40000)
                        MetroFramework.MetroMessageBox.Show(this, "You are not Allowed to borrow more than 40000 at once", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (llc.LoanA > 0)
                        MetroFramework.MetroMessageBox.Show(this, "Please Pay Privious amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        llc.LoanA = Convert.ToInt32(metroTextBox2.Text);
                        llc.PayA = Convert.ToInt32(metroTextBox3.Text);
                        ae.AddLL();
                        

                        MetroFramework.MetroMessageBox.Show(this, "Loan Taken,please take Print Out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";
                        metroTile1.Enabled = true;
                        metroTile2.Enabled = false;
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (metroRadioButton1.Checked == true && metroRadioButton2.Checked == true)
                MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
                MetroFramework.MetroMessageBox.Show(this, "There Is an ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            Graphics g = f1.CreateGraphics();
            bmp = new Bitmap(f1.Size.Width, f1.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(f1.Location.X, f1.Location.Y, 0, 0, f1.Size);
            printPreviewDialog1.ShowDialog();
        }


    }
}
