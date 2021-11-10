using System.Collections.Generic;
using System.IO;
using InnoTech.Webshop2021.Core.IServices;
using InnoTech.Webshop2021.Core.Models;
using InnoTech.Webshop2021.Domain.IRepositories;
using InnoTech.Webshop2021.Domain.Services;
using Moq;
using Xunit;

namespace InnoTech.Webshop2021.Domain.Test.Services
{
    public class ProductServiceTest
    {
        [Fact]
        public void ProductService_WithIProductRepositoryAsParam_ImplementsIProductService()
        {
            var repoMock = new Mock<IProductRepository>();
            var service = new ProductService(repoMock.Object);
            Assert.IsAssignableFrom<IProductService>(service);
        }

        [Fact]
        public void ProductService_WithNullAsParam_ThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(
                    () => new ProductService(null));
        }
        
        [Fact]
        public void ProductService_WithNullAsParam_ThrowsExceptionWithMessage()
        {
           var exception = Assert.Throws<InvalidDataException>(
                () => new ProductService(null));
           Assert.Equal("ProductRepository Cannot be null", exception.Message);
        }

        [Fact]
        public void GetAll_CallsProductRepositoryReadAll_Once()
        {
            //Arrange
            var mockRepo = new Mock<IProductRepository>();
            var service = new ProductService(mockRepo.Object);
            
            //Act
            service.GetAll();
            
            //Assert
            mockRepo.Verify(r => r.ReadAll(), Times.Once);
        }

        [Fact]
        public void GetAll_CallsProductRepositoryReadAll_ReturnsFilteredList()
        {
            //Arrange
            var expected = new FilteredList
            {
                List = new List<Product>
                {
                    new Product{Id = 1, Name = "Lego1"},
                    new Product{Id = 1, Name = "Lego2"}
                }
            };
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(r => r.ReadAll())
                .Returns(expected);
            var service = new ProductService(mockRepo.Object);
            
            //Act
            var actual = service.GetAll();
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}