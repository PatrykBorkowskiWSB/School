﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwoczenia2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double personHeight = 0;
            double personWeight = 0;
            Console.Write("Wzrost (m): ");
            personHeight = double.Parse(Console.ReadLine());
            Console.Write("Waga (kg) ");
            personWeight = double.Parse(Console.ReadLine());
            Console.WriteLine($"BMI wynosi: {personWeight/ (personHeight*personHeight)}");
            Console.ReadLine();

        }
    }
}
