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
    public partial class EditProfile : MetroFramework.Controls.MetroUserControl
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        /*string filename;

        Image img;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                    AddEmp1 ae1 = new AddEmp1();
                    ae1.Pict = filename;
                    img = pictureBox1.Image;
                }
            }
        }*/
       /* protected byte[] ConvertImageToBinary()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }*/
        SignInEmp ae1 = new SignInEmp();
        private void EditProfile_Load(object sender, EventArgs e)
        {
            metroLabel4.Text = ae1.NName;
            metroLabel5.Text = ae1.id1 + ae1.id2;
            metroLabel6.Text = ae1.RRank;
            //metroLabel9.Text = ae1.DOB;
            metroTextBox1.Text = ae1.PNumber;
            metroTextBox2.Text = ae1.EAddress;
            metroTextBox3.Text = ae1.HAddress;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ae1.Pass=metroTextBox4.Text;
            ae1.PNumber = metroTextBox1.Text;
            ae1.EAddress = metroTextBox2.Text;
            ae1.HAddress = metroTextBox3.Text;
            AddEmp2 aem = new AddEmp2();
            aem.editp();
            metroTextBox4.Text = "";
            MessageBox.Show("Successful","Successful");
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
