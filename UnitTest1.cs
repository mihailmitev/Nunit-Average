using NUnit.Framework;

namespace Average.Tests
{
    public class AverageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyArray()
        {
            var arr = new int[] { };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(0, average);
        }
        [Test]
        public void TwoNegativeNumbers()
        {
            var arr = new int[] {-2, -6 };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(-4, average);
        }
        [Test]
        public void NumbersOverThousand()
        {
            var arr = new int[] {10000, 6000, 5000 };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(7000, average);
        }
        [Test]
        public void TwoPositiveAndTwoNegative()
        {
            var arr = new int[] {-10,-60,100,160 };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(47.5, average);
        }
        [Test]
        public void FivePositiveNumbers()
        {
            var arr = new int[] {6, 10, 100, 122, 150 };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(77.6, average);
        }
        [Test]
        public void OneNegativeOnePositive()
        {
            var arr = new int[] {100,-200 };

            var average = Average.AverageArr(arr);

            Assert.AreEqual(-50, average);
        }

    }
}
