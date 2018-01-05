using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie4SpeedLimit
{
    class Program
    {
         
        static void Main(string[] args)
        {
            //zapytac o limit predkosci
            //zapytac o predkosc auta
            //jezeli predkosc ponizej limitu, wpisac OK
            //jezeli predkosc powyzej limitu -> punkty karne
            //za kazde 5 km/h powyzej limitu 1 punkt karny
            //jezeli suma punktow karnych przekracza 12 poinformaowac o zawieszeniu prawa jazdy
            Console.WriteLine("Podaj limit predkosci i predkosc auta. \nObliczymy ile punktow karnych sie nalezy");
            Console.WriteLine("podaj limit predkosci");
            var speedLimit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Podaj predkosc auta");
            var predkoscAuta = Convert.ToInt16(Console.ReadLine());
            int punktyKarne = 0;


            

            punktyKarne = PunktyKarne(speedLimit, predkoscAuta);
            

            if (punktyKarne > 12)
            {
                Console.WriteLine("Cofnieto prawo jazdy! Przekroczona liczba 12 punktow karnych! \nLacznie naliczono {0} punktow!", punktyKarne);
            }
            else if (predkoscAuta - speedLimit <0 )
            {
                Console.WriteLine("Dozwolona predkosc nie zostala przekroczona");
            }
            else
            {
                Console.WriteLine("Za przekroczenie predkosci otrzymano {0} punktow karnych", punktyKarne);
            }
        }

        private static int PunktyKarne(short speedLimit, short predkoscAuta)
        {
            int punktyKarne;
            int przekrPredkosci = predkoscAuta - speedLimit;
            if (przekrPredkosci > 5)
            {
                punktyKarne = (przekrPredkosci / 5);
            }
            else
            {
                punktyKarne = 0;
            }

            return punktyKarne;
        }
    }
}
