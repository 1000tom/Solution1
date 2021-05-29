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
    public class DocumentosController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public DocumentosController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Documento>>> GetDocumentos()
        {
            return await _context.Documentos.ToListAsync();
        }

        //get api/2
        [HttpGet("{idDocumentos}")]

        public async Task<ActionResult<Documento>> GetDocumentos(int id)
        {
            var documento = await _context.Documentos.FindAsync(id);


            if (documento == null)
            {
                return NotFound();
            }
            return documento;
        }
        //put api/2
        [HttpGet("idDocumento")]

        public async Task<IActionResult> PutDocumento(int id, Documento documento)
        {
            if (id != documento.idDocumento)
            {
                return BadRequest();
            }
            _context.Entry(documento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!DocumentoExists(id))
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

        private bool DocumentoExists(int id)
        {
            throw new NotImplementedException();
        }

        //post api/
        [HttpPost]
        public async Task<ActionResult<Documento>> PostDocumentos(Documento documento)
        {
            _context.Documentos.Add(documento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocumento", new { id = documento.idDocumento }, documento);
        }

       
    }
}