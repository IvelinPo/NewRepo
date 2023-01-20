namespace Summator.UnitTests
{
    public class SummatorTests
    {
            [Test]
            public void Test_Summator_SumTwoPositiveNumbers()
            {
                var nums = new int[] { 1, 2 };
                var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);  
            }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -2 };
            var actual = Summator.Sum(nums);

            var expected = -3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumEmptyArray()
        {
            var nums = new int[] {  };
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            var nums = new int[] { 1000000000, 1000000000 };
            var actual = Summator.Sum(nums);

            var expected = 2000000000;

            Assert.AreEqual(expected, actual);
        }


    }
}