using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi7
{
    public abstract class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Yob { get; set; }
        public string Adress { get; set; }

        protected NhanVien(int id, string name, string yob, string adress)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Adress = adress;
        }

        public abstract int TinhLuong();
    }
}
