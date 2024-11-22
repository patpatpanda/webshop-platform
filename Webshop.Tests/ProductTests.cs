using Xunit;
using ogabogaShop.Models; // Ändra efter din namespace

namespace Webshop.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_Should_Initialize_With_Valid_Data()
        {
            // Arrange
            var productName = "Test Product";
            var price = 99.99m;

            // Act
            var product = new Product
            {
                Name = productName,
                Price = price
            };

            // Assert
            Assert.Equal(productName, product.Name);
            Assert.Equal(price, product.Price);
        }

        [Fact]
        public void Product_Should_Throw_Exception_For_Invalid_Price()
        {
            // Arrange
            var product = new Product();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.Price = -10);
        }
    }
}
