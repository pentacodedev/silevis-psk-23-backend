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
    public class TicketController : ControllerBase
    {
        private HackathonDbContext _context;

        public TicketController(HackathonDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "{id}")]
        public async Task<ActionResult<NewDateTicket>> GetTicketByEmail(int id)
        {
            var result = await _context.NewDateTickets.FirstOrDefaultAsync(x => x.Id == id);
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
