using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //interface IEmploy
    //{
    //    void show();
    //}

    //class PartTimeEmploy : IEmploy
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("This is a method of IEmploy Interface!!");
    //    }
    //}

    //Implicit Interface Inheritence
    interface I1
    {
        void Show1();
    }

    interface I2
    {
        void Show2();
    }

    interface I3 : I1 , I2
    {
        void Show3();
    }

    class Program : I3
    {

        public void Show1()
        {
            Console.WriteLine("This is interface One");
        }

        public void Show2()
        {
            Console.WriteLine("This is interface Two");
        }

        public void Show3()
        {
            Console.WriteLine("This is interface Three");
        }
        static void Main(string[] args)
        {
            //PartTimeEmploy part = new PartTimeEmploy();
            //part.show();

            //Interface Inheritence
            I3 infa = new Program();
            infa.Show1();
            infa.Show2();
            infa.Show3();

            Console.ReadLine();
        }
    }
}

