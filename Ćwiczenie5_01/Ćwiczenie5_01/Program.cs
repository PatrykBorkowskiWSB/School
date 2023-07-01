using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie5_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 2;
            int countFoundedNumbers = 0;

            Console.Write("Podaj liczbę liczb pierwszych: ");

            int amountNumbers = int.Parse(Console.ReadLine());
            while (countFoundedNumbers < amountNumbers)
            {
                if (CheckIfNumber(val))
                {
                    Console.WriteLine(val);
                    countFoundedNumbers++;
                }
                val++;
            }
            Console.ReadLine();
        }
        static bool CheckIfNumber(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
