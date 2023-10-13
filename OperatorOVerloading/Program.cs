using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Polymorphism of 2 types
//Static Polymorphism   //Dynamic Polymorphism


//This is Static Polymorphism (Complie time Polymorphism) -- *Method Overloading  * Operator Overloading
namespace OperatorOVerloading
{
    class newClass
    {
        public string str;
        public int num;

       public static newClass operator +(newClass obj1, newClass obj2) { 
            newClass obj3 = new newClass();
            obj3.str = obj1.str + " " + obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;
       }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            newClass obj1 = new newClass();
            obj1.str = "Mohammad";
            obj1.num = 11;

            newClass obj2 = new newClass();
            obj2.str = "Fahad";
            obj2.num = 11;

            newClass obj3 = new newClass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);

            Console.ReadLine();
        }
    }
}
