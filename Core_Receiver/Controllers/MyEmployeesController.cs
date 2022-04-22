#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core_Receiver.Models;

namespace Core_Receiver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyEmployeesController : ControllerBase
    {
        private readonly ReceiverContext _context;

        public MyEmployeesController(ReceiverContext context)
        {
            _context = context;
        }

        // GET: api/MyEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyEmployee>>> GetMyEmployees()
        {
            return await _context.MyEmployees.ToListAsync();
        }

        // GET: api/MyEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyEmployee>> GetMyEmployee(int id)
        {
            var myEmployee = await _context.MyEmployees.FindAsync(id);

            if (myEmployee == null)
            {
                return NotFound();
            }

            return myEmployee;
        }

        // PUT: api/MyEmployees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyEmployee(int id, MyEmployee myEmployee)
        {
            if (id != myEmployee.EmpNo)
            {
                return BadRequest();
            }

            _context.Entry(myEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyEmployeeExists(id))
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

        // POST: api/MyEmployees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyEmployee>> PostMyEmployee(MyEmployee myEmployee)
        {
            _context.MyEmployees.Add(myEmployee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MyEmployeeExists(myEmployee.EmpNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMyEmployee", new { id = myEmployee.EmpNo }, myEmployee);
        }

        // DELETE: api/MyEmployees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyEmployee(int id)
        {
            var myEmployee = await _context.MyEmployees.FindAsync(id);
            if (myEmployee == null)
            {
                return NotFound();
            }

            _context.MyEmployees.Remove(myEmployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MyEmployeeExists(int id)
        {
            return _context.MyEmployees.Any(e => e.EmpNo == id);
        }
    }
}
