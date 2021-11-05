using System.Collections.Generic;
using InnoTech.Webshop2021.Core.Models;
using Xunit;

namespace InnoTech.Webshop2021.Core.Test.Models
{
    public class FilteredListTest
    {
        [Fact]
        public void FilteredList_Exists()
        {
            var list = new FilteredList();
            Assert.NotNull(list);
        }

        [Fact]
        public void FilteredList_HasPropertyList_OfTypeListOfProducts()
        {
            var expected = new List<Product>
            {
                new Product{Id = 1, Name = "Product1"}
            };
            var filteredList = new FilteredList();
            filteredList.List = expected;
            
            Assert.Equal(expected, filteredList.List);
        }
    }
}