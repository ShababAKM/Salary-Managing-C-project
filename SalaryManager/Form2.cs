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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        static Form2 instance;
        public static int s;
        Form1 f1;
        public int S
        {
            set { s = value; }
        }
        public Form2(Form1 f1): this()
        {

            this.f1 = f1;
        }
        public static Form2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form2();
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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (s == 1){
             mlBack.Visible = true;
             instance = this;
             DirectorManagerPanel uc = new DirectorManagerPanel();
             uc.Dock = DockStyle.Fill;
             mPanel.Controls.Add(uc);
             }
            else {
            mlBack.Visible = true;
            instance = this;
            GeneralEmployeePanel uc = new GeneralEmployeePanel();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
            }
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
           mPanel.Controls[s].BringToFront();
           if (s == 1)
           { mPanel.Controls["DirectorManagerPanel"].BringToFront(); }
           else
           { mPanel.Controls["GeneralEmployeePanel"].BringToFront(); }
            mlBack.Visible = true;
        }
        public void change()
        {
            Form1 f1 = new Form1(this);
            f1.Show();
            instance.Hide();
        }
    }
}
