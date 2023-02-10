using Ecommerce.Core.Interfaces;
using Ecommerce.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        private readonly ITokenService _tokenService;

        public AccountController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        [HttpPost(nameof(Login))]
        public async Task<ActionResult<UserDto>> Login()
        {
            //var user = await _userManager.FindByEmailAsync(loginDto.Email);
            //if (user == null) return Unauthorized();

            //var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            //if (!result.Succeeded) return Unauthorized(new APIResponce(401));
            return new UserDto
            {
                Emial = "nand",
                DisplayName = "Nandan",
                Token = _tokenService.CreateToken()
            };
        }
    }
}
