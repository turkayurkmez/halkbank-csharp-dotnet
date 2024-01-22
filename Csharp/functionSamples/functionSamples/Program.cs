namespace functionSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> list = new List<string>() { "Ankara", "İstanbul", "Eskisehir" };
            bool isExist = isCityExists("İzmir", list);
            int findingIndex = findCityIndex("Eskisehir", list);

            Console.WriteLine(getArea(3, 5, "Dikdörtgen"));
            Console.WriteLine($"Kare: {getAreaOptional(5)} ");
            Console.WriteLine($"Daire: {getAreaOptional(5, shape: "daire")} ");
            Console.WriteLine($"Dikdörtgen: {getAreaOptional(5, 13, shape: "Dikdörtgen")} ");




        }

        static bool isCityExists(string city, List<string> cities)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i] == city)
                {
                    return true;
                }
            }

            return false;
        }

        static int findCityIndex(string city, List<string> cities)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i] == city)
                {
                    return i;
                }
            }

            return -1;
        }

        static bool isCityExistsModern(string city, List<string> cities)
        {
            return cities.Contains(city);
        }


        /*
         *   Daire, kare, üçgen ve dikdörtgen şekillerinin alanlarını hesaplayacak fonksiyonlar yapmak istiyoruz. 
         */


        static double getArea(double unit1, string shape)
        {
            switch (shape)
            {
                case "Kare":
                    return Math.Pow(unit1, 2);
                case "Daire":
                    return Math.PI * Math.Pow(unit1, 2);

                default:
                    return 0;
                    break;
            }
        }

        static double getArea(double unit1, double unit2, string shape)
        {
            switch (shape)
            {
                case "Dikdörtgen":
                    return unit1 * unit2;
                case "Üçgen":
                    return (unit1 * unit2) / 2;

                default:
                    return 0;
                    break;
            }
        }

        static double getAreaOptional(double unit1, double unit2 = 1, string shape = "Kare")
        {
            switch (shape)
            {
                case "Kare":
                    return Math.Pow(unit1, 2);
                case "Daire":
                    return Math.PI * Math.Pow(unit1, 2);
                case "Dikdörtgen":
                    return unit1 * unit2;
                case "Üçgen":
                    return (unit1 * unit2) / 2;

                default:
                    return 0;
                    break;
            }
        }



    }
}