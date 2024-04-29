using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double annualFee = double.Parse(Console.ReadLine());
            double sneakers = annualFee * 0.6;
            double teamwear = sneakers * 0.8;
            double ballprice = 1.0 / 4.0 * teamwear;
            double accsesories = 1.0 / 5.0 * ballprice;
            double totalPrice = annualFee + sneakers + teamwear + ballprice + accsesories;


            Console.WriteLine(totalPrice);

        }
    }
}
