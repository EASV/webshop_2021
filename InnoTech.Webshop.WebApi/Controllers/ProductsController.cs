using System;
using System.Collections.Generic;
using InnoTech.Webshop.WebApi.Dtos.Products;
using InnoTech.Webshop2021.Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InnoTech.Webshop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public ActionResult<FilteredListDto> GetAll()
        {
            try
            {
                return Ok(_productService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            
        }
    }
}