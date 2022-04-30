using Codewars.Remove_anchor_from_URL;
using NUnit.Framework;

namespace Codewars
{
    public class RemoveUrlAnchorTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("www.codewars.com", RemoveUrlAnchorKata.RemoveUrlAnchor("www.codewars.com#about"));
            Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveUrlAnchorKata.RemoveUrlAnchor("www.codewars.com/katas/?page=1"));
            Assert.AreEqual("www.codewars.com/katas/", RemoveUrlAnchorKata.RemoveUrlAnchor("www.codewars.com/katas/"));
        }
    }
}