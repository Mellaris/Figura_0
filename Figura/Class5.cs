using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Piramidka
    {
        private int v;
        private int h;
        private int r;
        private int n;
        private int a;
        private float V;
        private float ex;
        private float S;
        private float P;
        public void Info()
        {
            Console.WriteLine("Введите основание вашей пирамиды: 1 - круг, 2 - n-угольная");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту вашей пирамиды: ");
            h = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите радиус: ");
                r = Convert.ToInt32(Console.ReadLine());
            }
            if (v == 2)
            {
                Console.WriteLine("Введите количество углов: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину стороны: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Proverka()
        {
            if ((n > 2 && h > 0 && a > 0) || (r > 0 && h > 0))
            {
                if (v == 1)
                {
                    vich2();
                    Plo2();
                    perimeter2();
                    Console.WriteLine($"Периметр пирамидки: {P}");
                    Console.WriteLine($"Площадь пирамидки: {S}");
                    Console.WriteLine($"Объем пирамиды равен: {V}");
                }
                else if (v == 2)
                {
                    Vich();
                    Plo();
                    perimeter();
                    Console.WriteLine($"Периметр пирамидки: {P}");
                    Console.WriteLine($"Площадь пирамидки: {S}");
                    Console.WriteLine($"Объем пирамиды равен: {V}");
                }
            }
            else
            {
                Console.WriteLine("Не существует");
            }
        }
        private void Vich()
        {
            V = (float)(n * h * Math.Pow(a, 2)) / (float)(12 * Math.Tan(Math.PI / n));
        }
        private float Ex()
        {
            ex = a / (float)(2 * Math.Tan(Math.PI / n));
            return ex;
        }
        private void Plo()
        {
            S = (float)((a * Ex() * n) / 2) + (float)((a * n * Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ex(), 2))) / 2);
        }
        private float perimeter()
        {
            P = (a * n) + ((float)(Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ex(), 2))) * n);
            return P;
        }
        private float vich2()
        {
            V = (float)(Math.PI * Math.Pow(r, 2) * h) / 3;
            return V;
        }
        private float Plo2()
        {
            S = (float)Math.PI * r * (float)Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + (float)Math.PI * (float)Math.Pow(r, 2);
            return S;
        }
        private float perimeter2()
        {
            P = (float)(Math.PI * 2 * r);
            return P;
        }
    }
}
