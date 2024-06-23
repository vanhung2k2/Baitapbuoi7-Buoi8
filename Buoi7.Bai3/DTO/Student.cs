using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Bai3.DTO
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double AverageScore { get; set; }
        public string AcademicAbility { get; set; }

        public Student(Guid id, string name, string gender, int age, double mathScore, double physicsScore, double chemistryScore)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            MathScore = mathScore;
            PhysicsScore = physicsScore;
            ChemistryScore = chemistryScore;
        }

        public double TinhDiemTrungBinh()
        {
            AverageScore = (MathScore + PhysicsScore + ChemistryScore) / 3;
            return AverageScore;
        }

        public string TinhHocLuc(Func<double> f)
        {
            if (f() >= 8) AcademicAbility =  "Giỏi";
            else if (f() >= 6.5) AcademicAbility = "Khá";
            else if ((f() >= 5)) AcademicAbility = "Trung Bình";
            else  AcademicAbility = "Yếu";
            return AcademicAbility;
        }
        public void CapNhatDiem(double diemToan, double diemLy, double diemHoa)
        {
            MathScore = diemToan;
            PhysicsScore = diemLy;
            ChemistryScore = diemHoa;
            TinhDiemTrungBinh();
            TinhHocLuc(TinhDiemTrungBinh);
        }

        public override string? ToString()
        {
            return $"Id {Id},Ten {Name},Gioi tinh {Gender},Tuoi {Age},Diem toan {MathScore},Diem Ly {PhysicsScore},Diem hoa {ChemistryScore},Diem trung binh {AverageScore},Hoc Luc {AcademicAbility}";
        }
    }
}
