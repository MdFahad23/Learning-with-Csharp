using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{

    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age) { 
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return Name;
        }

        public int getAge()
        {
            return Age;
        }

        ~Person() {
            Console.WriteLine("Destructors has been Invocked!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ali = new Person("Ali", 25);
            Person Hasan = new Person("Hasan", 22);
            Console.WriteLine(ali.getName());
            Console.WriteLine(ali.getAge());
            Console.WriteLine("---------------------");
            Console.WriteLine(ali.getName());
            Console.WriteLine(ali.getAge());    

            //Console.ReadLine();
        }
    }
}
