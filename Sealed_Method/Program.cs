using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    internal class Program
    {
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("This is a Class A!!");
            }
        }

        class B : A
        {
            public sealed override void Print()
            {
                Console.WriteLine("This is a Class B!!");
            }
        }

        class C : B
        {
            public override void Print() //Not Override because it is sealed method
            {
                Console.WriteLine("This is a Class C!!");
            }
        }
        static void Main(string[] args)
        {
            C c = new C();
            c.Print();

            Console.ReadLine();
        }
    }
}
