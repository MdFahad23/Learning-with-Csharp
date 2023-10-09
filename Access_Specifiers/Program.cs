using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Public // Private //Protected //internal

namespace Access_Specifiers1
{
    public class Class1
    {
        public void Show1()
        {
            Console.WriteLine("This is Aaccess Specifiers class!!");
        }
    }
    internal class Program : Class1
    {
        static void Main(string[] args)
        {
            //Class1 c = new Class1();
            //c.Show1();


            //Console.ReadLine();
        }
    }
}
