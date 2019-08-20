using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Ciclos FOR");
            Console.WriteLine("Coloca un numero");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Coloca un numero");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("de cuanto en cuanto:  ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }

            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }


            }

        }
    }
}
