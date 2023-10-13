using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding //Inheritence
{
    class Employes
    {
        public string firstName;
        public string lastName; 

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class partTimeEmployes : Employes
    {
        public new void printFullName()
        {
            //base.printFullName();
            //Console.WriteLine(firstName + " " + lastName + " Part");
        }
    }

    class fullTimeEmployes : Employes
    {
        public new void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " Full");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            partTimeEmployes part = new partTimeEmployes();
            //Employes part = new partTimeEmployes();
            part.firstName = "Atikyl";
            part.lastName = "Islam";
            //part.printfullname();
            //((Employes)part).printFullName();

            Console.ReadLine();

        }
    }
}
