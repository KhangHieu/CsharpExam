using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public class MainView
    {   
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome!");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("/n");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please enter your choice:");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Controller.AddProduct();
                        break;
                    case 2:
                        Controller.DisplayProduct();
                        break;
                    case 3:
                        Controller.DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("See you later.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
        }
    }
}