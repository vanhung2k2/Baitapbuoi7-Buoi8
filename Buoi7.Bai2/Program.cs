namespace Buoi7.Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sp1 = new Laptop() { Id = 1, Name = "Laptop1", Description = "Mota1" };
            var sp2 = new SmartPhone() { Id = 2, Name = "SmartPhone1", Description = "Mota2" };
            var sp3 = new Book() { Id = 3, Name = "Book1", Description = "Mota3" };

            Console.WriteLine(sp1.GiaBan() + "||" + sp2.GiaBan() + "||" + sp3.GiaBan());






        }
    }
}
