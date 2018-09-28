using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager
{
    class SalGr
    {
        static string slg;
        static int sal, hal, heal,bon,dl;
        public string SLG
        {
            set { slg = value; }
            get { return slg; }
        }
        public int SAL
        {
            set { sal = value; }
            get { return sal; }
        }
        public int HAL
        {
            set { hal = value; }
            get { return hal; }
        }
        public int Heal
        {
            set { heal = value; }
            get { return heal; }
        }
        public int HAL2
        {
            //set { hal = value; }
            get { return ((sal * hal) / 100); }
        }
        public int Heal2
        {
            //set { heal = value; }
            get { return ((heal * sal) / 100); }
        }
        public int BON
        {
            set { bon = value; }
            get { return bon; }
        }
        public int Dl
        {
            set { dl = value; }
            get { return dl; }
        }
    }
}
