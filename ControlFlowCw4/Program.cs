using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCw4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var zmiennaLosowa = new Random().Next(1,10);
            var userInput = String.Empty;
            var iloscProb = 0;
            //zmiennaLosowa.Next(1, 10);
            //Console.WriteLine("wylosowano {0}", zmiennaLosowa); //sprawdzanie co zostalo wylosowane
            Console.WriteLine("Wylosowano numer w przedziale od 1 do 10. \nZganij jaki to numer. Masz 4 szanse.");
            userInput = Console.ReadLine();
            

            while (iloscProb < 4)
            {
                //var wprowadzonaLiczba = Convert.ToByte(userInput);
                if (userInput == zmiennaLosowa.ToString())
                {
                    Console.WriteLine("Gratulacje! Udalo co sie odgadnac liczbe za {0} razem!", iloscProb+1);
                    break;
                }

                iloscProb++;
                //Console.WriteLine("Sprobuj jeszcze raz. --wylosowana liczba to: {0}",zmiennaLosowa);
               
                if (iloscProb == 4)
                {
                    Console.WriteLine("Wylosowana liczba to {0} - nie udalo sie...", zmiennaLosowa);
                    break;
                }
                Console.WriteLine("Zostaly jeszcze {0} proby.\nSprobuj jeszcze raz.",4-iloscProb);
                
                userInput = Console.ReadLine();
                continue;
            }

            
            

        }
    }
}
