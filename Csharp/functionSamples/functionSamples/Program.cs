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


            Console.WriteLine($"Daire: {getAreaOptionalWithEnum(5, shape: ShapeType.Circle)}");
            Console.WriteLine($"Kare: {getAreaOptionalWithConstant(5, shape: ShapeTypes.Square)}");


            Console.WriteLine("enum tipinin değerleri:");
            var enumNames = Enum.GetNames<ShapeType>();
            foreach (var name in enumNames)
            {
                Console.WriteLine(name);
            }




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

        static int findCityIndexModern(string city, List<string> cities)
        {
            return cities.IndexOf(city);
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


        static double getAreaOptionalWithEnum(double unit1, double unit2 = 1, ShapeType shape = ShapeType.Square)
        {
            switch (shape)
            {
                case ShapeType.Triangle:
                    return (unit1 * unit2) / 2;

                case ShapeType.Circle:
                    return Math.Pow(unit1, 2) * Math.PI;
                case ShapeType.Rectangle:
                    return unit1 * unit2;
                case ShapeType.Square:
                    return Math.Pow(unit1, 2);

            }

            return 0;
        }

        static double getAreaOptionalWithConstant(double unit1, double unit2 = 1, string shape = ShapeTypes.Square)
        {
            switch (shape)
            {
                case ShapeTypes.Triangle:
                    return (unit1 * unit2) / 2;

                case ShapeTypes.Circle:
                    return Math.Pow(unit1, 2) * Math.PI;
                case ShapeTypes.Rectangle:
                    return unit1 * unit2;
                case ShapeTypes.Square:
                    return Math.Pow(unit1, 2);

            }

            return 0;

        }




    }

    public enum ShapeType
    {
        Triangle,
        Circle,
        Rectangle,
        Square
    }

    public class ShapeTypes
    {
        public const string Triangle = "Üçgen";
        public const string Circle = "Daire";
        public const string Rectangle = "Dörtgen";
        public const string Square = "Kare";
    }
}