using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi7
{
    public class Full_time_employee : NhanVien
    {
        public Full_time_employee(int id, string name, string yob, string adress) : base(id, name, yob, adress)
        {
        }

        public override int TinhLuong()
        {
            return 6000000;
        }
    }
}
