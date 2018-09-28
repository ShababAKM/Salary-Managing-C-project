using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SalaryManager
{
    public class AddEmp2
    {
        SignInEmp ae = new SignInEmp();

        public int addToDB()
        {
            try
            {
                AddEmp1 ae1 = new AddEmp1();
                EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");

                Loans_Leave lo = new Loans_Leave();
                lo.Id2 = ae1.id2;
                lo.LeaveDays = 100;
                lo.SavingsAccount = 10000;
                lo.LoanAmount = 0;
                lo.PayAmount = 0;
                lo.Year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                taxAndSal trs = new taxAndSal();
                trs.Id2 = ae1.id2;
                trs.PendingTax = 0;
                /*CheckIn ci = new CheckIn();
                ci.Id2 = ae1.id2; ;
                ci.CheckinMark = 0;
                ci.PCheckInMark = 0;
                ci.CheckInCounter = "0";
                ci.Password = ae1.Pass;*/

                EmpInformation emp = new EmpInformation();

                emp.Id1 = ae1.id1;
                emp.Id2 = ae1.id2;
                emp.Name = ae1.NName;
                emp.Password = ae1.Pass;
                emp.PhoneNumber = ae1.PNumber;
                emp.Rank = ae1.RRank;
                emp.SalaryGrade = ae1.SalGrade;
                emp.HomeAddress = ae1.HAddress;
                emp.EmailAddress = ae1.EAddress;
                emp.Under = ae.id1 + ae.id2;
                cntx.EmpInformations.InsertOnSubmit(emp);
                cntx.Loans_Leaves.InsertOnSubmit(lo);
                cntx.taxAndSals.InsertOnSubmit(trs);
                //cntx.CheckIns.InsertOnSubmit(ci);
                cntx.SubmitChanges();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public void getDB()
        {
            
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      select a;
            EmpInformation p = str.Where(obj => obj.Id1 == ae.id1 && obj.Id2 == ae.id2 && obj.Password == ae.Pass).First();

            if (ae.id1 == 'A')
            {
                Form1 f = new Form1();
                Form2 f2 = new Form2(f);
                
                ae.NName = p.Name;
                ae.PNumber = p.PhoneNumber;
                ae.Pass = p.Password;
                //ae.DOB = p.DateofBirth;
                //p.Picture = ae1.Pict;
                ae.SalGrade=p.SalaryGrade;
                ae.HAddress = p.HomeAddress;
                ae.id1=p.Id1;
                ae.id2=p.Id2;
                ae.RRank=p.Rank;
                ae.EAddress = p.EmailAddress;
                f2.S = 1;
                f.change();
            }
            else
            {
                Form1 f = new Form1();
                Form2 f2 = new Form2(f);

                /*EmpInfoLinqDataContext cntx1 = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str1 = from a in cntx1.EmpInformations
                      select a;
            EmpInformation p1 = str1.Where(obj1 => obj1.Id2 == ae.id2).First();*/
                ae.NName = p.Name;
                ae.PNumber = p.PhoneNumber;
                ae.Pass = p.Password;
                //p.Picture = ae1.Pict;
                ae.SalGrade = p.SalaryGrade;
                ae.HAddress = p.HomeAddress;
                ae.id1 = p.Id1;
                ae.id2 = p.Id2;
                ae.RRank = p.Rank;
                ae.EAddress = p.EmailAddress;
                ae.Under = p.Under;
                //ae.Pict = p1.Division;
                f2.S = 2;
                f.change();
            }
            cntx.SubmitChanges();
        }
        public void editp()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      where a.Password == ae.Pass
                      select a;
            EmpInformation p = str.First();
            p.PhoneNumber = ae.PNumber;
            p.EmailAddress = ae.EAddress;
            p.HomeAddress = ae.HAddress;
            cntx.SubmitChanges();
        }
        public void changeP(string pa)
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.EmpInformations
                      where a.Id2 == ae.id2
                      select a;
            EmpInformation p = str.First();
            p.Password = pa;
            //ae.Pass = pa;
            cntx.SubmitChanges();
        }
        public void FindL()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      select a;
            Loans_Leave p = str.Where(obj => obj.Id2 == ae.id2 ).First();
            //Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            llc.LeaveD  = Convert.ToInt32(p.LeaveDays);
            llc.LoanA = Convert.ToInt32(p.LoanAmount);
            llc.PayA = Convert.ToInt32(p.PayAmount);
            llc.SaveA = Convert.ToInt32(p.SavingsAccount);
            llc.TPA = Convert.ToInt32(p.TotalLoan);
            llc.LeSell = Convert.ToInt32(p.SellLeaveAmount);
            llc.LPA = Convert.ToInt32(p.LPay);
            cntx.SubmitChanges();
        }
        public void AddLe()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == ae.id2
                      select a;
            Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            p.LeaveDays = llc.LeaveD;
            p.Year = llc.YYear;
            p.SellLeaveAmount = llc.LeSell;
            cntx.SubmitChanges();

        }
        public void AddLLe()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == ae.id2
                      select a;
            Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            p.LeaveDays = llc.LeaveD;
            p.Year = llc.YYear;
            p.DiscriptionL = llc.Disc;
            p.LeaveF = llc.LF;
            p.LeaveT = llc.LT;
            cntx.SubmitChanges();

        }
        public void FLeave()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      select a;
            Loans_Leave p = str.Where(obj => obj.Id2 == ae.id2).First();
            //Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            llc.YYear = Convert.ToInt32(p.Year);
            llc.LeSell = Convert.ToInt32(p.SellLeaveAmount);
            llc.LeaveD = Convert.ToInt32(p.LeaveDays);
            cntx.SubmitChanges();

        }
        public void AddL()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == ae.id2
                      select a;
            Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            //p.LeaveDays = llc.LeaveD;
            p.LoanAmount = llc.LoanA;
            p.PayAmount = llc.PayA;
            p.SavingsAccount = p.SavingsAccount - llc.LoanA;
            p.TotalLoan = llc.LoanA;
            cntx.SubmitChanges();

        }
        public void AddLL()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == ae.id2
                      select a;
            Loans_Leave p = str.First();
            LoanLeaveC llc = new LoanLeaveC();
            //p.LeaveDays = llc.LeaveD;
            p.LoanAmount = llc.LoanA;
            p.PayAmount = llc.PayA;
            p.SavingsAccount = p.SavingsAccount;
            p.TotalLoan = llc.LoanA;
            cntx.SubmitChanges();

        }
        public int salgF()
        {
            SalGr sg = new SalGr();
            try
            {
                EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                var str = from a in cntx.SalaryGs
                          select a;
                SalaryG p = str.Where(obj => obj.SalaryGrade == sg.SLG).First();
                sg.SAL = Convert.ToInt32(p.Salary);
                sg.Heal = Convert.ToInt32(p.HealthAl);
                sg.HAL = Convert.ToInt32(p.HomeAl);
                sg.Dl = Convert.ToInt32(p.DayAl);
                return 0;
            }
            catch { return 1; }

        }
        public int salgE()
        {
            
            try
            {
                SalGr sg = new SalGr();
                if (sg.SAL == 0 || sg.Heal == 0 || sg.HAL == 0 || sg.Dl == 0)
                    return 1;
                else
                {
                    EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                    var str = from a in cntx.SalaryGs
                              select a;
                    SalaryG p = str.Where(obj => obj.SalaryGrade == sg.SLG).First();
                    p.Salary = sg.SAL;
                    p.HealthAl = sg.Heal;
                    p.HomeAl = sg.HAL;
                    p.HealthAlp = sg.Heal2;
                    p.HomeAlp = sg.HAL2;
                    p.DayAl = sg.Dl;
                    p.Bonus = sg.BON;
                    cntx.SubmitChanges();
                    return 0;
                }
                
            }
            catch { return 1; }

        }
        /*public void tcs()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Travels
                      select a;
            Travel p = str.Where(obj => obj.Id2 == ae.id2).First();
            TravelC tc = new TravelC();
            p.Cause = tc.Cau;
            p.Division = tc.Div;
            p.From = tc.Frm;
            p.To = tc.Too;
            p.TicketPrice = tc.TP;
            p.TravelledBy = tc.TrvB;
            cntx.SubmitChanges();

        }*/
        public void TPayment()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.SalaryGs
                      select a;
            SalaryG p = str.Where(obj => obj.SalaryGrade == ae.SalGrade).First();
            FPayment fp = new FPayment();
            fp.Bas = Convert.ToInt32(p.Salary);
            fp.Hoal = Convert.ToInt32(p.HomeAlp);
            fp.Heal = Convert.ToInt32(p.HealthAlp);
            fp.BON = Convert.ToInt32(p.Bonus);
            //taxC(fp.Bas);
        }
        public void FSA()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
                var str = from a in cntx.Loans_Leaves
                           where a.Id2 == ae.id2
                           select a;
                Loans_Leave p = str.Where(obj => obj.Id2 == ae.id2).First();
            SaveS sa = new SaveS();
           // sa.SA = Convert.ToInt32(p.SavingsAccount);
            sa.TL = Convert.ToInt32(p.TotalLoan);
            sa.PA = Convert.ToInt32(p.PayAmount);
            sa.LA = Convert.ToInt32(p.LoanAmount);
            sa.LP = Convert.ToInt32(p.LPay);
        }
        public void fSA()
        {
            SignInEmp ae = new SignInEmp();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.Loans_Leaves
                      where a.Id2 == ae.id2
                      select a;
            Loans_Leave p = str.Where(obj => obj.Id2 == ae.id2).First();
            SaveS sa = new SaveS();
            p.SavingsAccount += sa.SA;
            p.TotalLoan = sa.TL;
            p.PayAmount = sa.PA;
            p.LoanAmount = sa.LA;
            p.LPay = sa.LP;
            cntx.SubmitChanges();
        }
        /*public void FCheck(int i,int j)
        {
            checkIn ck = new checkIn();
            EmpInfoLinqDataContext cntx = new EmpInfoLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Project Salary Manager\SalaryManager\SalaryManager\EmpployeeInfo.mdf;Integrated Security=True;Connect Timeout=30");
            var str = from a in cntx.CheckIns
                      select a;
            CheckIn p = str.Where(obj => obj.Id2 == ck.na).First();
            if (i == 1 && j != 0)
            {
                int a = Convert.ToInt32(p.CheckinMark);
                p.CheckinMark =  a + 3;
                p.CheckInCounter = "Checked in at +=8 date "+DateTime.Now.ToString("dd");
                cntx.SubmitChanges();
            }
            else if (i == 2 && j != 0)
            {
                int a = Convert.ToInt32(p.CheckinMark);
                p.CheckinMark = a + 2;
                p.CheckInCounter = "Checked in at +=9 date " + DateTime.Now.ToString("dd");
                cntx.SubmitChanges();
            }

            else if (i == 3 && j != 0)
            {
                int a = Convert.ToInt32(p.CheckinMark);
                p.CheckinMark = a + 1;
            p.CheckInCounter = "Checked in at +=10 date " + DateTime.Now.ToString("dd");
            cntx.SubmitChanges();
            }
            else if(j==0)
            {
                if (i == 1 )
                {
                    p.PCheckInMark = p.CheckinMark;
                    p.CheckinMark = 0;
                    cntx.SubmitChanges();
                    int a = Convert.ToInt32(p.CheckinMark);
                    p.CheckinMark = a + 3;
                    p.CheckInCounter = "Checked in at +=8 date " + DateTime.Now.ToString("dd");
                    cntx.SubmitChanges();
                }
                else if (i == 2)
                {
                    p.PCheckInMark = p.CheckinMark;
                    p.CheckinMark = 0;
                    cntx.SubmitChanges();
                    int a = Convert.ToInt32(p.CheckinMark);
                    p.CheckinMark = a + 2;
                    p.CheckInCounter = "Checked in at +=9 date " + DateTime.Now.ToString("dd");
                    cntx.SubmitChanges();
                }

                else if (i == 3)
                {
                    p.PCheckInMark = p.CheckinMark;
                    p.CheckinMark = 0;
                    cntx.SubmitChanges();
                    int a = Convert.ToInt32(p.CheckinMark);
                    p.CheckinMark = a + 1;
                    p.CheckInCounter = "Checked in at +=10 date " + DateTime.Now.ToString("dd");
                    cntx.SubmitChanges();
                }

            }
            
        }*/
    }
    
     
}