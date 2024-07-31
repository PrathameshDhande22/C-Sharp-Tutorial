using System;
using System.Collections.Generic;
class _56_Sorting_Complex
{
    static void Main(string[] args)
    {
        Product p1 = new Product() { Name = "Shampoo", Price = 200, Reviews = 3 };
        Product p2 = new Product() { Name = "Coconut Oil", Price = 100, Reviews = 2 };
        Product p3 = new Product() { Name = "ToothBrush", Price = 20, Reviews = 5 };
        Product p4 = new Product() { Name = "Water Bottle", Price = 230, Reviews = 2 };

        List<Product> products = new List<Product>();
        products.AddRange(new List<Product>() { p1, p2, p3, p4 });

        Console.WriteLine("All products List Before Sorting");
        PrintProducts(products);

        // Sorting
        products.Sort();
        Console.WriteLine("\nAll products List After Sorting By name");
        PrintProducts(products);

        // Sorting by Price
        products.Sort(new SortByPrice());
        Console.WriteLine("\nAll products List After Sorting By Price");
        PrintProducts(products);

        // Sorting by Reviews
        products.Sort(new SortByReviews());
        Console.WriteLine("\nAll products List After Sorting By Reviews");
        PrintProducts(products);
    }

    public static void PrintProducts(List<Product> products)
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}

// Sorting by Price
class SortByPrice : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        return x.Price.CompareTo(y.Price);
    }
}

// Sorting by Reviews
class SortByReviews : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        return x.Reviews.CompareTo(y.Reviews);
    }
}

// Sorting the complex type by implementing the or inheriting the IComparable Interface 
class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Reviews { get; set; }

    // Sorting by Product name
    public int CompareTo(Product other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"Product(Name={Name},Price={Price},Review={Reviews})";
    }
}
