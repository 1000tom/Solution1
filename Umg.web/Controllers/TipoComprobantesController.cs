using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;

namespace Umg.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoComprobanteController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public TipoComprobanteController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoComprobante>>> GetTipoComprobantes()
        {
            return await _context.TipoComprobantes.ToListAsync();
        }

        //get api/c2
        [HttpGet("{idTipoComprobante}")]

        public async Task<ActionResult<TipoComprobante>> GetTipoComprobantes(int id)
        {
            var tipoComprobante = await _context.TipoComprobantes.FindAsync(id);


            if (tipoComprobante == null)
            {
                return NotFound();
            }
            return tipoComprobante;
        }
        //put api/2
        [HttpGet("idTipoComprobante")]

        public async Task<IActionResult> PutTipoComprobante(int id, TipoComprobante tipoComprobante)
        {
            if (id != tipoComprobante.idTipoComprobante)
            {
                return BadRequest();
            }
            _context.Entry(tipoComprobante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!TipoComprobanteExists(id))
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

        private bool TipoComprobanteExists(int id)
        {
            throw new NotImplementedException();
        }

        //post api/
        [HttpPost]
        public async Task<ActionResult<TipoComprobante>> PostTipoComprobante(TipoComprobante tipoComprobante)
        {
            _context.TipoComprobantes.Add(tipoComprobante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoComprobante", new { id = tipoComprobante.idTipoComprobante }, tipoComprobante);
        }

    }
}