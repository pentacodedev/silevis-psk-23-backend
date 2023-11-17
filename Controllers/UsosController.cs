using HackathonApi.Database;
using HackathonApi.DTOs;
using HackathonApi.Entities;
using HackathonApi.Services;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace HackathonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsosController : ControllerBase
    {
        private HackathonDbContext _context;
        private UsosService _usosService;

        public UsosController(HackathonDbContext context, UsosService usosService)
        {
            _context = context;
            _usosService = usosService;
        }

        [HttpGet(Name = "{email}")]
        public async Task<ActionResult<User>> GetUserByEmail(string email)
        {
            var user = await _usosService.GetUserByEmailAsync(email);
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}
