using Codewars.Remove_anchor_from_URL;
using NUnit.Framework;

namespace Codewars
{
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("www.codewars.com", Kata.RemoveUrlAnchor("www.codewars.com#about"));
            Assert.AreEqual("www.codewars.com/katas/?page=1", Kata.RemoveUrlAnchor("www.codewars.com/katas/?page=1"));
            Assert.AreEqual("www.codewars.com/katas/", Kata.RemoveUrlAnchor("www.codewars.com/katas/"));
        }
    }
}