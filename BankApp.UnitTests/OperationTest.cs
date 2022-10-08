using BankApp.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApp.UnitTests
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void CanBeCancel_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var operation = new Operation();

            //Actual
            bool result =  operation.CanBeCancelEFT(new User() { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }
    }
}
