using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SalaryManager
{
    
    public partial class AddEmployee : MetroFramework.Controls.MetroUserControl
    {
        //string filename;
        DataTable ta = new DataTable();
        //List<EmpInformation> list;
        public AddEmployee()
        {
            InitializeComponent();
            ta.Columns.Add("Id1");
            ta.Columns.Add("Id2");
            ta.Columns.Add("Name");
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {
            SignInEmp si = new SignInEmp();

            EmpInfoLinqDataContext cntx3 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str3 = from a in cntx3.CheckIns
                       select a;
            CheckIn p3 = str3.Where(obj => obj.Id2 == metroTextBox4.Text).First();
            //EmpInformation em = str.First();
            cntx3.CheckIns.DeleteOnSubmit(p3);
            cntx3.SubmitChanges();

            EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.taxAndSals
                      select a;
            taxAndSal p1 = str1.Where(obj => obj.Id2 == metroTextBox4.Text).First();
            //EmpInformation em = str.First();
            cntx1.taxAndSals.DeleteOnSubmit(p1);
            cntx1.SubmitChanges();

            EmpInfoLinqDataContext cntx2 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str2 = from a in cntx2.Loans_Leaves
                      select a;
            Loans_Leave p2 = str2.Where(obj => obj.Id2 == metroTextBox4.Text).First();
            //EmpInformation em = str.First();
            cntx2.Loans_Leaves.DeleteOnSubmit(p2);
            cntx2.SubmitChanges();

            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      select a;
            EmpInformation p = str.Where(obj => obj.Id2 == metroTextBox4.Text).First();
            //EmpInformation em = str.First();
            cntx.EmpInformations.DeleteOnSubmit(p);
            cntx.SubmitChanges();

            MetroFramework.MetroMessageBox.Show(this, " Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmpInfoLinqDataContext cntx5 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str5 = from a in cntx5.EmpInformations
                      where a.Id1 == si.id1 + 1
                      select new { Id1 = a.Id1, Id2 = a.Id2, Name = a.Name };
            metroGrid1.DataSource = str5;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox4.Text != "" && metroTextBox5.Text != "" && metroTextBox6.Text != "" && metroTextBox7.Text != "" && metroTextBox5.Text == metroTextBox6.Text)
            {
                SignInEmp si = new SignInEmp();
                AddEmp1 ae1 = new AddEmp1();
                ae1.id1 = Convert.ToChar(metroLabel5.Text);
                ae1.id2 = metroTextBox4.Text;
                ae1.NName = metroTextBox7.Text;
                ae1.RRank = metroLabel6.Text;
                ae1.SalGrade = metroLabel9.Text;
                ae1.PNumber = metroTextBox1.Text;
                ae1.HAddress = metroTextBox3.Text;
                ae1.EAddress = metroTextBox2.Text;
                ae1.Pass = metroTextBox5.Text;
                //ae1.DOB = this.metroDateTime1.Text;
                //ae1.Pict = filename;
                AddEmp2 ae2 = new AddEmp2();
                int c = ae2.addToDB();
                if (c == 1)
                { MetroFramework.MetroMessageBox.Show(this, " Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, " Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroTextBox5.Text = "";
                    metroTextBox6.Text = "";
                    metroTextBox7.Text = "";
                    EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                    var str = from a in cntx.EmpInformations
                              where a.Under == si.id1 + si.id2
                              select new { Id1 = a.Id1, Id2 = a.Id2, Name = a.Name };
                    metroGrid1.DataSource = str;
                }
                
            }
            else
                MessageBox.Show("Error Ditected", "Please Fillup all the Boxes");
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
        }

        private void AddEmployee_Load_1(object sender, EventArgs e)
        {
            SignInEmp si = new SignInEmp();
            metroLabel5.Text = Convert.ToString(Convert.ToChar(si.id1+1));
            if (si.id1 == 'A')
            {
                metroLabel6.Text = "Junior Manager";
                metroLabel9.Text = "Grade 1";
            }
            else if (si.id1 == 'B')
            {
                metroLabel6.Text = "Exicutive Officer";
                metroLabel9.Text = "Grade 2";
            }
            if (si.id1 == 'C')
            {
                metroLabel6.Text = "Senior Engineer";
                metroLabel9.Text = "Grade 3";
            }
            if (si.id1 == 'D')
            {
                metroLabel6.Text = "Assitant Senior Engineer";
                metroLabel9.Text = "Grade 4";
            }
            if (si.id1 == 'E')
            {
                metroLabel6.Text = "Assistant Engineer";
                metroLabel9.Text = "Grade 5";
            }
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      where a.Under == si.id1+si.id2
                      select new { Id1 = a.Id1 ,Id2 = a.Id2, Name = a.Name};
            metroGrid1.DataSource = str;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                var str = from a in cntx.EmpInformations
                          where a.Id2 == metroTextBox4.Text
                          select a;
                EmpInformation em = str.First();
                metroTextBox7.Text = em.Name;
                metroTextBox1.Text = em.PhoneNumber;
                metroTextBox2.Text = em.EmailAddress;
                metroTextBox3.Text = em.HomeAddress;
                metroLabel6.Text = em.Rank;
                metroLabel9.Text = em.SalaryGrade;
            }
            catch {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
