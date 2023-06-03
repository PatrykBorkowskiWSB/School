using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ćwiczenia2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            Console.Write("Pierwsza liczba: = ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Druga liczba = ");
            value2 = double.Parse(Console.ReadLine());
            if (value1 > value2)

            {
                Console.Write("Większa jest wartość : " + value1);
            }
            if (value1 < value2)
            {
                Console.Write("Większa jest wartość : " + value2);
            }
            if (value1 == value2)
            {
                Console.Write("Liczby są równe ");
            }
            Console.ReadLine();
        }
    }
}
