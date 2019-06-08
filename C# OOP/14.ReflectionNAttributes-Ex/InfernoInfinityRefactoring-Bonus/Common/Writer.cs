using System;

public class Writer : IWriter
{
    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
}