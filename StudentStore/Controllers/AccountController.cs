using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StudentStore.BLL.Models;
using StudentStore.BLL.Services.Interfaces;

namespace StudentStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService, LinkGenerator linkGenerator)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Post(RegisterModel model)
        {
            try
            {
                var result = await _userService.RegisterUserAsync(model);
                if (result.Succeeded)
                {
                    return Ok(result.Result);
                }
                else
                    return StatusCode(StatusCodes.Status500InternalServerError, result.Errors);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong on the server");
            }
        }

        [HttpPost]
        [Route("LoginJwt")]
        public async Task<IActionResult> LoginJwt(LoginModel model)
        {
            try
            {
                string token = await _userService.LoginJwtAsync(model);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong on the server");
            }
        }
    }
}