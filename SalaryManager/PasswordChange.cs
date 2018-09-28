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
    public partial class PasswordChange : MetroFramework.Controls.MetroUserControl
    {
        public PasswordChange()
        {
            InitializeComponent();
        }
        SignInEmp si = new SignInEmp();
        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            if (si.Pass == metroTextBox3.Text && metroTextBox1.Text == metroTextBox2.Text)
            {
                AddEmp2 ae = new AddEmp2();
                string s = metroTextBox1.Text;
                ae.changeP(s);
                si.Pass = metroTextBox1.Text;
                MessageBox.Show("SUCCESSFUL", "SUCCESSFULLY UPDATED");
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
            }
            else
                MessageBox.Show("ERROR","Please Enter the New & Old Passwords Properly");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroTextBox3.Text = si.Pass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Text = metroTextBox1.Text;
        }
    }
}
