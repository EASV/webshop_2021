using InnoTech.Webshop2021.Core.Models;
using InnoTech.Webshop2021.Domain.IRepositories;
using Moq;
using Xunit;

namespace InnoTech.Webshop2021.Domain.Test.IRepositories
{
    public class InterfaceProductRepositoryTest
    {
        [Fact]
        public void IProductRepository_Exists()
        {
            var mockRepo = new Mock<IProductRepository>();
            Assert.NotNull(mockRepo.Object);
        }

        [Fact]
        public void ReadAll_WithNoParams_ReturnsFilteredListOfProducts()
        {
            var expected = new FilteredList();
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(mr => mr.ReadAll())
                .Returns(expected);
            Assert.Equal(expected, mockRepo.Object.ReadAll());
        }
    }
}