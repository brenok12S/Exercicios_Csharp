using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_de_Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] divisor = new int[8];

            //// Primeiro fazer um array
            //int n, resto, nota, quociente;

            //// Armazenar as notas nesse array
            //divisor[0] = 200;
            //divisor[1] = 100;
            //divisor[2] = 50;
            //divisor[3] = 20;
            //divisor[4] = 10;
            //divisor[5] = 5;
            //divisor[6] = 2;
            //divisor[7] = 1;

            //// Pedir para o usuario o valor
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n);


            //resto = n;


            //foreach (int item in divisor)
            //{
            //    nota = item;

            //    quociente = resto / item;

            //    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            //    resto = resto % item;
            //}

            //Console.ReadKey();

            int[] notas = new int[7];

            int n, nota, quociente;

            notas[0] = 200;
            notas[1] = 100;
            notas[2] = 50;
            notas[3] = 20;
            notas[4] = 10;
            notas[5] = 5;
            notas[6] = 2;

             n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            int resto = n;


            foreach (int item in notas)
            {
               
                nota = item;

                quociente = resto / item;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % item;
            }

            Console.ReadKey();
            



        }
    }
}
