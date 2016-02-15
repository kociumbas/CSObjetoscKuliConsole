using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4ObjetoscKuli
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, obj = 0;
            Console.WriteLine("Program wyswietla objetosc kuli o promieniu r");
            Console.Write("Podaj wartosc promienia r = ");
            r = Convert.ToDouble(Console.ReadLine());
            obj = 4 * Math.PI * Math.Pow(r, 3) /3;
            Console.WriteLine("Objetosc kuli o promieniu {0} wynosi {1:##.##}", r, obj);
            Console.ReadLine();
        }
    }
}
