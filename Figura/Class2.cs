using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Prumoygolnik
    {
        private int a;
        private int b;
        private int p;
        private int s;
        public void Info()
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Per();
            Pl();
        }
        public void Per()
        {
            p = (a + b) * 2;
            Console.WriteLine($"Периметр прямоугольника равен {p}");
        }
        public void Pl()
        {
            s = a * b;
            Console.WriteLine($"Площадь прямоугольника равна {s}");
        }
    }
}
