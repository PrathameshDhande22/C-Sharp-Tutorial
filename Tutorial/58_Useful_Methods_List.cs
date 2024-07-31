using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
class _58_Useful_Methods_List
{
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 100, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };
        List<Product> products = new List<Product>(40) { p1,p2,p3,p4};

        // True for all method
        Console.WriteLine("All the products are having Reviews greater than equal to 2: {0}",products.TrueForAll(pr=>pr.Reviews>=2));

        // Readonly collection
        ReadOnlyCollection<Product> readonlyproducts = products.AsReadOnly();
        // we can't change the value or delete the value from the readonly collection
        // Accessing the single value via indexing.
        Console.WriteLine(readonlyproducts[1]);

        // Trim Excess;
        Console.WriteLine("Before Trimming Capacity : {0}",products.Capacity);
        // using the TrimExcess method
        products.TrimExcess();
        Console.WriteLine("After Trimming Capacity: {0}",products.Capacity);
    }
}
