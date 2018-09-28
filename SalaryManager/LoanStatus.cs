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
    public partial class LoanStatus : MetroFramework.Controls.MetroUserControl
    {
        public LoanStatus()
        {
            InitializeComponent();
        }

        private void LoanStatus_Load(object sender, EventArgs e)
        {
            AddEmp2 ae = new AddEmp2();
            ae.FindL();
            LoanLeaveC llc = new LoanLeaveC();
            metroLabel10.Text = Convert.ToString(llc.TPA);
            metroLabel9.Text = Convert.ToString(llc.PayA);
            metroLabel8.Text = Convert.ToString(llc.LoanA);
            metroLabel7.Text = Convert.ToString(llc.LPA);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
