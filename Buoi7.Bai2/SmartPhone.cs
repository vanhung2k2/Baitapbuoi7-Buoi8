using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Bai2
{
    public class SmartPhone : Product
    {
        public int donGia = 700000;
        public override int GiaBan()
        {
            return donGia;
        }
    }
}
