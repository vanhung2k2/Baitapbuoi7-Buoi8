using Buoi7.Bai3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Bai3.DAL
{
    public interface IStudentDAL
    {
        ReturnData Student_Insert(Student requestData);
        ReturnData Student_Update(Guid id,Student requestData);
        ReturnData Student_Delete(string name);
        ReturnData Student_Sort(string tieuchi);

    }
}
