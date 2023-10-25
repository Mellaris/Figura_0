using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Kvadrat
    {
        private int a;
        private int perimetr;
        private int plod;
        public void Info()
        {
            Console.WriteLine("Введите сторону квадрта:");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Per();
            Plo();
        }
        public void Per()
        {
            perimetr = a * 4;
            Console.WriteLine($"Периметр квадрта равен {perimetr}");
        }
        public void Plo()
        {
            plod = a * a;
            Console.WriteLine($"Площадь квадрта равна {plod}");
        }
    }
}
