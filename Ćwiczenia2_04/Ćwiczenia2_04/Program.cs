﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0; 
            int c = 0;
            int d = 0;
            double x = 0;
            double y = 0;
            Console.Write("Podaj liczbę całkowitą A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę całkowitą B: ");    
            b = int.Parse(Console.ReadLine());
            Console.Write("podaj liczbę całkowitą C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("podaj liczbę całkowitą D: ");
            d = int.Parse(Console.ReadLine());
            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania!");
            }
            else
            {
                x = a * d + b * c;
                y = b * d;

                Console.WriteLine("Licznik x: " + x);
                Console.WriteLine("Mianownik y: " + y);
            }
            Console.ReadLine();
        }
    }
}
