using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ile liczb miedzy 1 a 100 jest podzielnych przez 3
            var counter = 0;
            var i = 0;
            var b = 1;
            //var c = b % 3;
            
            while (i <= 100)
            {
                if (b % 3 == 0)
                {
                    
                    counter++;
                }
                b++;
                i++;
            }

            Console.WriteLine(counter);
            //Console.WriteLine(5 % 2);
        }
    }
}
