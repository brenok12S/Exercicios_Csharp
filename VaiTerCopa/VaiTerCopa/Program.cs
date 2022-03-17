using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiTerCopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str;

            //while( (str = Console.ReadLine()) != null)
            //{
            //    int x = int.Parse(str);

            //    if (x == 0)
            //    {
            //        Console.WriteLine("Vai ter copa!");
            //    } else
            //    {
            //        Console.WriteLine("Vai ter duas!");
            //    }
            //}

            string y; 

            while ((y = Console.ReadLine()) != null )
            {
                int x = int.Parse(y);

                if (x == 0)
                {
                    Console.WriteLine("Vai ter copa");
                }
                else
                {
                    Console.WriteLine("Vai ter duas copas");
                }

                
            }

            Console.ReadKey();

        }
    }
}
