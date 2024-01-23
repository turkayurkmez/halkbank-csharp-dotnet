using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; }
        public void Pisir()
        {
            Console.WriteLine($" {GetType().Name}, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, yanında pilav ile sunuldu");
        }
    }

    public class Corba : Yemek
    {
        public bool TereyagEklensinMi { get; set; }
        public bool LimonVarmi { get; set; }
    }

    public class EtYemegi : Yemek
    {
        public string PismeBicimi { get; set; }

    }

    public class SebzeYemegi : Yemek
    {
        public bool ZeytinYagliMi { get; set; }
    }

    public class Kofte : EtYemegi
    {
        public bool AciSosOlsunMu { get; set; }
    }
    public class DomatesCorbasi : Corba
    {
        public bool KasarliMi { get; set; }
    }

    public class PatatesSalatasi : SebzeYemegi
    {

    }

    public class Tatli : Yemek
    {

    }
    public class TulumbaTatlisi : Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, yanında dondurma ile sunuldu");
        }
    }
}

