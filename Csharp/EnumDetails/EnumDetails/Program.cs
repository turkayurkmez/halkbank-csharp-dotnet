namespace EnumDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AkrabalikTipleri tip = AkrabalikTipleri.Abi |
                                   AkrabalikTipleri.Ogul |
                                   AkrabalikTipleri.Baba |
                                   AkrabalikTipleri.Amca |
                                   AkrabalikTipleri.Dayi |
                                   AkrabalikTipleri.Dede;

            Console.WriteLine((int)(tip));
        }
    }

    public enum AkrabalikTipleri
    {
        Abi = 1,
        Ogul = 2,
        Baba = 4,
        Amca = 8,
        Dayi = 16,
        Dede = 32
    }
}