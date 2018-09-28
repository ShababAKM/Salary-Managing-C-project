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
    public partial class TakeLeave : MetroFramework.Controls.MetroUserControl
    {
        public TakeLeave()
        {
            InitializeComponent();
        }

        private void TakeLeave_Load(object sender, EventArgs e)
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DateTime ds1 = metroDateTime1.Value.Date;
            DateTime ds2 = metroDateTime2.Value.Date;
            TimeSpan ts = ds2-ds1;
            int i = ts.Days;
            if (i <= 0)
                MetroFramework.MetroMessageBox.Show(this, "There Is An Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SignInEmp si = new SignInEmp();
                LoanLeaveC llc = new LoanLeaveC();
                AddEmp2 ae3 = new AddEmp2();
                if (si.Pass == metroTextBox2.Text)
                {
                    llc.LeaveD = llc.LeaveD - i;
                    llc.LF = this.metroDateTime1.Text;
                    llc.LT = this.metroDateTime2.Text;

                    ae3.AddLLe();
                    MetroFramework.MetroMessageBox.Show(this, "you have taken leave of "+i+" days/Day", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroLabel3.Text = Convert.ToString(llc.LeaveD);
                }
            }
        }
    }
}
