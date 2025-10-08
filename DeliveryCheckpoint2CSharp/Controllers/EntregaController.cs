using DeliveryCheckpoint2CSharp.Data;
using DeliveryCheckpoint2CSharp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryCheckpoint2CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntregaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntregaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrega>>> GetEntregas()
        {
            return await _context.Entregas
                .Include(e => e.Pedido)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Entrega>> GetEntrega(int id)
        {
            var entrega = await _context.Entregas
                .Include(e => e.Pedido)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (entrega == null)
                return NotFound();

            return entrega;
        }

        [HttpPost]
        public async Task<ActionResult<Entrega>> PostEntrega(Entrega entrega)
        {
            _context.Entregas.Add(entrega);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEntrega), new { id = entrega.Id }, entrega);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntrega(int id, Entrega entrega)
        {
            if (id != entrega.Id)
                return BadRequest();

            _context.Entry(entrega).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrega(int id)
        {
            var entrega = await _context.Entregas.FindAsync(id);
            if (entrega == null)
                return NotFound();

            _context.Entregas.Remove(entrega);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
