using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World from .NET on Linux!");
            Console.WriteLine($"Running on: {Environment.OSVersion}");
            Console.WriteLine($".NET Version: {Environment.Version}");
        }
    }
}
