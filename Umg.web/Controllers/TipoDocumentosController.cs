using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;

namespace Umg.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentosController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public TipoDocumentosController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDocumento>>> GetTipoDocumentos()
        {
            return await _context.TipoDocumentos.ToListAsync();
        }

        //get api/2
        [HttpGet("{idTipoDocumento}")]

        public async Task<ActionResult<TipoDocumento>> GetTipoDocumentos(int id)
        {
            var tipoDocumento = await _context.TipoDocumentos.FindAsync(id);


            if (tipoDocumento == null)
            {
                return NotFound();
            }
            return tipoDocumento;
        }
        //put api/2
        [HttpGet("idTipoDocumento")]

        public async Task<IActionResult> PutTipoDocumento(int id, TipoDocumento tipoDocumento)
        {
            if (id != tipoDocumento.idTipoDocumento)
            {
                return BadRequest();
            }
            _context.Entry(tipoDocumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!TipoDocumentoExists(id))
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

        //post api/
        [HttpPost]
        public async Task<ActionResult<TipoDocumento>> PostTipoDocumento(TipoDocumento tipoDocumento)
        {
            _context.TipoDocumentos.Add(tipoDocumento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoDocumento", new { id = tipoDocumento.idTipoDocumento }, tipoDocumento);
        }

        private bool TipoDocumentoExists(int id)
        {
            return _context.TipoDocumentos.Any(e => e.idTipoDocumento == id);
        }
    }
}