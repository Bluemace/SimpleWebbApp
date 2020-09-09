using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleWebHalloWorld.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int x = 1;
            //Act
            x += 1;
            //Assert
            Assert.AreEqual(2, x);
        }
        [TestMethod]

        public void TestMethod2()
        {
            //Arrange
            bool test;

            //Act
            test = true;
            //Assert
            Assert.IsTrue(test);
        }
    }
}
