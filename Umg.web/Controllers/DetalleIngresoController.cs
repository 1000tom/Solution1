using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;
using Umg.Entidades.Compras;

namespace Umg.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleIngresosController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public DetalleIngresosController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/detalleIngresos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleIngreso>>> GetDetalleIngresos()
        {
            return await _context.DetalleIngresos.ToListAsync();
        }

        //get api/detalleIngreso/2
        [HttpGet("{iddetalleIngreso}")]

        public async Task<ActionResult<DetalleIngreso>> GetDetalleIngreso(int id)
        {
            var detalleIngreso = await _context.DetalleIngresos.FindAsync(id);


            if (detalleIngreso == null)
            {
                return NotFound();
            }
            return detalleIngreso;
        }
        //put api/detalleIngresos/2
        [HttpGet("iddetalleIngreso")]

        public async Task<IActionResult> PutDetalleIngreso(int id, DetalleIngreso detalleIngreso)
        {
            if (id != detalleIngreso.idDetalleIngreso)
            {
                return BadRequest();
            }
            _context.Entry(detalleIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!DetalleIngresoExists(id))
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
        
        //post api/detalleIngreso
        [HttpPost]
        public async Task<ActionResult<DetalleIngreso>> PostDetalleIngreso(DetalleIngreso detalleIngreso)
        {
            _context.DetalleIngresos.Add(detalleIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleIngreso", new { id = detalleIngreso.idDetalleIngreso }, detalleIngreso);
        }

        private bool DetalleIngresoExists(int id)
        {
            return _context.DetalleIngresos.Any(e => e.idDetalleIngreso == id);
        }
    }
}