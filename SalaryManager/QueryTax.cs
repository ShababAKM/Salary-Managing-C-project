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
    public partial class QueryTax : UserControl
    {
        public QueryTax()
        {
            InitializeComponent();
        }

        private void QueryTax_Load(object sender, EventArgs e)
        {
            SignInEmp si = new SignInEmp();
            TaxIn ti = new TaxIn();
            AddEmp2 ae = new AddEmp2();
            FPayment fp = new FPayment();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == si.id2
                      select a;
            Loans_Leave tsl = str.First();
            metroLabel2.Text = DateTime.Now.ToString("yyyy");
            metroLabel32.Text = Convert.ToString(tsl.SavingsAccount);
            ae.TPayment();
            EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.taxAndSals
                      where a.Id2 == si.id2
                      select a;
            taxAndSal tt = str1.First();
            metroLabel30.Text = Convert.ToString(tt.PendingTax);
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(metroTextBox1.Text) <= Convert.ToInt32(metroLabel32.Text) && Convert.ToInt32(metroTextBox1.Text) <= Convert.ToInt32(metroLabel32.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "OK", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             e.Graphics.DrawImage(bmp,0,0);
        }
        Bitmap bmp;

        private void metroButton14_Click(object sender, EventArgs e)
        {
            SignInEmp si = new SignInEmp();
            EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.taxAndSals
                       where a.Id2 == si.id2
                       select a;
            taxAndSal tt = str1.First();
            tt.PendingTax = tt.PendingTax - Convert.ToInt32(metroTextBox1.Text);
            cntx1.SubmitChanges();

            Form2 f = new Form2();
            Graphics g = f.CreateGraphics();
            bmp = new Bitmap(f.Size.Width, f.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(f.Location.X, f.Location.Y, 0, 0, f.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }


    }
}
