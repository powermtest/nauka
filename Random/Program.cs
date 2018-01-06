using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var radom = new System.Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 1; i < passwordLength; i++)
            {
                //Console.Write((char)radom.Next(97,122));
                buffer[i] = (char) ('a' + radom.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
