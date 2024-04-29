using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

           double chickenMenuCount = chickenMenu * 10.35;
            double fishMenuCount = fishMenu * 12.40;
            double veganMenuCount = veganMenu * 8.15;
            double houlMenuPrice = chickenMenuCount + fishMenuCount + veganMenuCount;
            double desertPrice = houlMenuPrice * 0.2;
            double totalCost = houlMenuPrice + desertPrice + 2.50;

            Console.WriteLine(totalCost);

        }
    }
}
