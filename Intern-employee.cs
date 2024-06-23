using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi7
{
    public class Intern_employee : NhanVien
    {
        public Intern_employee(int id, string name, string yob, string adress) : base(id, name, yob, adress)
        {
        }

        public override int TinhLuong()
        {
            return 3000000;
        }
    }
}
