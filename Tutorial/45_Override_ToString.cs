using System;
class _45_Override_ToString
{

    static void Main(string[] args)
    {
        Customer[] customers = { new Customer() { Name = "Prathamesh", City = "Boisar" }, new Customer() { Name = "John", City = "Paris" }, new Customer { Name = "Steve", City = "London" } };

        foreach(Customer customer in customers)
        {
            Console.WriteLine(customer);
        }

    }

}


class Customer
{
    public string Name { get; set; }
    public string City { get; set; }
    // Overriding ToString Method
    public override string ToString()
    {
        return $"Customer(Name={Name},City={City}";
    }
}
