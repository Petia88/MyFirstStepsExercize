using System;
using System.Collections.Generic;
using System.Text;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine()); 
            int months = int.Parse(Console.ReadLine()); 
            double interest = double.Parse(Console.ReadLine()); 

            double depositPeriod = deposit + months * ((deposit * interest / 100) / 12);

            Console.WriteLine(depositPeriod);


        }
    }
}
