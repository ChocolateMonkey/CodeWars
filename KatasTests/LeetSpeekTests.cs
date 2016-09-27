
using Katas;

namespace KatasTests
{
    using NUnit.Framework;

    [TestFixture]
    public class LeetSpeekTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1337", Kata.ToLeetSpeak("LEET"));
            Assert.AreEqual("(0D3W@R$", Kata.ToLeetSpeak("CODEWARS"));
            Assert.AreEqual("#3110 W0R1D", Kata.ToLeetSpeak("HELLO WORLD"));
            Assert.AreEqual("10R3M !P$UM D010R $!7 @M37", Kata.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
            Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06", Kata.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
        }
    }
}
