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
    public class VentasController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public VentasController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        //get api/venta/2
        [HttpGet("{idventa}")]

        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);


            if (venta == null)
            {
                return NotFound();
            }
            return venta;
        }
        //put api/ventas/2
        [HttpGet("idventa")]

        public async Task<IActionResult> PutVenta(int id, Venta venta)
        {
            if (id != venta.idVenta)
            {
                return BadRequest();
            }
            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!VentaExists(id))
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
        
        //post api/venta
        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenta", new { id = venta.idVenta }, venta);
        }

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.idVenta == id);
        }
    }
}