using InnoTech.Webshop.WebApi.Dtos.Auth;
using Microsoft.AspNetCore.Mvc;

namespace InnoTech.Webshop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<TokenDto> Login([FromBody] LoginDto dto)
        {
            //Peters magic code to Accept Login Information!!!
            if ("ljuul".Equals(dto.Username) && "123".Equals(dto.Password))
            {
                //Peters magic code to get token
                var token = new TokenDto { JwtToken = "jwttoken123" };
                return Ok(token);
            }
            return Unauthorized();
        }
    }
}