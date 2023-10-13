using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Empaloy
    {
        int[] Age = new int[3];

        public int this[int index]
        {
            set {
                if (index >= 0 && index < Age.Length) {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalide Number!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalide Array!!");
                }
            }
            get {
                return Age[index];
            }
        }

        public int this[int index, int i]
        {
            set {
                Age[index] = value + i;
            }
            get {
                return Age[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Empaloy emp = new Empaloy();

            emp[0, 2] = 20;
            Console.WriteLine(emp[0]);

            //emp[0] = 4;
            //Console.WriteLine(emp[0]);

            Console.ReadLine();
        }
    }
}
