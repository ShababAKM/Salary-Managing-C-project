using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager
{
    public class FPayment
    {
        static int basic, hoal, heal,bon;
        public int Bas
        {
            set { basic = value; }
            get { return basic; }
        }
        public int Hoal
        {
            set { hoal = value; }
            get { return hoal; }
        }
        public int Heal
        {
            set { heal = value; }
            get {return heal; }
        }
        public int BON
        {
            set { bon = value; }
            get { return bon; }
        }
    }
}
