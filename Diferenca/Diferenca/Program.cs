using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Forma 1 (Um em baixo do outro)

            //int A, B, C, D;
            //int calculo;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //calculo = (A * B) - (C * D);

            //Console.WriteLine();
            //Console.Write("DIFERENCA = " + calculo);
            //Console.ReadKey();

            // Forma 2 (Um do lado do outro)

            string[] input;

            input = Console.ReadLine().Split(' ');

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int D = int.Parse(input[3]);

            int calculo = (A * B) - (C * D);

            Console.WriteLine();
            Console.Write("DIFERENCA: " + calculo);
            Console.ReadKey();
        }
    }
}
