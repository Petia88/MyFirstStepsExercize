﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(degrees);

        }
    }
}
