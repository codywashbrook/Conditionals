using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine();

            int score;
            string gamertag;

            score = 0;
            gamertag = "BBL Cody";
            if (gamertag == "BBL Cody")
            {
                score = 1000000000; // cheat
            }
            Console.WriteLine("Score: " + score);

            Console.ReadKey(true);
        }
    }
}
