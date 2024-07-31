using System;
using System.IO;
class _69_FileWriter
{
    static void Main(string[] args)
    {
        // Writing a file
        string path = @"C:\Users\PrathameshDhande\OneDrive - Systenics Solutions LLP\Documents\Training\C#\Tutorial";
        DirectoryInfo dirinfo = new DirectoryInfo(path);
        FileInfo[] fi = dirinfo.GetFiles();
        Console.WriteLine("Files in the Directory");
        foreach (FileInfo fi2 in fi)
        {
            Console.WriteLine(fi2);
        }
        FileStream fs = File.Create(path + @"\newfile.txt");
        Console.WriteLine(fs.Name);
        Console.WriteLine("Is File Readable : " + fs.CanRead + ",Is file Writable : " + fs.CanWrite);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write("hello this is a file written by c#");
        sw.Close();
        fs.Close();


        // Is Keyword
        if(0 is 0)
        {
            Console.WriteLine("Yes");
        }
    }
}
