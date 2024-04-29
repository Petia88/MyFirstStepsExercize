using System;
using System.Collections.Generic;
using System.Text;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacity = lenght * width * high;
            double litersCapacity = capacity / 1000;
            double neededLiters = litersCapacity * (1 - (percent/100));


            Console.WriteLine(neededLiters);

        }
    }
}
