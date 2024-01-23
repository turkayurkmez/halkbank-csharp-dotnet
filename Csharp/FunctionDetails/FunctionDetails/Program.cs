namespace FunctionDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bolumdenKalan = 0;
            var bolumSonucu = divide(13, 3, out bolumdenKalan);
            Console.WriteLine(bolumdenKalan);

            Console.WriteLine("Bir sayı girin");
            var userValue = Console.ReadLine();
            int myIntegerValue = 0;
            while (!int.TryParse(userValue, out myIntegerValue))
            {
                Console.WriteLine("Girdiğiniz değer sayıya çevrilemedi.");
                Console.WriteLine("Lütfen bir sayı girin");
                userValue = Console.ReadLine();
            }

            int myReference = 8;
            whatIsReference(ref myReference);

            //Main metodu
            Console.WriteLine($"Main içinde: {myReference}");
            var ortalama = getAverage(16, 5, -4, 13, 2, 125, 33);
            Console.WriteLine(ortalama);



        }

        static int divide(int a, int b, out int modulo)
        {
            modulo = a % b;
            return a / b;
        }

        static void whatIsReference(ref int value)
        {
            value += 5;
            //whatIsReference metodu:
            Console.WriteLine($"what is reference içinde: {value}");
        }

        static int getAverage(params int[] values)
        {
            return (int)values.ToList().Average();
        }


    }
}