using System;
using CartPromotionEngine.Implementations;
using CartPromotionEngine.interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CartPromotionEngineTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void WhenProductIsAThenReturnValue()
        {
            // Arrange
            //var product = Substitute.For<IProduct>();
            var product = new Product();
            int value = 50;
            //product.GetItemCost('A').Returns(value);

            // Act
            var result = product.GetItemCost('A');

            // Assert
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void WhenProductIsBThenReturnValue()
        {
            // Arrange
            //var product = Substitute.For<IProduct>();
            int value = 30;
            var product = new Product();
            //product.GetItemCost('B').Returns(value);

            // Act
            var result = product.GetItemCost('B');

            // Assert
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void WhenProductIsCThenReturnValue()
        {
            // Arrange
            //var product = Substitute.For<IProduct>();
            var product = new Product();
            int value = 20;
            //product.GetItemCost('C').Returns(value);

            // Act
            var result = product.GetItemCost('C');

            // Assert
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void WhenProductIsDThenReturnValue()
        {
            // Arrange
            //var product = Substitute.For<IProduct>();
            var product = new Product();
            int value = 15;
            //product.GetItemCost('D').Returns(value);

            // Act
            var result = product.GetItemCost('D');

            // Assert
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void WhenProductDoesNotExistThenReturnNegativeValue()
        {
            // Arrange
            //var product = Substitute.For<IProduct>();
            var product = new Product();
            int value = -1;
            //product.GetItemCost('E').Returns(value);

            // Act
            var result = product.GetItemCost('E');

            // Assert
            Assert.AreEqual(value, result);
        }
    }
}
