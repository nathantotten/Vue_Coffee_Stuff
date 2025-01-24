using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coffee_webapi.Models;
using coffee_webapi.Models.CoffeeMachines;

namespace coffee_webapi.Controllers.CoffeeMachines
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeMachinesController : ControllerBase
    {
        private readonly CoffeeApiContext _context;

        public CoffeeMachinesController(CoffeeApiContext context)
        {
            _context = context;
        }

        // GET: api/CoffeeMachines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoffeeMachine>>> GetCoffeeMachines()
        {
            return await _context.CoffeeMachines.ToListAsync();
        }

        // GET: api/CoffeeMachines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CoffeeMachine>> GetCoffeeMachine(int id)
        {
            var coffeeMachine = await _context.CoffeeMachines.FindAsync(id);

            if (coffeeMachine == null)
            {
                return NotFound();
            }

            return coffeeMachine;
        }

        // GET: api/CoffeeMachines/manufacturer/Rancilio
        [HttpGet("manufacturer/{manufacturer}")]
        public async Task<ActionResult<IEnumerable<CoffeeMachine>>> GetCoffeeMachineByManufacturer(string manufacturer)
        {
            return await _context.CoffeeMachines
                .Where(m => m.Manufacturer.Contains(manufacturer))
                .ToListAsync();
        }
        
        // GET: api/CoffeeMachines/model/GS3
        [HttpGet("model/{model}")]
        public async Task<ActionResult<IEnumerable<CoffeeMachine>>> GetCoffeeMachineByModel(string model)
        {
            return await _context.CoffeeMachines
                .Where(m => m.Model.Contains(model))
                .ToListAsync();
        }
        
        // GET: api/CoffeeMachines
        [HttpGet("filter/")]
        public async Task<ActionResult<IEnumerable<CoffeeMachine>>> GetCoffeeMachines([FromQuery] string manufacturer, [FromQuery] string model)
        {
            var query = _context.CoffeeMachines.AsQueryable();

            if (!string.IsNullOrEmpty(manufacturer))
            {
                query = query.Where(m => m.Manufacturer.Contains(manufacturer));
            }

            if (!string.IsNullOrEmpty(model))
            {
                query = query.Where(m => m.Model.Contains(model));
            }

            return await query.ToListAsync();
        }

        // PUT: api/CoffeeMachines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoffeeMachine(int id, CoffeeMachine coffeeMachine)
        {
            if (id != coffeeMachine.Id)
            {
                return BadRequest();
            }

            _context.Entry(coffeeMachine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoffeeMachineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CoffeeMachines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CoffeeMachine>> PostCoffeeMachine(CoffeeMachine coffeeMachine)
        {
            _context.CoffeeMachines.Add(coffeeMachine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoffeeMachine", new { id = coffeeMachine.Id }, coffeeMachine);
        }

        // DELETE: api/CoffeeMachines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoffeeMachine(int id)
        {
            var coffeeMachine = await _context.CoffeeMachines.FindAsync(id);
            if (coffeeMachine == null)
            {
                return NotFound();
            }

            _context.CoffeeMachines.Remove(coffeeMachine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CoffeeMachineExists(int id)
        {
            return _context.CoffeeMachines.Any(e => e.Id == id);
        }
    }
}
