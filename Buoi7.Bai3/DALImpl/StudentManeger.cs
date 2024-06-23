using Buoi7.Bai3.DAL;
using Buoi7.Bai3.DTO;
using Buoi7.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Bai3.DALImpl
{
    public class StudentManeger : IStudentDAL
    {
       public List<Student> students = new List<Student>();
        public ReturnData Student_Insert(Student requestData)
        {
            var returnData = new ReturnData();
            try
            {
                if (requestData == null || string.IsNullOrEmpty(requestData.Name))

                {
                    returnData.ResponseCode = 1;
                    returnData.ResponseMessenger = "Tên không được trống ! ";

                }

                var checkName = new ValidateData().CheckXSSInput(requestData.Name);
                if (!checkName)
                {
                    returnData.ResponseCode = -2;
                    returnData.ResponseMessenger = "Tên không được chưa ký tự đặc biệt!";
                    return returnData;
                }

                if (students.Count > 0)
                {
                    var studentExist = 0;
                    foreach (var studen in students)
                    {
                        if (studen.Name == requestData.Name)
                        {
                            studentExist = 1;
                            break;
                        }
                    }
                    if (studentExist > 0)
                    {
                        returnData.ResponseCode = -3;
                        returnData.ResponseMessenger = "Tên đã tồn tại trên hệ thống";
                        return returnData;
                    }

                }

                students.Add(requestData);
            }
            catch (Exception ex)
            {

                returnData.ResponseCode = -969;
                returnData.ResponseMessenger = ex.Message;
                return returnData;
            }
            returnData.ResponseCode = 1;
            returnData.ResponseMessenger = "Thêm thành công !" + requestData.Name;

            return returnData;
        }

        public ReturnData Student_Sort(string tieuchi)
        {
            var returnData = new ReturnData();
            switch (tieuchi)
            {
                case "ten":
                    students = students.OrderBy(sv => sv.Name).ToList();
                    returnData.ResponseCode = 0;
                    returnData.ResponseMessenger = "Sort theo tên";
                    break;
                case "hocLuc":
                    students = students.OrderBy(sv => sv.AverageScore).ToList();
                    returnData.ResponseCode = 1;
                    returnData.ResponseMessenger = "Sort theo học lực";
                    break;
                case "diemTrungBinh":
                    students = students.OrderByDescending(sv => sv.AcademicAbility).ToList();
                    returnData.ResponseCode = 2;
                    returnData.ResponseMessenger = "Sort theo điểm trung bình";
                    break;
                default:
                    returnData.ResponseCode = 3;
                    returnData.ResponseMessenger = "Khong dung tieu chi";
                    break;
            }
            return returnData;
        }

        public ReturnData Student_Update(Guid id, Student requestData)
        {
            var returnData = new ReturnData();
            var sv = students.FirstOrDefault(s => s.Id == id);
            if (sv != null)
            {
                sv.Name = requestData.Name;
                sv.Gender = requestData.Gender;
                sv.Age = requestData.Age;
                sv.CapNhatDiem(requestData.MathScore, requestData.PhysicsScore, requestData.ChemistryScore);

                returnData.ResponseCode = 1;
                returnData.ResponseMessenger = "Sửa thành công !";
            }
            return returnData;
        }
        public ReturnData Student_Delete(string name)
        {
            var returnData = new ReturnData();

            var sv = students.FirstOrDefault(s => s.Name == name);
            if (sv != null)
            {
                students.Remove(sv);
                returnData.ResponseCode = 1;
                returnData.ResponseMessenger = "Xoá thành công !";
            }
            return returnData;
        }


    }
}
