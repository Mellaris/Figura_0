using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Treygolnik
    {
        private int a;
        private int b;
        private int c;
        private int p;
        private double s;
        public void Info()
        {
            Console.WriteLine("Введите стороны треугольник: ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && c + b > a && c + a > b)
            {
                if (a * a == b * b + c * c || c * c == a * a + b * b || b * b == a * a + c * c)
                {
                    Console.WriteLine("Ваш треугольник прямоугольный");
                }
                if ( a == b && c == b && a == c )
                {
                    Console.WriteLine("Ваш треугольник р/с");
                }
                else if ( a == b || c == b || c == a )
                {
                    Console.WriteLine("Ваш треугольник р/б");
                }
                Perim();
                Pload(); 
            }
            else { Console.WriteLine("Такого треугольника не существует"); }
           
        }
        public void Perim()
        {
            p = a + b + c;
            Console.WriteLine($"Периметр вашего треугольника: {p}");
        }
        public void Pload()
        {
            s = p * (p - a) * (p - b) * (p - c);
            s = Math.Sqrt(s);
            Console.WriteLine($"Площадь вашего треугольника: {s}");
        }
    }
}
