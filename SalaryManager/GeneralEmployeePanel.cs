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
    public partial class GeneralEmployeePanel : MetroFramework.Controls.MetroUserControl
    {
        SignInEmp ae1 = new SignInEmp();
        public GeneralEmployeePanel()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("AddEmployee"))
            {
                AddEmployee uc = new AddEmployee();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["AddEmployee"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("EditProfile"))
            {
                EditProfile uc = new EditProfile();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["EditProfile"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            if (!Form2.Instance.MControler.Controls.ContainsKey("PasswordChange"))
            {
                PasswordChange uc = new PasswordChange();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["PasswordChange"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("ApplyForLoan"))
            {
                ApplyForLoan uc = new ApplyForLoan();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["ApplyForLoan"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("LoanStatus"))
            {
                LoanStatus uc = new LoanStatus();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["LoanStatus"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("TakeLeave"))
            {
                TakeLeave uc = new TakeLeave();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["TakeLeave"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("SellLeave"))
            {
                SellLeave uc = new SellLeave();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["SellLeave"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("QueryTax"))
            {
                QueryTax uc = new QueryTax();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["QueryTax"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

            if (!Form2.Instance.MControler.Controls.ContainsKey("ReportOfficeTravel"))
            {
                ReportOfficeTravel uc = new ReportOfficeTravel();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["ReportOfficeTravel"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }



        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("TakePayment"))
            {
                TakePayment uc = new TakePayment();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["TakePayment"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void GeneralEmployeePanel_Load(object sender, EventArgs e)
        {
            
            if (ae1.id1 == 'F')
                metroTile2.Enabled = false;
            metroLabel10.Text = ae1.NName;
            metroLabel9.Text = ae1.id1 + ae1.id2;
            metroLabel8.Text = ae1.RRank;
            //metroLabel16.Text = ae1.DOB;
            metroLabel13.Text = ae1.Under;
            metroLabel7.Text = ae1.PNumber;
            metroLabel6.Text = ae1.EAddress;
            metroLabel11.Text = ae1.HAddress;
           // pictureBox1.Image = Image.FromFile(ae1.Pict);
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      select a;
            Loans_Leave p = str.Where(obj => obj.Id2 == ae.id2).First();
            if (Convert.ToInt32(DateTime.Now.ToString("yyyy")) > p.Year)
            {
                p.LeaveDays = p.LeaveDays + 100;
                p.Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                cntx.SubmitChanges();
            }
            //SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.taxAndSals
                      select a;
            taxAndSal p1 = str1.Where(obj => obj.Id2 == ae.id2).First();
            if (p1.Count == 1 && Convert.ToInt32(DateTime.Now.ToString("dd")) > 1)
                metroTile5.Enabled = false;
            if (p1.Count == 1 && Convert.ToInt32(DateTime.Now.ToString("dd")) == 1)
            {
                metroTile5.Enabled = true;
                p1.Count = 0;
                cntx.SubmitChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInEmp ae1 = new SignInEmp();
            ae1.NName = "";
            ae1.id1 = '-';
            ae1.id2 = "";
            ae1.DOB = "";
            ae1.RRank = "";
            ae1.PNumber = "";
            ae1.EAddress = "";
            ae1.HAddress = "";
            Form2 f = new Form2();
            Form1 f2 = new Form1(f);

            f.change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInEmp ae1 = new SignInEmp();
            metroLabel10.Text = ae1.NName;
            metroLabel9.Text = ae1.id1 + ae1.id2;
            metroLabel8.Text = ae1.RRank;

            metroLabel13.Text = ae1.Under;
            metroLabel7.Text = ae1.PNumber;
            metroLabel6.Text = ae1.EAddress;
            metroLabel11.Text = ae1.HAddress;
        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("TravelCostSubmission"))
            {
                TravelCostSubmission uc = new TravelCostSubmission();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["TravelCostSubmission"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }
    }
}
