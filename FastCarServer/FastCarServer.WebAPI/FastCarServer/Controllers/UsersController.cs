using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastCarServer.Core.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Text;
using System.Security.Cryptography;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using FastCarServer.WebAPI.Helpers;
using FastCarServer.Application.Common.DTO;
using FastCarServer.Infrastructure.Data;
using FastCarServer.Application.Common.Views;

namespace FastCarServer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public UsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost("check-number")]
        public async Task<IActionResult> CheckNumber([FromBody] LoginViewModel model)
        {
            var existingPhoneNumber = await _userManager.FindByNameAsync(model.PhoneNumber);

            if (existingPhoneNumber != null) return BadRequest();
            else return Ok();
        }

        [HttpPost("login")]
        public async Task<string> SignUp([FromBody] LoginViewModel model)
        {
            Random random = new Random();
            int verificationCode = random.Next(1000, 10000);
            TwilioClient.Init("AC79274582fc4814ef9bae241215dd7077", "bf31c5a92e0b0a974e968a4d06b770a5");
            var message = MessageResource.Create(
                new PhoneNumber(model.PhoneNumber),
                from: new PhoneNumber("+19417875578"),
                body: $"Verification Code: {verificationCode}"
            );

            return verificationCode.ToString();
        }

        /*[HttpPost("verify")]
        public async Task<IActionResult> VerifyPhoneNumber([FromBody] LoginViewModel model)
        {
            *//*var existingPhoneNumber = await _userManager.FindByNameAsync(model.PhoneNumber);
            string token = "";
            if (existingPhoneNumber == null)
            {
                var user = new IdentityUser
                {
                    PhoneNumber = model.PhoneNumber,
                    PhoneNumberConfirmed = true,
                    UserName = model.PhoneNumber
                };
                await _userManager.CreateAsync(user);

                var person = new ApplicationUser();
                person.IdentityUser = user;
                person.Verification = VerificationType.None;

                await _context.Users.AddAsync(person);
                await _context.SaveChangesAsync(default);

                token = await Token(user);
                return Ok(new { token });
            }

            token = await Token(existingPhoneNumber);
            return Ok(new { token });*//*
        }*/

        /*[HttpGet]
        [Route("info")]
        public async Task<UserDto> CurrentUser()
        {
            *//*var sss = User.ToUserInfo().Username;
            var user = await _context.Users
                .Include(x => x.IdentityUser)
                .SingleOrDefaultAsync(x => x.IdentityUser.UserName == User.ToUserInfo().Username);

            return Mapper.Map<User, UserDto>(user);*//*
        }*/

        private async Task<string> Token(IdentityUser user)
        {
            var securityKey = AuthOptions.GetSymmetricSecurityKey();
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
            };

            var token = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                claims: claims,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
