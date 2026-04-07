using Microsoft.Extensions.Configuration;
using ProductManagementApp.Data;
using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProductManagementApp
{
    class Program
    {
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            ProductDAL dal = new ProductDAL(config);

            while (true)
            {
                Console.WriteLine("\n===== PRODUCT MANAGEMENT =====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product p = new Product();

                        Console.Write("Name: ");
                        p.ProductName = Console.ReadLine() ?? "";

                        Console.Write("Category: ");
                        p.Category = Console.ReadLine() ?? "";

                        Console.Write("Price: ");
                        p.Price = Convert.ToDecimal(Console.ReadLine());

                        dal.InsertProduct(p);
                        break;

                    case 2:
                        List<Product> list = dal.GetAllProducts();

                        Console.WriteLine("\n--- Products ---");
                        foreach (var item in list)
                        {
                            Console.WriteLine($"{item.ProductId} | {item.ProductName} | {item.Category} | ₹{item.Price}");
                        }
                        break;

                    case 3:
                        Product up = new Product();

                        Console.Write("ID: ");
                        up.ProductId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("New Name: ");
                        up.ProductName = Console.ReadLine() ?? "";

                        Console.Write("New Category: ");
                        up.Category = Console.ReadLine() ?? "";

                        Console.Write("New Price: ");
                        up.Price = Convert.ToDecimal(Console.ReadLine());

                        dal.UpdateProduct(up);
                        break;

                    case 4:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        dal.DeleteProduct(id);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}