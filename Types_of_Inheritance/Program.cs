using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Inheritance
{
    /*Inheritance*/ // ---------  /*Single*/  /*Hierarchial*/  /*Multe Lebel*/  /*Multiple(User Interface)*/
    internal class Program
    {
        class BaseClass
        {
            public void show()
            {
                Console.WriteLine("This is show BaseClass!!");
            }
        }

        class DerivedClass1 : BaseClass
        {
            public void show1()
            {
                Console.WriteLine("This is show 1st Drived Class!!");
            }
        }

        class DerivedClass2 : DerivedClass1
        {
            public void show2()
            {
                Console.WriteLine("This is show 2ndt Drived Class!!");
            }
        }
        static void Main(string[] args)
        {
            DerivedClass2 obj = new DerivedClass2();
            obj.show();
            obj.show1();
            obj.show2();

            Console.ReadLine();
        }
    }
}
