namespace Baitapbuoi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pt1 = new Part_time_employee(1, "Long", "4/8/2002", "Hà Nội", 4, 20000);
            var ft1 = new Full_time_employee(1, "Long", "4/8/2002", "Hà Nội");
            var it1 = new Intern_employee(1, "Long", "4/8/2002", "Hà Nội");


            var x = pt1.TinhLuong();
            var y = ft1.TinhLuong();
            var z = it1.TinhLuong();

            Console.WriteLine($"Luong part time : {x}|| Lương full time : {y} || Lương intern : {z}");


        }
    }
}
