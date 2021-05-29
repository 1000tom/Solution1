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
    public class ComprobantesController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public ComprobantesController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comprobante>>> GetComprobantes()
        {
            return await _context.Comprobantes.ToListAsync();
        }

        //get api/2
        [HttpGet("{idComprobantes}")]

        public async Task<ActionResult<Comprobante>> GetComprobantes(int id)
        {
            var comprobante = await _context.Comprobantes.FindAsync(id);


            if (comprobante == null)
            {
                return NotFound();
            }
            return comprobante;
        }
        //put api/2
        [HttpGet("idComprobante")]

        public async Task<IActionResult> PutComprobante(int id, Comprobante comprobante)
        {
            if (id != comprobante.idComprobante)
            {
                return BadRequest();
            }
            _context.Entry(comprobante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!ComprobanteExists(id))
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

        private bool ComprobanteExists(int id)
        {
            throw new NotImplementedException();
        }

        //post api/
        [HttpPost]
        public async Task<ActionResult<Comprobante>> PostComprobante(Comprobante comprobante)
        {
            _context.Comprobantes.Add(comprobante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComprobante", new { id = comprobante.idComprobante }, comprobante);
        }

       
    }
}