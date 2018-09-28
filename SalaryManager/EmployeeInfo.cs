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
    public partial class EmployeeInfo : MetroFramework.Controls.MetroUserControl
    {
        DataTable ta = new DataTable();
        public EmployeeInfo()
        {
            InitializeComponent();
            ta.Columns.Add("Id1");
            ta.Columns.Add("Id2");
            ta.Columns.Add("Name");
            ta.Columns.Add("Rank");
            ta.Columns.Add("SalaryGrade");
            ta.Columns.Add("EmailAddress");
            ta.Columns.Add("PreviousMonthCheckInMark");
            ta.Columns.Add("RunningMonthCheckInMark");
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      join b in cntx.CheckIns
                      on a.Id2 equals b.Id2
                      select new { Id1 = a.Id1, Id2 = a.Id2, Name = a.Name, Rank = a.Rank, SalaryGrade = a.SalaryGrade, EmailAddress = a.EmailAddress, PreviousMonthCheckInMark = b.PCheckInMark, RunningMonthCheckInMark = b.CheckinMark };
            metroGrid1.DataSource = str;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      join b in cntx.CheckIns
                      on a.Id2 equals b.Id2
                      select new { Id1 = a.Id1, Id2 = a.Id2, Name = a.Name, Rank = a.Rank, SalaryGrade = a.SalaryGrade, EmailAddress = a.EmailAddress, PreviousMonthCheckInMark = b.PCheckInMark, RunningMonthCheckInMark = b.CheckinMark };
            metroGrid1.DataSource = str;
        }
    }
}
