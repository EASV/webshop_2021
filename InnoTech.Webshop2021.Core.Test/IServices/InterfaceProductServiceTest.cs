using System.Collections.Generic;
using InnoTech.Webshop2021.Core.IServices;
using InnoTech.Webshop2021.Core.Models;
using Moq;
using Xunit;

namespace InnoTech.Webshop2021.Core.Test.IServices
{
    public class InterfaceProductServiceTest
    {
        [Fact]
        public void IProductService_Exists()
        {
            var serviceMock = new Mock<IProductService>();
            Assert.NotNull(serviceMock.Object);
        }

        [Fact]
        public void GetAll_WithNoParams_ReturnsFilteredList()
        {
            //Arrange
            var expectedResult = new FilteredList
            {
                List = new List<Product>
                {
                    new Product { Id = 1, Name = "P1" },
                    new Product { Id = 2, Name = "P2" },
                }
            };
            var serviceMock = new Mock<IProductService>();
            serviceMock.Setup(ps => ps.GetAll())
                .Returns(expectedResult);

            //Assert
            Assert.Equal(expectedResult, serviceMock.Object.GetAll());
        }
    }
}