namespace ClassVSObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Product p1 = new Product();
            Product p2 = new Product();

            int p3 = 0;

            p1.Name = "Ülker Çikolatalı Gofret";
            Console.WriteLine(p1.Name);

            Product p4 = p1;
            p4.Name = "Albeni";

            Console.WriteLine(p1.Name);

            using FileStream fileStream = null;
            //using Product product = null;



        }
    }
}