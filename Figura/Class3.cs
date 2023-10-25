using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Krug
    {
        private int r;
        private double pi;
        private double p;
        private double s;
        public void Info()
        {
            Console.WriteLine("Введите радиус круга: ");
            Console.Write("r = ");
            r = Convert.ToInt32(Console.ReadLine());
            Perim();
            Plo();
        }
        public void Perim()
        {
            pi = 3.14;
            p = 2 * pi * r;
            Console.WriteLine($"Периметр круга равен {p}");
        }
        public void Plo()
        {
            pi = 3.14;
            s = pi * r * r;
            Console.WriteLine($"Площадь круга равна {s}");
        }
    }
}
