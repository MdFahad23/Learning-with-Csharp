using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverRiding
{
    sealed class parent
    {
        public void show1()
        {
            Console.WriteLine("This is sealed Class!! not inheritence");
        }
    }
    class Base
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a Parent Class!!");
        }
    }

    class Drive : Base
    {
        public override void Print()
        {
            Console.WriteLine("This is a Child Class!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base drive = new Drive();
            drive.Print();

            Console.ReadLine();
        }
    }
}
