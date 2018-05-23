using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_cuento_de_la_buena_pipa
{
    class Program
    {
        static void Main(string[] args)
        {
            string answ1 = "", answ2 = "";
            Console.WriteLine("Let's play a game shall we?");
            Console.WriteLine("Please press enter to start");
            Console.ReadLine();
            do
            {
                Console.WriteLine("Queres que te cuente el cuento de la buena pipa?");
                answ1 = Console.ReadLine();
                if (answ1 != "queres que te cuente el cuento de la buena pipa?")
                {
                    Console.WriteLine("Yo no dije " + answ1 + ", yo pregunté si");
                }
            } while (answ1 != "queres que te cuente el cuento de la buena pipa?");
        }
    }
}
