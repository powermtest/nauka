using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //program chce dwoch liczb, wybiera wieksza z nich
            Console.WriteLine("podaj dwie liczby - wybierzemy wieksza");
            Console.WriteLine("wpisz pierwsza liczbe:");
            var liczba1 = Console.ReadLine();
            Console.WriteLine("wpisz druga liczbe");
            var liczba2 = Console.ReadLine();

            if (Convert.ToInt16(liczba1) > Convert.ToInt16(liczba2))
            {
                Console.WriteLine("pierwsza liczba {0} jest wieksza od drugiej {1}", liczba1, liczba2);
            }
            else if (Convert.ToInt16(liczba1) < Convert.ToInt16(liczba2))
            {
                Console.WriteLine("druga liczba {0} jest wieksza od pierwszej {1}", liczba2, liczba1);
            }
            else
            {
                Console.WriteLine("wpisales to samo");
            }
            
        }
    }
}
