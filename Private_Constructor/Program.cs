using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Example
    {
        public string name;

        //public Example(string name)
        //{
        //    this.name = name;
        //}
        private Example() //Private Constructor not create object
        {

        }

        public void getData()
        {
            Console.WriteLine("Your name is {0}", name);
        }
    }

    //class Example2 : Example
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example e = new Example("Atik");
            //e.getData();

            Console.ReadLine();
        }
    }
}
