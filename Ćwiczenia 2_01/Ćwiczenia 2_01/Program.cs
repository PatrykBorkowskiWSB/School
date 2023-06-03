using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia_2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0;
            double value2 = 0;
            double value3 = 0;
            Console.Write("Pierwsza liczba ");value1 = double.Parse(Console.ReadLine());
            Console.Write("Druga liczba "); value2 = double.Parse(Console.ReadLine());
            Console.Write("Trzecia liczba "); value3 = double.Parse(Console.ReadLine());
            Console.Write("Średnia Arytmetyczna "+(value1+value2+value3)/3);

            Console.ReadLine();
        }
    }
}
