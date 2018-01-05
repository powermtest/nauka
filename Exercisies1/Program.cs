using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisies1
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking for number between 1 and 10. If not right, information
            Console.WriteLine("podaj liczbe z zakresu od 1 do 10");
            int number;
            string odczyt;
            odczyt = Console.ReadLine();
            number = Convert.ToInt16(odczyt);

            if ( number > 1 && number <=10)
            {
                Console.WriteLine("podano prawilowa liczbe {0}", number );
            }
            else
            {
                Console.WriteLine("liczba {0} jest poza zakresem", odczyt);
            }
        }
    }
}
