namespace Alkau.Just.Test
{
    public class Tests
    {
        [Test]
        [TestCase(1, -1, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(128, 64, 192)]
        [TestCase(-100, -150, -250)]
        public void JustSumTest(int a, int b, int sum)
        {
            Assert.That(Alkau.Just.Nuget.Library.Sum(a, b), Is.EqualTo(sum));
        }

        [Test]
        public void RandomSumTest(
            [Random(-1000, 1000, 1)] int a,
            [Random(-1000, 1000, 1)] int b)
        {
            Assert.That(Alkau.Just.Nuget.Library.Sum(a, b), Is.EqualTo(a+b));
        }
    }
}