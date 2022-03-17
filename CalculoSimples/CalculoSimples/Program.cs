using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo CI = CultureInfo.InvariantCulture;

            //int cod1, qtde1, cod2, qtde2;
            //double valor1, valor2;

            //string[] input;

            //input = Console.ReadLine().Split(' ');

            //cod1 = int.Parse(input[0]);
            //qtde1 = int.Parse(input[1]);
            //valor1 = double.Parse(input[2], CI);

            //input = Console.ReadLine().Split(' ');

            //cod2 = int.Parse(input[0]);
            //qtde2 = int.Parse(input[1]);
            //valor2 = double.Parse(input[2], CI);

            //double total = (qtde1 * valor1) + (qtde2 * valor2);

            //Console.WriteLine($"VALOR A PAGAR: {total.ToString("F2", CI)}");

            //Console.ReadKey();



            //int r;

            //r = int.Parse(Console.ReadLine());

            //double volume;

            //volume = (4 / 3.0) * 3.14159 * Math.Pow(r, 3);

            //Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            //Console.ReadKey();

            //CultureInfo CI = CultureInfo.InvariantCulture;

            //string[] input = Console.ReadLine().Split(' ');

            //double A, B, C;

            //double triangulo, circulo, trapezio, quadrado, retangulo;


            //A = double.Parse(input[0], CI);
            //B = double.Parse(input[1], CI);
            //C = double.Parse(input[2], CI);

            //triangulo = (A * C) / 2;
            //circulo = Math.Pow(C, 2) * 3.14159;
            //trapezio = ((A + B) * C) / 2.0;
            //quadrado = Math.Pow(B, 2);
            //retangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CI));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CI));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CI));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CI));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CI));

            //Console.ReadKey();

            //string[] vet1 = Console.ReadLine().Split(' ');

            //double A = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            //double B = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            //double C = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            //double areaTriangulo = (A * C) / 2;
            //double areaCirculo = 3.14159 * Math.Pow(C, 2);
            //double areaTrapezio = (A + B) / 2 * C;
            //double areaQuadrado = 4 * B;
            //double areaRetangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            //Console.ReadKey();

            int a, b, c, maiorAB, maior;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");

            Console.ReadLine();


        }
    }
}
