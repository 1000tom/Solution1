using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;
using Umg.Entidades.Ventas;

namespace Umg.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoVentasController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public EstadoVentasController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/estadoVentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoVenta>>> GetEstadoVentas()
        {
            return await _context.EstadoVentas.ToListAsync();
        }

        //get api/estadoVenta/2
        [HttpGet("{idestadoVenta}")]

        public async Task<ActionResult<EstadoVenta>> GetEstadoVenta(int id)
        {
            var estadoVenta = await _context.EstadoVentas.FindAsync(id);


            if (estadoVenta == null)
            {
                return NotFound();
            }
            return estadoVenta;
        }
        //put api/estadoVentas/2
        [HttpGet("idestadoVenta")]

        public async Task<IActionResult> PutEstadoVenta(int id, EstadoVenta estadoVenta)
        {
            if (id != estadoVenta.idEstadoVenta)
            {
                return BadRequest();
            }
            _context.Entry(estadoVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!EstadoVentaExists(id))
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
        
        //post api/estadoVenta
        [HttpPost]
        public async Task<ActionResult<EstadoVenta>> PostEstadoVenta(EstadoVenta estadoVenta)
        {
            _context.EstadoVentas.Add(estadoVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoVenta", new { id = estadoVenta.idEstadoVenta }, estadoVenta);
        }

        private bool EstadoVentaExists(int id)
        {
            return _context.EstadoVentas.Any(e => e.idEstadoVenta == id);
        }
    }
}