using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("i odwrotnie");
            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var ii = 0; //wariacje na temat powyzszego
            //while (ii <10)
            //{
            //    if (ii % 2 == 0)
            //    {
            //        Console.WriteLine(ii);
            //    }

            //    ii++;
            //}

            while (true)// krotki program pokazujacy po co while
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) //zmieniamy to na przeciwienstwo (!), w celu pokazania jak dziala continue
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; //komenda wroci do poczatku petli
                }
                break;
                //Console.WriteLine("@Echo: " + input); //przenosimy to do wnetrza ifa
            }

            ////---------------------------------- przyklad foreach
            //var name = "John Smith";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            
            ////przy foreach nie trzeba sie martwic o counter
            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int [] { 1,2,3,4};
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


        }


    }
}
