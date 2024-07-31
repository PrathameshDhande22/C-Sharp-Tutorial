using System;

// Using the defined Namespace by alias
using AUCTIONWORX = Systenics.AuctionWorx;
using PHARMABID = Systenics.PharmaBid;

using ProjectB;

class _20_NameSpaces
{
    // Namespaces Tutorial

    static void Main(string[] args)
    {
        // Calling method from the namespaces
        AUCTIONWORX.Database.Intro();
        AUCTIONWORX.UI.Intro();
        PHARMABID.Database.Intro();
        ClassA.Intro();

    }

}

// Defining the Namespaces
namespace Systenics
{
    // Defining Nested Namespaces
    namespace AuctionWorx
    {
        class Database
        {
            public static void Intro()
            {

                Console.WriteLine("These is Database of AuctionWorx");
            }
        }

        class UI
        {
            public static void Intro()
            {
                Console.WriteLine("These is UI of AuctionWorx");
            }
        }
    }

    namespace PharmaBid
    {
        class Database
        {
            public static void Intro()
            {
                Console.WriteLine("These is Database of PharmaBid");
            }
        }
    }
}

