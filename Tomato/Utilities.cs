using System;

namespace Tomato
{
    public static class Utilities
    {
        public static char KeyPrompt(string prompt)
        {
            Console.Write(prompt);
            var choice = Console.ReadKey();
            Console.WriteLine();
            return choice.KeyChar;
        }
        public static string Prompt(string prompt)
        {
            Console.Write(prompt);
            var choice = Console.ReadLine().Trim();
            //Console.WriteLine();
            return choice;
        }
    }
}