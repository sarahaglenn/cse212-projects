using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
    }
    public int SumOfOneToN(int n) {
        if (n == 1)
        {
            return 1;
        }
        return n + SumOfOneToN(n - 1);
    }
}