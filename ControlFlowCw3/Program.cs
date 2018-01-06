using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCw3
{
    class Program
    {
        static void Main(string[] args)
        {
            //zapytac o liczbe
            //z wprowadzonej liczby obliczyc silnie
            //wyswietlic silnie z liczby (np. 5! = 120)

            var liczba = 0;
            long silnia = 1;

            Console.WriteLine("Wprowadz mala liczbe, policzymy dla niej silnie");
            liczba = Convert.ToInt32(Console.ReadLine());
            var a = liczba;
            while (a > 0)
            {
                //var b = a;
                silnia = silnia * a ;
                //Console.WriteLine("{0} * {1} = {2}", b, b-1, b*(b-1));
                a--;
                
                continue;

            }

            Console.WriteLine("{0}! = {1}", liczba, silnia);
            
        }
    }
}
