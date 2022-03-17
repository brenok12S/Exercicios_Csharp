using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            

            if (y == 0 )
            {
                Console.WriteLine("Divisão Impossivel");
            } else
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                double divisao = x / y;
                Console.WriteLine(divisao.ToString("F2", CI));
            }

            Console.ReadKey();
        }
    }
}
