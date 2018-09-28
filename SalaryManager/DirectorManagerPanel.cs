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
    public partial class DirectorManagerPanel : MetroFramework.Controls.MetroUserControl
    {
        SignInEmp ae1 = new SignInEmp();
        public DirectorManagerPanel()
        {
            InitializeComponent();
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

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MControler.Controls.ContainsKey("SalaryGradeSettings"))
            {
                SalaryGradeSettings uc = new SalaryGradeSettings();
                uc.Dock = DockStyle.Fill;
                Form2.Instance.MControler.Controls.Add(uc);
            }
            Form2.Instance.MControler.Controls["SalaryGradeSettings"].BringToFront();
            Form2.Instance.MControler.Visible = true;
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }
        
        private void DirectorManagerPanel_Load(object sender, EventArgs e)
        {
            metroLabel10.Text = ae1.NName;
            metroLabel9.Text = ae1.id1+ae1.id2;
            //metroLabel18.Text = ae1.DOB;
            metroLabel8.Text = ae1.RRank;
            metroLabel7.Text = ae1.PNumber;
            metroLabel6.Text = ae1.EAddress;
            metroLabel11.Text = ae1.HAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ae1.NName = "";
            ae1.id1 = '-';
            ae1.id2 = "";
            ae1.DOB = "";
            ae1.RRank = "";
            ae1.PNumber = "";
            ae1.EAddress = "";
            ae1.HAddress = "";
            ae1.Pass = "";
            Form2 f = new Form2();
            Form1 f2 = new Form1(f);
            
            f.change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metroLabel10.Text = ae1.NName;
            metroLabel9.Text = ae1.id1 + ae1.id2;
            //metroLabel18.Text = ae1.DOB;
            metroLabel8.Text = ae1.RRank;
            metroLabel7.Text = ae1.PNumber;
            metroLabel6.Text = ae1.EAddress;
            metroLabel11.Text = ae1.HAddress;
        }
    }
}
