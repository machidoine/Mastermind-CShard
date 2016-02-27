using Mastermind.View;
using NUnit.Core;
using NUnit.Framework;

namespace MastermindTest
{
    [TestFixture]
    public class ClassToTestTest
    {
        private ClassToTest _classToTest;

        [SetUp]
        public void Init()
        {
            _classToTest = new ClassToTest();
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(1, _classToTest.Method1());
        }
    }
}
