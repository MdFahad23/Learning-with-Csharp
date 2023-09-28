using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine("{0}",dt);
            Console.WriteLine("{0: d}",dt);
            Console.WriteLine("{0: F}",dt);
            Console.WriteLine("{0: yyyy}",dt);
            Console.WriteLine("{0: ddd}",dt);
            Console.WriteLine("{0: dddd}",dt);
            Console.WriteLine("{0:HH:mm:ss tt }",dt);
            Console.WriteLine("{0:dd/MM/yyyy }",dt);
            Console.ReadLine();

        }
    }
}
