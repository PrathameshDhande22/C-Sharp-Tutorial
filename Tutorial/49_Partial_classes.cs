using System;

class _49_Partial_classes
{
    static void Main(string[] args)
    {
        // Creating Instance of Partial Class
        Repository repo = new Repository() { Name = "Prathamesh" };
        repo.PrintName();
    }
}


// Partial Class
partial class Repository
{
    private string _name;

    // partial Method definition
    partial void RepositoryBase();

    public string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }
}


// Another class with Partial
partial class Repository
{
    public void PrintName()
    {
        Console.WriteLine($"Name is {this._name}");
    }

    // partial method implementation
    partial void RepositoryBase()
    {
        Console.WriteLine("Thesse is the Repository Base");
    }
}

// partial interface
partial interface Github
{
    // in partial interface we can't declare partial methods declaration
    void Packages();
}

// using another partial interface
partial interface Github
{
    void Projects();
}

// Using the partial interface in the class
class GithubHome : Github
{
    public void Packages()
    {
        Console.WriteLine("Github Packages");
    }

    public void Projects()
    {
        Console.WriteLine("Github Projects");
    }
}


