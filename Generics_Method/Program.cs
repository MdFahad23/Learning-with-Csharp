using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Method
{
    class Example
    {
        public static void showArrey<G>(G[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static  bool EquilValue<G>(G a, G b) {
            bool result = a.Equals(b);
            return result;
        }

        public static void TypeCheck<G>(G a)
        {
            Console.WriteLine(a.GetType());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Number = { 1, 2, 3 };
            Example.showArrey(Number);

            string[] Name = {"Ali", "Abdul", "Akass" };
            Example.showArrey(Name);

            Console.WriteLine(Example.EquilValue(10, 10));
            Console.WriteLine(Example.EquilValue("Ak", "A"));

            Example.TypeCheck("Fahad");
            Example.TypeCheck(10.25);

            Console.ReadLine();
        }
    }
}
