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
    public partial class SignIn : MetroFramework.Controls.MetroUserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SignInEmp ae = new SignInEmp();
            AddEmp2 ae1 = new AddEmp2();
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Fillup All The Fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                ae.id1 = Convert.ToChar(metroTextBox3.Text);
                ae.id2 = metroTextBox1.Text;
                ae.Pass = metroTextBox2.Text;
                try
                {
                    ae1.getDB();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter ID & Password Correctly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
            //Form1.Hide();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
