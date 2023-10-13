using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int a, int b);
    internal class Program
    {

        public static void Add(int a, int b)
        {
            int reault = a + b;
            Console.WriteLine(reault);
        }

        public static void Sub(int a, int b)
        {
            int reault = a - b;
            Console.WriteLine(reault);
        }

        public static void Mul(int a, int b)
        {
            int reault = a * b;
            Console.WriteLine(reault);
        }

        public static void Div(int a, int b)
        {
            int reault = a / b;
            Console.WriteLine(reault);
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Add);
            obj.Invoke(20, 95);

            Calculation obj1 = new Calculation(Program.Sub);
            obj1.Invoke(90, 24);

            Calculation obj2 = new Calculation(Program.Mul);
            obj2.Invoke(40, 1);

            Calculation obj3 = new Calculation(Program.Div);
            obj3.Invoke(10, 2);

            //obj.Invoke(20, 95);
            //obj = Sub;
            //obj.Invoke(50, 19);
            //obj = Mul;
            //obj.Invoke(10, 9);
            //obj = Div;
            //obj.Invoke(50, 10);

            Console.ReadLine();
        }
    }
}
