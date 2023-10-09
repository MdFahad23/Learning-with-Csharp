using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statick_Class
{
    static class Product
    {
        public static int productId;
        public static string productName;
        public static int productPrice;

        static Product()
        {
            productId = 361;
            productName = "Computer";
            productPrice = 56000;
        }

        public static void getProductDetails()
        {
            Console.WriteLine("Your Product Id = {0}", productId);
            Console.WriteLine("Your Product Name = {0}", productName);
            Console.WriteLine("Your Product Price = {0}", productPrice);
        }

        public static void productDiscount()
        {
            int discount = productPrice / 10;
            Console.WriteLine("Your discount = {0}", discount);
            Console.WriteLine("Your discount price = {0}", (productPrice - discount));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product.getProductDetails();
            Product.productDiscount();

            Console.ReadLine();
        }
    }
}
