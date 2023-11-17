using HackathonApi.Database;
using HackathonApi.DTOs;
using HackathonApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Data.Entity;

namespace HackathonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternshipsController : ControllerBase
    {
        private HackathonDbContext _context;

        public InternshipsController(HackathonDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<InternshipDTO>> GetInternshipById(int id)
        {
            var entity = await _context.Internships.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null) return NotFound();
            return InternshipDTO.FromEntity(entity);
        }

        [HttpGet("managed-by/{email}")]
        public async Task<ActionResult<IEnumerable<InternshipDTO>>> GetInternshipsForManager([FromRoute] string email)
        {
            var entities = _context.Internships.Where(x => x.ManagerEmail== email).Select(x => InternshipDTO.FromEntity(x));
            return await entities.ToListAsync();
        }


        [HttpGet("for-student/{email}")]
        public async Task<ActionResult<IEnumerable<InternshipDTO>>> GetInternshipsForStudent([FromRoute] string email)
        {
            var entities = _context.Internships.Where(x => x.StudentEmail == email).Select(x => InternshipDTO.FromEntity(x));
            return await entities.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostInternship([FromBody] InternshipDTO dto)
        {
            var entity = Internship.FromDTO(dto);
            if (entity == null) return BadRequest();
            _context.Internships.Add(entity);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("accept-internship/{id}")]
        public async Task<ActionResult> AcceptInternship(int id)
        {
            var result = await _context.Internships.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return BadRequest();
            result.IsSigned = true;
            await _context.SaveChangesAsync();
            return Ok(result);
        }

    }
}
