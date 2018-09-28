using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Form1 instance;
        Form2 f1;
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }
        public MetroFramework.Controls.MetroPanel MControler
        {
            set
            {
                mPanel = value;
            }
            get
            {
                return mPanel;
            }
        }
        public MetroFramework.Controls.MetroLink MBack
        {
            set
            {
                mlBack = value;
            }
            get
            {
                return mlBack;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
       public Form1(Form2 f1): this()
        {

            this.f1 = f1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlBack.Visible = true;
            instance = this;
            FirstPage uc = new FirstPage();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
        }
        public void change()
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            instance.Hide();
        }
        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["FirstPage"].BringToFront();
            mlBack.Visible = true;
        }
    }
}
