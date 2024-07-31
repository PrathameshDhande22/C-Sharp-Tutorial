using System;
using System.Collections.Generic;
using System.Linq;
class _59_List_Extension_Methods
{
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 4000, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };
        Product p5 = new Product() { Name = "Hand Sanitizer", Price = 50, Reviews = 4 };
        Product p6 = new Product() { Name = "Face Mask", Price = 10, Reviews = 1 };
        Product p7 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p8 = new Product() { Name = "Coconut Oil", Price = 100, Reviews = 2 };
        Product p9 = new Product() { Name = "Notebook", Price = 60, Reviews = 3 };
        Product p10 = new Product() { Name = "Pen", Price = 5, Reviews = 5 };

        List<Product> prods1 = new List<Product>() { p1, p2, p3, p4, p9 };
        List<Product> prods2 = new List<Product>() { p5, p1, p10, p7, p8 };

        // Intesect Extension method
        IEnumerable<Product> lops = prods1.Intersect(prods2,new CompareByPrice());
        foreach(Product p in lops)
        {
            Console.WriteLine(p);
        }

        // Max Method
        Console.WriteLine(prods1.Max((pr1)=>pr1.Price));

        // Order by
        lops=prods1.OrderByDescending(pr => pr.Price);
        foreach (Product p in lops)
        {
            Console.WriteLine(p);
        }

        // Sum method
        Console.WriteLine("Total Prices of Products : {0}",prods1.Sum(pr => pr.Price));

        // Union Method
        Console.WriteLine("\nUnion of Two List");
        lops = prods1.Union(prods2);
        foreach (Product p in lops)
        {
            Console.WriteLine(p);
        }

        prods1 = lops.ToList();
        Console.WriteLine("\n whole list");
        foreach (Product p in lops)
        {
            Console.WriteLine(p);
        }

        // Where Method
        Console.WriteLine("\nWhere Method whose price is greater than 200 or equal and reviews greater than 2 or equal");
        lops=prods1.Where(pr => pr.Price>=200).Where(pr=>pr.Reviews>=2);
        foreach (Product p in lops)
        {
            Console.WriteLine(p);
        }


    }
}

class CompareByPrice : IEqualityComparer<Product>
{
    public bool Equals(Product x, Product y)
    {
        if (x.Price == y.Price)
        {
            return true;
        }
        return false;
    }

    public int GetHashCode(Product obj)
    {
        return obj.GetHashCode();
    }
}

