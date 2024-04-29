using System;
using System.Collections.Generic;
using System.Text;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            double nylonsum = (nylon + 2) * 1.50;
            double paintLitersSum = (paintLiters + (paintLiters * 0.1)) * 14.50;
            double thinnerSum = thinner * 5;
            double holeSum = nylonsum + paintLitersSum + thinnerSum + 0.4;
            double work = (holeSum * 0.3) * hoursWork;
            double totalSum = holeSum + work;

            Console.WriteLine(totalSum);

        }
    }
}
