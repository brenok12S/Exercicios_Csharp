using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");

            } else
            {
                Console.WriteLine("Não São Multiplos");
            }

            Console.ReadKey();
        }
    }
}
