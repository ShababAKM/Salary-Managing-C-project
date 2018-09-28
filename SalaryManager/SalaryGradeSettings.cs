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
    public partial class SalaryGradeSettings : MetroFramework.Controls.MetroUserControl
    {
        public SalaryGradeSettings()
        {
            InitializeComponent();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SalGr sg = new SalGr();
            AddEmp2 ae = new AddEmp2();
            sg.SLG=metroComboBox1.SelectedItem.ToString();
            int s = ae.salgF();
            if (s == 1)
            {
                MetroFramework.MetroMessageBox.Show(this,"Error","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "The values Are Retrived.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroTextBox2.Text = Convert.ToString(sg.HAL);
                metroTextBox1.Text = Convert.ToString(sg.SAL);
                metroTextBox3.Text = Convert.ToString(sg.Heal);
                metroTextBox5.Text = Convert.ToString(sg.Dl);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroRadioButton1.Checked == false)
                {
                    SalGr sg = new SalGr();
                    AddEmp2 ae = new AddEmp2();
                    sg.SLG = metroComboBox1.SelectedItem.ToString();
                    sg.HAL = Convert.ToInt32(metroTextBox2.Text);
                    sg.Heal = Convert.ToInt32(metroTextBox3.Text);
                    //sg.HAL2 = Convert.ToInt32(metroTextBox2.Text);
                    //sg.Heal2 = Convert.ToInt32(metroTextBox3.Text);
                    sg.SAL = Convert.ToInt32(metroTextBox1.Text);
                    sg.Dl = Convert.ToInt32(metroTextBox5.Text);
                    int s = ae.salgE();
                    if (s == 0)
                        MetroFramework.MetroMessageBox.Show(this, "Successfully Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "There Is An Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SalGr sg = new SalGr();
                    AddEmp2 ae = new AddEmp2();
                    sg.SLG = metroComboBox1.SelectedItem.ToString();
                    sg.HAL = Convert.ToInt32(metroTextBox2.Text);
                    sg.Heal = Convert.ToInt32(metroTextBox3.Text);
                    //sg.HAL2 = Convert.ToInt32(metroTextBox2.Text);
                    //sg.Heal2 = Convert.ToInt32(metroTextBox3.Text);
                    sg.SAL = Convert.ToInt32(metroTextBox1.Text);
                    sg.Dl = Convert.ToInt32(metroTextBox5.Text);
                    string bon = metroComboBox2.SelectedItem.ToString();
                    sg.BON = Convert.ToInt32(bon);
                    int s = ae.salgE();
                    if (s == 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Successfully Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroRadioButton1.Checked = false;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "There Is An Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Fill Up All the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
