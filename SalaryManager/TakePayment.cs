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
    public partial class TakePayment : UserControl
    {
        //static int i;
        public TakePayment()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TakePayment_Load(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            metroButton3.Enabled = false;
            SignInEmp ae = new SignInEmp();
            metroLabel20.Text = DateTime.Now.ToString("dd : MM : yyyy");
            AddEmp2 ae1 = new AddEmp2();
            FPayment fp = new FPayment();
            LoanLeaveC llc = new LoanLeaveC();
            ae1.TPayment();
            metroLabel2.Text = Convert.ToString(fp.Bas);
            metroLabel4.Text = Convert.ToString(fp.Hoal);
            metroLabel5.Text = Convert.ToString(fp.Heal);
            SignInEmp si = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.CheckIns
                      select a;
            CheckIn p = str.Where(obj => obj.Id2 == si.id2).First();
            {
                if (Convert.ToInt32(p.PCheckInMark) > 65)
                {
                    metroLabel13.Text = Convert.ToString(((fp.BON * fp.Bas) / 100) + 5000);
                }
                else
                {
                    metroLabel13.Text = Convert.ToString((fp.BON * fp.Bas) / 100);
                }
            }

            
            ae1.FindL();

            metroLabel7.Text = Convert.ToString(llc.TPA);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == "")
            { metroTextBox2.Text = "0"; }
            try
            {
                if ((Convert.ToInt32(metroLabel12.Text) + Convert.ToInt32(metroTextBox2.Text)) > 2000)
                    MetroFramework.MetroMessageBox.Show(this, "You Cant Pay More Than 2000 PerMonth", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Checking Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroButton3.Enabled = true;
                    metroButton2.Enabled = false;
                    SaveS ss = new SaveS();
                    ss.SA = (Convert.ToInt32(metroLabel12.Text) + Convert.ToInt32(metroTextBox2.Text));
                }
                metroTextBox2.Enabled = false;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
        Bitmap bmp;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Graphics g = f.CreateGraphics();
            bmp = new Bitmap(f.Size.Width, f.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(f.Location.X, f.Location.Y, 0, 0, f.Size);
            printPreviewDialog1.ShowDialog();

            AddEmp2 ae1 = new AddEmp2();
            SaveS ss = new SaveS();
            if (ss.CO <= 1)
            { ae1.fSA(); }

            Form2 f3 = new Form2();
            Form1 f2 = new Form1(f3);
            f3.change();
        }
        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            SignInEmp ae = new SignInEmp();

                EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                var str = from a in cntx.taxAndSals
                          where a.Id2 == ae.id2
                          select a;
                taxAndSal p = str.First();
                p.Count = 1;
                p.PendingTax = (Convert.ToInt32(metroLabel2.Text)*2)/100;
                cntx.SubmitChanges();
                SaveS ss = new SaveS();
                ss.CO= Convert.ToInt32(p.Count);
                AddEmp2 ae2  = new AddEmp2();
                ae2.FSA();
                if (metroTextBox2.Text == "")
                { metroTextBox2.Text = "0"; }
               SaveS sa = new SaveS();
               int k = Convert.ToInt32(metroLabel7.Text);

               if (k == 0)
               {
                   metroTextBox1.Text = "0";
                   metroTextBox1.Enabled = false;
                   MetroFramework.MetroMessageBox.Show(this, "Checking Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   if (metroTextBox1.Text == "" )
                   {
                       if (Convert.ToInt32(metroLabel7.Text) <= sa.PA)
                       {
                           metroTextBox1.Text = metroLabel7.Text;
                           sa.TL = 0;
                           sa.PA = 0;
                           sa.LA = 0;
                           MetroFramework.MetroMessageBox.Show(this, "Checking Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       else
                       {
                           metroTextBox1.Text = Convert.ToString(sa.PA);
                           sa.LA = sa.LA - sa.PA;
                           MetroFramework.MetroMessageBox.Show(this, "Checking Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                   }
                   else if (Convert.ToInt32(metroTextBox1.Text) > (sa.PA + 100))
                   {
                       MetroFramework.MetroMessageBox.Show(this, "Cant Pay That Much Together", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
               }
               metroButton3.Enabled = false;
               metroButton1.Enabled = true;
               metroLabel18.Text = Convert.ToString(Convert.ToInt32(metroLabel2.Text) + Convert.ToInt32(metroLabel4.Text) + Convert.ToInt32(metroLabel5.Text) - Convert.ToInt32(metroLabel12.Text) - Convert.ToInt32(metroTextBox1.Text) - Convert.ToInt32(metroTextBox2.Text));
        }
    }
}
