using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomadePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());

            while (D != 0)
            {
                if (D % 2 != 0)
                {
                    D = D + 1;
                }

                int soma = D + D + 2 + D + 4 + D + 6 + D + 8;
                Console.WriteLine(soma);

                D = int.Parse(Console.ReadLine());
            }
        }
    }
}
