using System;
using System.IO;

var filePath = "D:\\D FILES\\Ken\\Learning\\c sharp scripting\\SAMPLETEXTFILE2.txt";

// Check if the file exists, if not, create it
if (!File.Exists(filePath))
{
    using (StreamWriter writer = File.CreateText(filePath))
    {
        Console.WriteLine("File didn't exist. It has now been created.");
        writer.WriteLine("This file didn't exist but has been dynamically created.");
    }
}
else
{

    //write to a file
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine("This is a sample text written to the file.");
    }

    // read from a file
    using (StreamReader reader = new StreamReader(filePath))
    {
        string content = reader.ReadToEnd();
        Console.WriteLine(content);
    }
}