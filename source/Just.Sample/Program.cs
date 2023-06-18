namespace Just.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int a = 1;
            const int b = -a;
            var sum = Alkau.Just.Nuget.Library.Sum(a, b);
            Alkau.Just.Nuget.Library.Log($"The sum of {a} and {b} is {sum}");
        }
    }
}