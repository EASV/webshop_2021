using InnoTech.Webshop2021.Core.Models;
using Xunit;

namespace InnoTech.Webshop2021.Core.Test.Models
{
    public class ProductTest
    {
        private readonly Product _product;

        public ProductTest()
        {
            _product = new Product();
        }

        [Fact]
        public void ProductClass_Exists()
        {
            Assert.NotNull(_product);
        }

        [Fact]
        public void ProductClass_HasId_WithTypeInt()
        {
            //Arrange
            int expected = 1;
            //Act
            _product.Id = expected;
            //Assert
            Assert.Equal(expected, _product.Id);
        }
        
        [Fact]
        public void ProductClass_HaName_WithTypeString()
        {
            //Arrange
            string expected = "TheName";
            //Act
            _product.Name = expected;
            //Assert
            Assert.Equal(expected, _product.Name);
        }

        [Fact]
        public void Equals_WithProductWithSameProperties_ReturnTrue()
        {
            var product1 = new Product { Id = 1, Name = "Snurf" };
            var product2 = new Product { Id = 1, Name = "Snurf" };
            Assert.True(product1.Equals(product2));
            Assert.True(product2.Equals(product1));
            Assert.False(product1.Equals(null));
            Assert.False(product2.Equals(null));
        }
    }
}