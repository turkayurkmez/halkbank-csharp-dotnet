using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{

    public interface IKiyafet
    {

    }
    public class UstGiyim : IKiyafet { }
    public class Kazak : UstGiyim { }
    public class KirmiziKazak : Kazak
    {

    }
    public abstract class Insan
    {
        public void Giy(IKiyafet ustGiyim)
        {

        }
    }
}
