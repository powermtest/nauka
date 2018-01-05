using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //wprowadz szerokosc i wysokosc obrazu, zobaczymy czy jest to landscape
            Console.WriteLine("Wprowadz szerokosc i wysokosc obrazka \nsprawdziwy czy jest w trybie landscape");
            Console.WriteLine("Wprowadz szerokosc obrazka");
            var szerokosc = Console.ReadLine();
            Console.WriteLine("wprowadz wysokosc obrazka");
            var wysokosc = Console.ReadLine();
            int szerInt = Convert.ToInt16(szerokosc);
            int wysInt = Convert.ToInt16(wysokosc);

            if (szerInt > wysInt)
            {
                Console.WriteLine("obrazek jest szerszy ({0}) niz wyzszy ({1}) - tryb landscape", szerokosc, wysokosc);
            }
            else if (wysInt > szerInt)
            {
                Console.WriteLine("obrazek jest wyzszy ({1}) niz szerszy ({0}) - tryb portretowy", szerokosc, wysokosc);
            }
            else
            {
                Console.WriteLine("podano identyczne wymiary szerokosc ({0}) i wysokosc ({1})", szerokosc, wysokosc);
            }
           
            


        }
    }
}
