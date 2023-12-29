using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));            
        }

        [TestMethod]
        public void EmptyReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BracketLettersReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void EnclosedBracketLettersReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test[[bracket]][](parhent)]"));
        }
        

        [TestMethod]
        public void LetterAndEmptyBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Launch[Code]"));
        }
        [TestMethod]
        public void WrongBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[hj]"));
        }

        [TestMethod]
        public void WrongBracketDirectionReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]hj["));
        }

        [TestMethod]
        public void WrongLetterBracketDirectionReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void OneBracketRetursFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void TestNullString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(null));
        }
    }
}
