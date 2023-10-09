using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (10 < 20)
            {
                Console.WriteLine("You are Curret!");
            }
            else
            {
                Console.WriteLine("You are not Curret!");
            }

            Console.WriteLine("Entre Your name: ");
            string name = Console.ReadLine();

            switch (name)
            {
                case "Fahad":
                    Console.WriteLine("Corret Name");
                    break;
                default:
                    Console.WriteLine("InCorret Name");
                    break;
            }


            Console.ReadLine();
        }
    }
}
