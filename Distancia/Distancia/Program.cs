using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            int minutos = km * 2;

            Console.WriteLine(minutos + " minutos");

            Console.ReadKey();


        }
    }
}
