namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomatesCorbasi domatesCorbasi = new DomatesCorbasi() { PismeSuresi = 5 };
            Kofte kofte = new Kofte() { PismeSuresi = 10 };
            PatatesSalatasi patatesSalatasi = new PatatesSalatasi() { PismeSuresi = 12 };

            TulumbaTatlisi tulumbaTatlisi = new TulumbaTatlisi() { PismeSuresi = 30 };

            Asci asci = new Asci();
            asci.Pisir(domatesCorbasi);
            asci.Pisir(kofte);
            asci.Pisir(patatesSalatasi);
            asci.Pisir(tulumbaTatlisi);


        }


    }
}