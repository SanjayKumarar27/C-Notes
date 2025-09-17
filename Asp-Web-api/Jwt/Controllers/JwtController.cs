using https_Codefirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;

namespace https_Codefirst.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class JwtController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserDbContext _context;

        [HttpPost("Register")]
        public IActionResult Register(UserDto userdto)
        {
            var emailcount = _context.Users.Count(u => u.Email == userdto.Email);
            if (emailcount > 0)
            {
                ModelState.AddModelError("Email ", "This Email address is alredy used");
                return BadRequest(ModelState);
            }

            var passwordhasher = new PasswordHasher<User>();
            var hashedPassword = passwordhasher.HashPassword(new User(), userdto.Password);


            User user = new User()
            { 
                FirstName = userdto.FirstName,
                LastName = userdto.LastName,
                Email = userdto.Email,
                phone=userdto.phone ?? "",
                Password = hashedPassword,
                Address=userdto.Address,
                Role="Client",
                CreatedAt=DateTime.Now
            };
            _context.Users.Add(user);
            _context.SaveChanges();

               
            var jwt=CreateJwtToken(user);
            UserProfileDto profile = new UserProfileDto()
            {
                Id=user.Id,
                FirstName=user.FirstName,
                LastName=user.LastName,
                Email=user.Email,
                phone=user.phone,
                Address=user.Address,
                Role =user.Role,
                CreatedAt=user.CreatedAt
            };
            //var profil = new 
            //{
            //    Id = user.Id,
            //    FirstName = user.FirstName,
            //    LastName = user.LastName,
            //    Email = user.Email,
            //    phone = user.phone,
            //    Address = user.Address,
            //    Role = user.Role,
            //    CreatedAt = user.CreatedAt
            //}; Not good for multiple users


            var response = new
            {
                Token = jwt,
                User = profile


            };
            return Ok(response);
          

        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody]LoginDto client)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == client.Email);
            if (user==null)
            {
                ModelState.AddModelError("Email ", "Email address  Or password is Not valid");
                return BadRequest(ModelState);
            }

            var passwordhasher = new PasswordHasher<User>();
            var result = passwordhasher.VerifyHashedPassword(new Models.User(), user.Password, client.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                ModelState.AddModelError("Password ", "Wrong Password");
                return BadRequest(ModelState);
            }

            var jwt=CreateJwtToken(user);
            UserProfileDto profile = new UserProfileDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                phone = user.phone,
                Address = user.Address,
                Role = user.Role,
                CreatedAt = user.CreatedAt
            };

            var response = new
            {
                Token = jwt,
                User = profile
            };
            return Ok(response);

        }
        //[HttpPost("Login")]
        //public IActionResult Login(string email,string password)
        //{
        //    var user = _context.Users.FirstOrDefault(u => u.Email == email);
        //    if (user==null)
        //    {
        //        ModelState.AddModelError("Email ", "Email address  Or password is Not valid");
        //        return BadRequest(ModelState);
        //    }

        //    var passwordhasher = new PasswordHasher<User>();
        //    var result = passwordhasher.VerifyHashedPassword(new Models.User(), user.Password, password);
        //    if (result == PasswordVerificationResult.Failed)
        //    {
        //        ModelState.AddModelError("Password ", "Wrong Password");
        //        return BadRequest(ModelState);
        //    }

        //    var jwt=CreateJwtToken(user);
        //    UserProfileDto profile = new UserProfileDto()
        //    {
        //        Id = user.Id,
        //        FirstName = user.FirstName,
        //        LastName = user.LastName,
        //        Email = user.Email,
        //        phone = user.phone,
        //        Address = user.Address,
        //        Role = user.Role,
        //        CreatedAt = user.CreatedAt
        //    };

        //    var response = new
        //    {
        //        Token = jwt,
        //        User = profile
        //    };
        //    return Ok(response);

        //}
        public JwtController(IConfiguration configuration, UserDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpGet("TestToken")]//String to set path
        public IActionResult TestToken()
        {
            User user=new User() { Id = 2, Role = "Admin" };
            string jwt=CreateJwtToken(user);
            var response = new { JwtToken = jwt };
            return Ok(response);
        }

        private string CreateJwtToken(User user)
        {
            
            List<Claim> claims = new List<Claim>
            {
                new Claim("id"," "+user.Id),
                new Claim("role",user.Role)
            };

            string strkey = _configuration["JwtSettings:key"]!;

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(strkey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
               audience: _configuration["JwtSettings:Audience"],
               claims: claims,
               expires: DateTime.Now.AddDays(1),
               signingCredentials: creds
               );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }





    }
}
