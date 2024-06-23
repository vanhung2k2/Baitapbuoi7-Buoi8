using Buoi7.Bai3.DALImpl;
using Buoi7.Bai3.DTO;

namespace Buoi7.Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentmaneger = new StudentManeger();

            Student student = new Student(Guid.NewGuid(), "Hưng", "Nam", 22, 8, 8, 9);
            student.AverageScore = student.TinhDiemTrungBinh();
            student.AcademicAbility = student.TinhHocLuc(student.TinhDiemTrungBinh);

            Student student1 = new Student(Guid.NewGuid(), "Long", "Cường", 24, 5, 5, 4);
            student1.AverageScore = student1.TinhDiemTrungBinh();
            student1.AcademicAbility = student1.TinhHocLuc(student1.TinhDiemTrungBinh);

            Student student2 = new Student(Guid.NewGuid(), "Mạnh", "An", 26, 1, 2, 1);
            student2.AverageScore = student2.TinhDiemTrungBinh();
            student2.AcademicAbility = student2.TinhHocLuc(student2.TinhDiemTrungBinh);

            Console.WriteLine(student);

            var sv = studentmaneger.Student_Insert(student);
            var sv1 = studentmaneger.Student_Insert(student1);
            var sv2 = studentmaneger.Student_Insert(student2);

            if (sv.ResponseCode < 0) Console.WriteLine("Thông báo lỗi {0}", sv.ResponseMessenger);
            else Console.WriteLine("Thông báo: {0}", sv.ResponseMessenger);

            //Sort sinh Viên
            studentmaneger.Student_Sort("ten");
            foreach (var item in studentmaneger.students)
            {
                Console.WriteLine(item);
            }

            //Sửa sinh viên
            var y = studentmaneger.Student_Update(student1.Id, student2);
            if (y.ResponseCode > 0) Console.WriteLine("Sửa thành công");
            else Console.WriteLine("Sửa không thành công");

            Console.WriteLine("Danh sách sau khi sửa là : ");
            
            foreach (var item in studentmaneger.students)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            //Xoá sinh viên theo tên
            var x = studentmaneger.Student_Delete("Mạnh");
            if (x.ResponseCode > 0) Console.WriteLine("Xoá thành công");
            else Console.WriteLine("Xoá không thành công");

            Console.WriteLine("Danh sách sau khi xoá là : ");
            foreach (var item in studentmaneger.students)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
