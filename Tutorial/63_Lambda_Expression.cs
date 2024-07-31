using System;
using System.Collections.Generic;
using System.Linq;
class _63_Lambda_Expression
    {
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 4000, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };
        Product p5 = new Product() { Name = "Hand Sanitizer", Price = 50, Reviews = 4 };
        List<Product> prods = new List<Product>() { p1, p2, p3, p4, p5 };

        // using lambda expression
        Console.WriteLine(prods.Count((Product pr) => pr.Price <= 200));

        // alternate 
        Console.WriteLine(prods.Count((pr) => pr.Price >= 300));
    }
}
