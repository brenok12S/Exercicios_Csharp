﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoeaoCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= num; i++)
            {
                int num2 = i * i;
                int num3 = num2 * i;

                Console.WriteLine($"{i} {num2} {num3}");
            }

            Console.ReadKey();
        }
    }
}
