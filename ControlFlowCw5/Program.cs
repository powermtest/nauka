using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCw5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5- Write a program and ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers and display it on the console. 
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            var userInput = string.Empty;
            Console.WriteLine("Wprowadz pare liczb po przecinku, a sprawdzimy ktora z nich jest najwieksza.");
            userInput = Console.ReadLine();
            var stringTylkoLiczby = new StringBuilder();
            //var numeryczneTylkoLiczby = new int[stringTylkoLiczby.Length];
            //var tablicaZnakow = new char[stringTylkoLiczby.Length];

            //var poprawionyUserInput = userInput.Remove(userInput.IndexOf(", "),2);
            //var check = userInput.IndexOf(", ");

            //zrobic to loopem foreach character in string
            //spawdzic czy jest cyfra
            //jezeli tak, to dodac do nowego stringa
            //co to jest string builder?
            foreach (var cyferka in userInput)
            {
                
                if (cyferka >= '0' && cyferka <= '9')
                {
                    stringTylkoLiczby.Append(cyferka);
                }

            }

            //stringTylkoLiczby.ToString().Max();
            
            //Console.WriteLine("Teraz mamy wszystkie cyferki jako String: {0}.",stringTylkoLiczby);
            //Console.WriteLine("Trzeba je zmienic na cos z czego mozna wyciagnac max.");

            Console.WriteLine("najwieksza wprowadzona liczba to {0}", stringTylkoLiczby.ToString().Max());
            
        }
    }
}
