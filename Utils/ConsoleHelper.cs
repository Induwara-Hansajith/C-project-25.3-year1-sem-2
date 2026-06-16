using System;

namespace TempleManagementSystem.Utils
{
    public static class ConsoleHelper
    {
        public static void Header(string text)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(text);
            Console.WriteLine(new string('=', 50));
        }
    }
}
