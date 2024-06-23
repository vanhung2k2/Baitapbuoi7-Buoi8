using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi7
{
    internal class Part_time_employee : NhanVien
    {
        public int Hours_worked { get; set; }
        public int SalaryhourlyWage { get; set; }


        public Part_time_employee(int id, string name, string yob, string adress,int hour_worked, int salaryhourlywage) : base(id, name, yob, adress)
        {
            Hours_worked = hour_worked;
            SalaryhourlyWage = salaryhourlywage;
        }

        public override int TinhLuong()
        {
            return SalaryhourlyWage*Hours_worked;
        }
    }
}
