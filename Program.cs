using System;
using DotNetSamples.Attributes;

namespace DotNetSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProcessAttributes process = new ProcessAttributes();
            process.Run();
            
        }
    }
}
