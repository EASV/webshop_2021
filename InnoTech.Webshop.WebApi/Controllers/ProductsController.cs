using System.Collections.Generic;
using InnoTech.Webshop.WebApi.Dtos.Products;
using Microsoft.AspNetCore.Mvc;

namespace InnoTech.Webshop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<FilteredListDto> GetAll()
        {
            var filteredList = new FilteredListDto();
            filteredList.List = new List<ProductDto>
            {
                new ProductDto(){Id = 1, Name = "Bricks"},
                new ProductDto(){Id = 2, Name = "Cement"},
                new ProductDto(){Id = 3, Name = "Snurfs"},

            };
            return Ok(filteredList);
        }
    }
}