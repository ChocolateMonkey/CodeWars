﻿using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
            Assert.AreEqual(")))(()()))()((()()((", Kata.DuplicateEncode("uHTQRHnFuFbFeIdTvFkP"));
        }
    }
}