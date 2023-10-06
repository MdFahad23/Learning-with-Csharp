using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_Reference_Type
{
    
    class Program
    {
        /*public static void PassBayValue(int a)
        {
            a = a + 50;
            Console.WriteLine("Value: {0}", a);
        }*/

        /*public static void passBayRef(ref int a)
        {
            a = a + 50;
            console.writeline("value: {0}", a);
        }*/

        public static void passBayOut(out int a)
        {
            a = 50;
            Console.WriteLine("Value: {0}", a);
        }

        static void Main(string[] args)
        {
            /*Pass Bay Value*/
            /*int value = 30;
            PassBayValue(value);
            Console.WriteLine(value);*/

            /*Pass Bay Ref*/
            /* int a = 10;
             PassBayRef(ref a);
             Console.WriteLine(a);*/

            /*Pass Bay out*/
            int a;
            passBayOut(out a);
            Console.WriteLine(a);



            Console.ReadLine();
        }
    }
}
