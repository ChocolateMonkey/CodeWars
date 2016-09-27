using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual(Kata.Disemvowel("This website is for losers LOL!"),
                "Ths wbst s fr lsrs LL!");
        }
    }
}