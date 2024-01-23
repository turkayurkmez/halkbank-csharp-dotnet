namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Report report = new Report("C:\\myData.xlsx");

            Ekmek ekmek = new Ekmek();

            Console.WriteLine($"Ekmek adedi:{ekmek.Adet} ve türü: {ekmek.Tur}");

            Ekmek ekmek2 = new Ekmek(2);

            Console.WriteLine($"Ekmek adedi:{ekmek2.Adet} ve türü: {ekmek2.Tur}");


            Ekmek ekmek3 = new Ekmek("Kepekli");

            Console.WriteLine($"Ekmek adedi:{ekmek3.Adet} ve türü: {ekmek3.Tur}");


            Ekmek ekmek4 = new Ekmek(2, "Trabzon Ekmeği");

            Console.WriteLine($"Ekmek adedi:{ekmek4.Adet} ve türü: {ekmek4.Tur}");
        }
    }
}