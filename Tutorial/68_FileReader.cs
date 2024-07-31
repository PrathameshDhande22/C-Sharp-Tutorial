using System;
using System.IO;

class _68_FileReader
{
    static void Main(string[] args)
    {
        // Reading a File  
        String path = @"C:\Users\PrathameshDhande\OneDrive - Systenics Solutions LLP\Documents\Training\C#\Tutorial\bigfile.txt";

        // File INfo
        FileInfo file = new FileInfo(path);
        Console.WriteLine("File Full Path : {0}",file.FullName);
        Console.WriteLine("Parent Directory : {0}",file.Directory);
        Console.WriteLine("file Extension : {0}",file.Extension);
        FileStream fileS = file.Open(FileMode.Open, FileAccess.Read);

        if (fileS.CanRead)
        {
            Console.WriteLine("yes these is readable file");
        }

        if (fileS.CanWrite)
        {
            Console.WriteLine("Yes File can be written");
        }

        // Reading the file
        int i = 0;
        while((i=fileS.ReadByte()) != -1)
        {
            Console.Write((char)i);
        }
        fileS.Close();

        // Simplest method to read the files
        StreamReader sr = new StreamReader(path);
        Console.WriteLine("\nReading file from start to End");
        Console.WriteLine(sr.ReadToEnd());


    }
}

