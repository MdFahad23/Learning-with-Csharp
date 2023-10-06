using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Types of Array
            //Based on how arrays store elements, arrays can be categorized into following two types:
            // 1. Single-dimensional Arrays
            // 1. Multe-dimensional Arrays



            // 1. Single-dimensional Arrays

            /*int[] new_arrays = new int[4];

            new_arrays[0] = 11;
            new_arrays[1] = 22;
            new_arrays[2] = 33;
            new_arrays[3] = 44;*/

            //string[] new_arrays = new string[] {"Hasan", "Akil", "Amaun" };
            //string[] new_arrays = {"Hasan", "Akil", "Amaun" };

            //Console.WriteLine(new_arrays[0]);
            //Console.WriteLine(new_arrays[1]);
            //Console.WriteLine(new_arrays[2]);
            //Console.WriteLine(new_arrays[3]);

            /*Arrey Itrect for Loop*/

            /*int[] numbers = {11, 22, 33, 44, 55, 66, 77, 88, 99 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Itrect by Foreach Loop");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }*/


            //2. Multe-dimensional Arrays

            //Rectangular Array

            /*int[,] numbers = new int[3, 4]
            {
                {11, 22, 33, 44 },
                {55, 66, 77, 88 },
                {95, 96, 97, 98 }
            };

            /*int[,] numbers = new int[, ]
            {
                {11, 22, 33, 44 },
                {55, 66, 77, 88 },
                {95, 96, 97, 98 }
            };

            /*int[,] numbers = {
                {11, 22, 33, 44 },
                {55, 66, 77, 88 },
                {95, 96, 97, 98 }
            };

            //Console.WriteLine(numbers[0,3]);
            //Console.WriteLine(numbers.GetLength(0));

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                //Console.WriteLine(numbers[i,0]);
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            //Jagged Array

            int[][] numbers = new int[3][];

            numbers[0] = new[] { 11, 22, 33, 44, 49, 36, 95 };
            numbers[1] = new[] { 55, 66, 77, 88, 59, 20 };
            numbers[2] = new[] { 95, 96, 97, 98, 20 };

            //Console.WriteLine(numbers[1][1]);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                //Console.WriteLine(numbers[i,0]);
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (int[] items in numbers)
            {
                foreach (int item in items)
                {
                    Console.WriteLine(item);
                }
            }

            //Programes
            Console.WriteLine("How Many number of items u want to store in array");
            int number = int.Parse(Console.ReadLine());
            int[] number_array = new int[number];

            for (int i = 0; i < number_array.Length; i++)
            {
                Console.WriteLine("Enter data in your loaction: " + (i+1));
                int data = int.Parse(Console.ReadLine());
                number_array[i] = data;
            }

            Console.WriteLine("---------- Enter Data --------------");

            foreach (int item in number_array)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
