using HackathonApi.Database;
using HackathonApi.DTOs;
using HackathonApi.Entities;
using HackathonApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Reflection.Metadata.Ecma335;

namespace HackathonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewDateTicketsController : ControllerBase
    {
        private HackathonDbContext _context;

        public NewDateTicketsController(HackathonDbContext context)
        {
            _context = context;
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<NewDateTicket>> GetTicketByEmail([FromRoute] string email)
        {
            var result = await _context.NewDateTickets.FirstOrDefaultAsync(x => x.StudentEmail == email);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpPost("add-new-ticket")]
        public async Task<ActionResult<NewDateTicket>> AddNewDateTicket([FromBody] NewDateTicketDTO newDateTicketDTO)
        {
            var newDateTicket = NewDateTicket.FromDTO(newDateTicketDTO);
            if (newDateTicket == null)
            {
                return BadRequest();
            }
            var result = await _context.NewDateTickets.AddAsync(newDateTicket);
            await _context.SaveChangesAsync();
            return Ok(result);
        }

    }
}
