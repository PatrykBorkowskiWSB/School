using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie3_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint val = 0;
            Console.WriteLine("Podaj liczbę: ");
            val = uint.Parse(Console.ReadLine());
            Console.WriteLine("Pary liczb których suma jest równa  " + val);

            for (int i = 1; i <= val / 2; i++)
            {
                Console.WriteLine(i + " oraz " + (val - i));
            }

            Console.ReadLine();
        }
    }
}
