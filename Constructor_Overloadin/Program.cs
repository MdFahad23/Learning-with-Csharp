using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloadin
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Hello This is First Constructor!!");
        }

        public Program(int a, int b)
        {
            Console.WriteLine("Hello This is Second Constructor!! " + (a + b) );
        }
        public Program(int a, int b, int c)
        {
            Console.WriteLine("Hello This is Third Constructor!! " + (a + b + c));
        }
        public Program(string a, string b, string c)
        {
            Console.WriteLine("Hello This is Foure Constructor!! " + (a + b + c));
        }
        static void Main(string[] args)
        {
            Program ci = new Program("a", "b", "c");

            Console.ReadLine();
        }
    }
}
