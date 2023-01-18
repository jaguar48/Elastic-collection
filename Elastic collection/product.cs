using System;
using System.Collections.Generic;
using System.Dynamic;


namespace Elastic_collection
{
    public class MyClass

    {
        public static dynamic CreateProduct(int id, string name, int quantity, decimal price, string category, int orderCount)
        {
            dynamic product = new ExpandoObject();
            product.Id = id;
            product.Name = name;
            product.Quantity = quantity;
            product.Price = price;
            product.Category = category;
            product.OrderCount = orderCount;
            return product;
        }

        public static void ListProducts(List<dynamic> products, string[] properties)
        {
            foreach (dynamic product in products)
            {
                foreach (var property in product)
                {
                    if (Array.IndexOf(properties, property.Key) == -1) continue;
                    Console.Write(property.Key + ": " + property.Value + ", ");
                }
                Console.WriteLine();
            }
        }

        public static string[] GetProperties()
        {
            Console.WriteLine("Enter the properties you want to display, separated by commas:");
            var input = Console.ReadLine();
            string[] properties = input.Split(',');
            return properties;
        }
    }
}
