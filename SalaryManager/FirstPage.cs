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
    public partial class FirstPage : MetroFramework.Controls.MetroUserControl
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mlTime.Text = DateTime.Now.ToString("HH : mm");
            mlSecond.Text = DateTime.Now.ToString("ss");
            mlDate.Text = DateTime.Now.ToString("dd : MMM : yyyy");
            mlDay.Text = DateTime.Now.ToString("dddd");
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MControler.Controls.ContainsKey("SignIn"))
            {
                SignIn uc = new SignIn();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.MControler.Controls.Add(uc);
            }
            Form1.Instance.MControler.Controls["SignIn"].BringToFront();
            Form1.Instance.MControler.Visible = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MControler.Controls.ContainsKey("EmployeeInfo"))
            {
                EmployeeInfo uc = new EmployeeInfo();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.MControler.Controls.Add(uc);
            }
            Form1.Instance.MControler.Controls["EmployeeInfo"].BringToFront();
            Form1.Instance.MControler.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            AddEmp2 ae = new AddEmp2();
            checkIn ck = new checkIn();
            ck.na = metroTextBox1.Text;
            metroTextBox1.Text = "";
            int i = Convert.ToInt32(DateTime.Now.ToString("HH"));
            int j = Convert.ToInt32(DateTime.Now.ToString("dd"));
            MetroFramework.MetroMessageBox.Show(this, "Checked In", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ( i <= 9)
            {
                if (j != 1)
                {
                    ae.FCheck(1,1);
                }
                else
                    ae.FCheck(1, 0);
            }
            else if (i <= 10)
            {
                if (j != 1)
                {
                    ae.FCheck(2, 1);
                }
                else
                    ae.FCheck(2, 0);
            }
            else
            {
                if (j != 1)
                {
                    ae.FCheck(3, 1);
                }
                else
                    ae.FCheck(3, 0);
            }

        }*/
    }
}
