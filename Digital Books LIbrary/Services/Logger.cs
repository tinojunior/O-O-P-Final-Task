using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Services
{
    public static class Logger
    {
        public static void Error(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        public static void Information(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }
    }
}
