using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kvadrat  kvadrat = new Kvadrat();
            kvadrat.Info();
            Prumoygolnik prumoygolnik = new Prumoygolnik();
            prumoygolnik.Info();
            Krug krug = new Krug();
            krug.Info();
            Treygolnik treygolnik = new Treygolnik();
            treygolnik.Info();
            Piramidka piramidka = new Piramidka();
            piramidka.Info();
            piramidka.Proverka();
        }
    }
}
