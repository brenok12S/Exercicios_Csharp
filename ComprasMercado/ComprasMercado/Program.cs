using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDeTestes; i++)
            {
                List<string> listaDeCompras = new List<string>(Console.ReadLine().Split(' '));
                List<string> listaSemDuplicados = listaDeCompras.Distinct().ToList();

                 listaSemDuplicados.Sort();

                foreach(string item in listaSemDuplicados)
                {
                    Console.Write("" + item + " ");
               }

                Console.WriteLine("");
            }

            Console.ReadKey();

           //

            //Console.ReadKey();

            //int numeroDeCasos = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numeroDeCasos; i++)
            //{
            //    List<string> listaDeCompras = new List<string>(Console.ReadLine().Split(' '));
            //    List<string> listaSemDuplicata = listaDeCompras.Distinct().ToList();

            //    listaSemDuplicata.Sort();

            //    for (string itens in listaSemDuplicata)
            //    {
            //        Console.Write("" + itens + " ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.ReadKey();

        }
    }
}
