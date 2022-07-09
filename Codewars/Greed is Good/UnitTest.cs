using Codewars.Greed_is_Good;
using NUnit.Framework;

namespace Codewars
{
    public class GreedIsGoodTests
    {
        [Test]
        public static void ShouldBeWorthless()
        {
            Assert.AreEqual(0, GreedIsGoodKata.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
        }

        [Test]
        public static void ShouldValueTriplets()
        {
            Assert.AreEqual(400, GreedIsGoodKata.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
        }

        [Test]
        public static void ShouldValueMixedSets()
        {
            Assert.AreEqual(450, GreedIsGoodKata.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
        }
        
        [Test]
        public static void FiveOnesReturns1200()
        {
            Assert.AreEqual(1200, GreedIsGoodKata.Score(new int[] { 1, 1, 1, 1, 1 }), "Should be 1200");
        }
    }
}