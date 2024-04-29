using System;
using System.Collections.Generic;
using System.Text;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensils = int.Parse(Console.ReadLine());
            int fulmasters = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int persentDiscount = int.Parse(Console.ReadLine());

            double totalSum = 0;
            totalSum += pensils * 5.8;
            totalSum += fulmasters * 7.2;
            totalSum += liters * 1.2;

            double discount = totalSum * (persentDiscount / 100.0);
            totalSum -= discount;

            Console.WriteLine(totalSum);

           

        }
    }
}
