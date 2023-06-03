using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            double value3;
            Console.Write("Pierwszy bok: ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Drugi bok: ");
            value2 = double.Parse(Console.ReadLine());
            Console.Write("Trzeci bok: ");
            value3 = double.Parse(Console.ReadLine());
            if (value1 == value2 && value1 == value3)
            {
                Console.Write("Boki utworzą trójkąt równoboczny");
            }
            else
            {
                Console.Write("Boki nie utworzą trójkąta równobocznego");
            }
            Console.ReadLine();
        }
    }
}
