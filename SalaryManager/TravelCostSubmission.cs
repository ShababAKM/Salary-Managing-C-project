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
    public partial class TravelCostSubmission : MetroFramework.Controls.MetroUserControl
    {
        string filename;
        public TravelCostSubmission()
        {
            InitializeComponent();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void metroTile1_Click(object sender, EventArgs e)
        {
            SignInEmp si = new SignInEmp();
            if (si.Pass == metroTextBox2.Text)
            {
                    Form1 f = new Form1();
                    Graphics g = f.CreateGraphics();
                    bmp = new Bitmap(f.Size.Width, f.Size.Height, g);
                    Graphics mg = Graphics.FromImage(bmp);
                    mg.CopyFromScreen(f.Location.X, f.Location.Y, 0, 0, f.Size);
                    printPreviewDialog1.ShowDialog();
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);

                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            metroLabel16.Text = Convert.ToString(Convert.ToInt32(metroTextBox1.Text) * 2);
            SignInEmp si = new SignInEmp();
            EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.SalaryGs
                       select a;
            SalaryG p1 = str1.Where(obj => obj.SalaryGrade == si.SalGrade).First();
            DateTime ds1 = metroDateTime1.Value.Date;
            DateTime ds2 = metroDateTime2.Value.Date;
            TimeSpan ts = ds2 - ds1;
            int i = ts.Days;
            metroLabel13.Text = Convert.ToString(p1.DayAl*i);
        }

        

    }
}
