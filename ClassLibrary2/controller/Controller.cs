using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClassLibrary2
{
    public class Controller
    {
        private static List<Product> list = new List<Product>()
        {
            new Product("MN001", "Monitor", 38),
            new Product("C01022", "CPU", 94),
        };
        
        public static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Please enter the product information. \t");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            var product = new Product(id, name, price);
            list.Add(product);
            Console.WriteLine("Continue? (Y/N)");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                AddProduct();
            }
        }

        public static void DisplayProduct()
        {
            Console.WriteLine("--------------Student List----------------");
            Console.WriteLine("{0, -15} {1, -10} {2, -5}", "Id", "Name", "Price");
            Console.WriteLine("------------------------------------------");
            foreach (var product in list)
            {
                Console.WriteLine("{0, -15} {1, -10} {2, -5}", product.Id, product.Name, product.Price);
            }

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadLine();
        }

        public static void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the id to delete the product: ");
            var id = Console.ReadLine();
            Console.WriteLine("Are you sure want to delete this product? (Press 'Y' to continue)");
            var choice = Console.ReadLine();
            if (choice == "y")
            {
                foreach (var product in list)
                {
                    if (product.Id == id)
                    {
                        list.Remove(product);
                        Console.WriteLine("Deleted successful!");
                        Console.ReadLine();
                    }
                }    
            }  
        }
    }
}