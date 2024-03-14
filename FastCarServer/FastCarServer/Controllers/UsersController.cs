using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastCarServer.Context;
using FastCarServer.Data.User;
using Microsoft.AspNetCore.Identity;
using FastCarServer.View;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using FastCarServer.Helpers;

namespace FastCarServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly AppDbContext _context;

        public UsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, AppDBContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost("sign-up")]
        public async Task SignUp([FromBody] SignUpViewModel model)
        {
            var existingEmail = await _userManager.FindByEmailAsync(model.Email);
            var phoneNumber = await _userManager.FindByNameAsync("asd");
            if (existingEmail != null)
            {
                Response.ContentType = "application/json";
                Response.StatusCode = 409;
                await Response.WriteAsync("Email existing");
                return;
            }

            var user = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Username
            };
            await _userManager.CreateAsync(user, model.Password);

            var person = new User();
            person.IdentityUser = user;
            person.Verification = Enums.VerificationType.None;

            await _context.Users.AddAsync(person);
            await _context.SaveChangesAsync(default);

            await Token(model.Username);
        }

        [HttpPost("sign-in")]
        public async Task SignIn([FromBody] SignInViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

            if (!result.Succeeded)
            {
                Response.StatusCode = 401;
                Response.ContentType = "application/json";
                await Response.WriteAsync("Invalid Username or Password");
                return;
            }

            await Token(model.Username);
        }

        

        private async Task Token(string email)
        {
            var identity = GetIdentity(email);
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
            issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
            notBefore: now,
            claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name,
            };

            Response.ContentType = "application/json";
            await Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
        }


        private ClaimsIdentity GetIdentity(string login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login)
            };

            ClaimsIdentity claimIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);

            return claimIdentity;
        }
    }
}
