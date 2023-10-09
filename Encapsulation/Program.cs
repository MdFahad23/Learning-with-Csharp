using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        string name;
        int age;

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name) == true) {
                Console.WriteLine("Your Name is Requird!!");
            }
            else
            {
                this.name = name;
            }
        }

        public void getName()
        {
            if (string.IsNullOrEmpty(name) != true)
            {
                Console.WriteLine("This name is {0}", name);
            }
        }

        public void setAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Your age is Requird!!");
            }
            else
            {
                this.age = age;
            }
        }

        public void getAge()
        {
            if (age > 0)
            {
                Console.WriteLine("This age is {0}", age);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.setName("Md Fahad");
            person1.getName();
            person1.setAge(22);
            person1.getAge();

            Console.ReadLine();
        }
    }
}
