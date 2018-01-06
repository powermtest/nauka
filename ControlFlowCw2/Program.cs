using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter a number or "ok" to exit
            //calculate sum of all previously entered numbers and display it
            var input = 0;
            var suma = 0;
            var sprawdzenie = "";
            Console.WriteLine("Enter a number or type \"OK\" to exit");
            //if (sprawdzenie == "OK")
            //{
            //    Console.WriteLine("Koniec programu.");
            //}

            //if (string.IsNullOrEmpty(sprawdzenie))
            //{
            //    Console.WriteLine("Koniec programu.");
            //}
            sprawdzenie = Console.ReadLine();
            while (sprawdzenie != "OK" && !string.IsNullOrWhiteSpace(sprawdzenie))
            {
                //input = Convert.ToInt32(sprawdzenie);
                if (sprawdzenie == "OK")
                {
                    //suma =+ input;
                    break;
                }
                input = Convert.ToInt32(sprawdzenie);
                suma += input;
                Console.WriteLine("Enter another number or type \"OK\" to exit");
                sprawdzenie = Console.ReadLine();
                continue;
            }

            //input = Convert.ToInt32(sprawdzenie);
            //while (input.ToString() != "OK")
            //{
            //    //Console.WriteLine("Enter another number or type \"OK\" to exit");
                
            //    if (sprawdzenie == "OK")
            //    {
            //        //suma =+ input;
            //        break;
            //    }
            //    input = Convert.ToInt32(sprawdzenie);
            //    suma += input;

            //}
            Console.WriteLine("Suma wprowadzonych liczb to: {0}", suma);
        }
    }
}
