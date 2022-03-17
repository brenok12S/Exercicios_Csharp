using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());

            if ((B + C > A) && (A + C > B) && A + B > C)
            {
                
                int perimetro = A + B + C;
                Console.WriteLine("AREA = " + perimetro);
            }
            else
            {
                int area = ((A + B) * C) / 2;
                Console.WriteLine("PERIMETRO = " + area);
            }
            Console.ReadKey();
        }
    }
}
