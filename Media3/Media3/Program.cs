using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] input;
            input = Console.ReadLine().Split(' ');

            double N1 = double.Parse(input[0]);
            double N2 = double.Parse(input[1]);
            double N3 = double.Parse(input[2]);
            double N4 = double.Parse(input[3]);

            double media = (((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10);

            Console.WriteLine("MEDIA: " + media.ToString("F2", CI));

            if(media >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine("-------------------------------------------");
            }
             if (media < 5.0)
            {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("-------------------------------------------");
            }
             if (media >= 5.0 && media <= 6.9 )
            {
                Console.WriteLine("Aluno em Exame");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("NOTA DO EXAME: " + e.ToString("F2", CI));
                media = (e + media) / 2;
                Console.WriteLine("-------------------------------------------");
            }
             if (media >= 5)
            {
                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine("-------------------------------------------");
            }
            if (media < 5.0)
            {
                Console.WriteLine("Aluno Reprovado.");
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("NOTA FINAL: " + media.ToString("F2", CI));
            Console.ReadKey();
        }
    }
}
