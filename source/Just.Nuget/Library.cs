using System;

namespace Alkau.Just.Nuget
{
    /// <summary>
    /// This is just an example library.
    /// </summary>
    public static class Library
    {
        /// <summary>
        /// It just prints text to the console.
        /// </summary>
        /// <param name="text">it's just some text</param>
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// It's just a sum.
        /// </summary>
        /// <param name="a">The first term.</param>
        /// <param name="b">The second term.</param>
        /// <returns>It is the sum.</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
