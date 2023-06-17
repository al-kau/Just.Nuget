using System;

namespace Alkau.Just.Nuget
{
    public static class Library
    {
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
