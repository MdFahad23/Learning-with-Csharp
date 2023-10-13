using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    public delegate void MyDelegate(int a);
    internal class Program
    {
        public static void MyMethod(MyDelegate obj, int a)
        {
            a += 20;
            obj.Invoke(a);
        }


        //Simple Method call by delegate

        //public static void MyMethod(int a){
        //    a += 20;
        //    Console.WriteLine(a);
        //}
        static void Main(string[] args)
        {
            //Anonymoua Function pass By Parameter Delegate Function
            Program.MyMethod(delegate (int b) { b += 20; Console.WriteLine(b); }, 5);

            //AnonymousFunction
            MyDelegate obj = delegate (int a)
            {
                a += 20;
                Console.WriteLine(a);
            };

            obj(40);

            //Simple Delegate Function

            //MyDelegate obj = new MyDelegate(Program.MyMethod);
            //obj.Invoke(40);
            //obj(40);

            Console.ReadLine();
        }
    }
}
