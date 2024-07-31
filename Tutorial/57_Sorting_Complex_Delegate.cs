using System;
using System.Collections.Generic;
class _57_Sorting_Complex_Delegate
{
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 100, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };

        List<Product> prods = new List<Product>() { p1, p2, p3, p4 };

        Console.WriteLine("Before Sorting by price");
        PrintProducts(prods);

        // Creating a delegate Function 
        Comparison<Product> compar = new Comparison<Product>(sortbyprice);
        // calling the function by passing the delegate in the sort method
        prods.Sort(compar);

        Console.WriteLine("\nAfter Sorting by Price");
        PrintProducts(prods);

        // Shorthand method
        prods.Sort(delegate (Product pr1, Product pr2) { return pr1.Reviews.CompareTo(pr2.Reviews); });
        Console.WriteLine("\nAfter Sorting by Reviews");
        PrintProducts(prods);

        // Another Shorthand
        prods.Sort((ps1,ps2) => ps1.Name.CompareTo(ps2.Name));
        Console.WriteLine("\nAfter Sorting by Name");
        PrintProducts(prods);
    }

    public static int sortbyprice(Product pr1, Product pr2)
    {
        return pr1.Price.CompareTo(pr2.Price);
    }

    public static void PrintProducts(List<Product> products)
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
