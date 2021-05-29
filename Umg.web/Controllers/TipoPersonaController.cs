using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;
using Umg.Entidades.Usuarios;

namespace Umg.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPersonasController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public TipoPersonasController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/tipoPersonas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPersona>>> GetTipoPersonas()
        {
            return await _context.TipoPersonas.ToListAsync();
        }

        //get api/tipoPersona/2
        [HttpGet("{idtipoPersona}")]

        public async Task<ActionResult<TipoPersona>> GetTipoPersona(int id)
        {
            var tipoPersona = await _context.TipoPersonas.FindAsync(id);


            if (tipoPersona == null)
            {
                return NotFound();
            }
            return tipoPersona;
        }
        //put api/tipoPersonas/2
        [HttpGet("idtipoPersona")]

        public async Task<IActionResult> PutTipoPersona(int id, TipoPersona tipoPersona)
        {
            if (id != tipoPersona.idTipoPersona)
            {
                return BadRequest();
            }
            _context.Entry(tipoPersona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!TipoPersonaExists(id))
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
        
        //post api/tipoPersona
        [HttpPost]
        public async Task<ActionResult<TipoPersona>> PostTipoPersona(TipoPersona tipoPersona)
        {
            _context.TipoPersonas.Add(tipoPersona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoPersona", new { id = tipoPersona.idTipoPersona }, tipoPersona);
        }

        private bool TipoPersonaExists(int id)
        {
            return _context.TipoPersonas.Any(e => e.idTipoPersona == id);
        }
    }
}