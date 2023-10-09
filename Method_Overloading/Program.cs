using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {

        public void Add()
        {
            int a = 20;
            int b = 30;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            //p1.Add();
            p1.Add(20, 30);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
