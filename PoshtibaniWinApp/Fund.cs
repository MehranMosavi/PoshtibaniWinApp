using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshtibaniWinApp
{
    class Fund
    {
        public int id { get; set; }
        public long mablagh { get; set; }
        public string vazeiat { get; set; }
        public string date { get; set; }
        public string tozihat { get; set; }
        public string salDoreh { get; set; }
        public string nimehDoreh { get; set; }
        public int fk_EmployeePC { get; set; }
        public byte deleteStatus { get; set; }

        public void sabtDaryafit(long pMablagh,string pVazeiat,string pTozihat, int pfk_EmplyeePC)
        {
            PersianDateTime dateTime = new PersianDateTime(DateTime.Now);
            DB dB = new DB();
            dB.Funds.Add(new Fund
            {
                mablagh = pMablagh,
                vazeiat = pVazeiat,
                date = dateTime.ToString("yyyy/MM/dd"),
                tozihat = pTozihat,
                salDoreh = PoshtibaniWinApp.Properties.Settings.Default.salDoreh,
                nimehDoreh = PoshtibaniWinApp.Properties.Settings.Default.nimehDoreh,
                fk_EmployeePC = pfk_EmplyeePC,
                deleteStatus = 0
            });

            dB.SaveChanges();
        }

        public int pcCode(string empName)
        {
            DB db1 = new DB();
            foreach (var item in db1.Employees)
            {
                if (empName.Trim() == item.name + " " + item.family)
                {
                    return item.personalCode;
                }
            }
            return 1;
        }

        public long Daryaft(int id)
        {
            long sumMablagh = 0;
            DB db1 = new DB();
            foreach (var item in db1.Funds)
            {
                if (item.fk_EmployeePC == id && item.salDoreh == Properties.Settings.Default.salDoreh && item.nimehDoreh == Properties.Settings.Default.nimehDoreh)
                {
                    sumMablagh += item.mablagh;
                }
            }
            return sumMablagh;
        }

        public long Jam()
        {
            string tozi = "توزیع تنخواه به کارشناسان";
            string odat = "عودت تنخواه از کارشناسان";
            long sumMablagh = 0;
            DB db1 = new DB();
            foreach (var item in db1.Funds)
            {
                if (item.vazeiat == tozi && item.salDoreh == Properties.Settings.Default.salDoreh && item.nimehDoreh == Properties.Settings.Default.nimehDoreh)
                {
                    sumMablagh += item.mablagh;
                }
                if (item.vazeiat == odat && item.salDoreh == Properties.Settings.Default.salDoreh && item.nimehDoreh == Properties.Settings.Default.nimehDoreh)
                {
                    sumMablagh += item.mablagh;
                }
            }
            return sumMablagh;
        }
    }
}
