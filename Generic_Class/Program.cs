using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Example<G>
    {
        G Box;
        public G Boxs
        {
            set
            {
                this.Box = value;
            }
            get
            {
                return this.Box;
            }
        }

        public Example(G box)
        {
            Box = box;
        }

        public G  GetBox()
        {
            return Box;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example<int> G1 = new Example<int>(20);
            Console.WriteLine(G1.GetBox());

            Example<string> G2 = new Example<string>("Md Fahad");
            Console.WriteLine(G2.GetBox());

            Example<string> c1 = new Example<string>("Hello! This is JO");
            Console.WriteLine(c1.GetBox()); 


            Console.ReadLine();
        }
    }
}
