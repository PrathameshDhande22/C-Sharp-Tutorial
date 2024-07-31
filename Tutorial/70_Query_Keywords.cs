using System;
using System.Collections.Generic;
using System.Linq;
class _70_Query_Keywords
    {
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 4000, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };
        Product p5 = new Product() { Name = "Hand Sanitizer", Price = 50, Reviews = 4 };
        Product p6 = new Product() { Name = "Face Mask", Price = 10, Reviews = 1 };
        List<Product> products = new List<Product>() { p1,p2,p3,p4,p5,p6 };

        // These is called as LINQ (Language Integrated Query)
        var result = from prod in products where prod.Price <= 50 orderby prod.Price descending select prod;
        PrintProducts(result);
    }

    static void PrintProducts(IEnumerable<Product> products)
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
