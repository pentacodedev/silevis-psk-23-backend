using HackathonApi.Database;
using HackathonApi.DTOs;
using HackathonApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Nelibur.ObjectMapper;
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
            var entity =  _context.Internships.FirstOrDefault(x => x.Id == id);
            if (entity == null) return NotFound();
            return InternshipDTO.FromEntity(entity);
        }

        [HttpGet("managed-by/{email}")]
        public ActionResult<IEnumerable<InternshipDTO>> GetInternshipsForManager([FromRoute] string email)
        {
            var entities =  _context.Internships.Where(x => x.ManagerEmail == email).ToList();
            return Ok(entities.Select(InternshipDTO.FromEntity));
        }


        [HttpGet("for-student/{email}")]
        public ActionResult<IEnumerable<InternshipDTO>> GetInternshipsForStudent([FromRoute] string email)
        {
            var entities =  _context.Internships.Where(x => x.StudentEmail == email).ToList();
            return Ok(entities.Select(InternshipDTO.FromEntity));
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
            var result =  _context.Internships.FirstOrDefault(x => x.Id == id);
            if (result == null) return BadRequest();
            result.IsSigned = true;
            await _context.SaveChangesAsync();
            return Ok(result);
        }

        [HttpPost("reject-internship/{id}")]
        public async Task<ActionResult> RejectInternship(int id)
        {
            var result = await _context.Internships.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return BadRequest();
            result.IsSigned = false;
            await _context.SaveChangesAsync();
            return Ok(result);
        }

    }
}
