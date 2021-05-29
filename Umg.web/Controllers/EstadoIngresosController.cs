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
    public class EstadoIngresosController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public EstadoIngresosController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/estadoIngresos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoIngreso>>> GetEstadoIngresos()
        {
            return await _context.EstadoIngresos.ToListAsync();
        }

        //get api/estadoIngreso/2
        [HttpGet("{idestadoIngreso}")]

        public async Task<ActionResult<EstadoIngreso>> GetEstadoIngreso(int id)
        {
            var estadoIngreso = await _context.EstadoIngresos.FindAsync(id);


            if (estadoIngreso == null)
            {
                return NotFound();
            }
            return estadoIngreso;
        }
        //put api/estadoIngresos/2
        [HttpGet("idestadoIngreso")]

        public async Task<IActionResult> PutEstadoIngreso(int id, EstadoIngreso estadoIngreso)
        {
            if (id != estadoIngreso.idEstadoIngreso)
            {
                return BadRequest();
            }
            _context.Entry(estadoIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!EstadoIngresoExists(id))
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
        
        //post api/estadoIngreso
        [HttpPost]
        public async Task<ActionResult<EstadoIngreso>> PostEstadoIngreso(EstadoIngreso estadoIngreso)
        {
            _context.EstadoIngresos.Add(estadoIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoIngreso", new { id = estadoIngreso.idEstadoIngreso }, estadoIngreso);
        }

        private bool EstadoIngresoExists(int id)
        {
            return _context.EstadoIngresos.Any(e => e.idEstadoIngreso == id);
        }
    }
}