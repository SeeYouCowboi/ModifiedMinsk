using System;

namespace mc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">: ");
            var line = Console.ReadLine(); ;
            if (string.IsNullOrWhiteSpace(line))
                return;
        }
    }
}
