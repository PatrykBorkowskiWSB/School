using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double areaCircle = 0;
            Console.Write("Pole koła ");
            areaCircle = double.Parse(Console.ReadLine());
            radius = Math.Sqrt(areaCircle/Math.PI);
            Console.Write("Obwód koła= " + 2*radius*Math.PI);
            Console.ReadLine(); 
        }
    }
}
