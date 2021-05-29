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
    public class ArticuloController : ControllerBase
    {

        private readonly DbContextSistema _context;

        public ArticuloController(DbContextSistema context)
        {
            _context = context;
        }
        //Get api/articulos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articulo>>> GetArticulos()
        {
            return await _context.Articulos.ToListAsync();
        }

        //get api/articulos/2
        [HttpGet("{idArticulo}")]

        public async Task<ActionResult<Articulo>> GetArticulos(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);


            if (articulo == null)
            {
                return NotFound();
            }
            return articulo;
        }
        //put api/articulo/2
        [HttpGet("idarticulo")]

        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.idArticulo)
            {
                return BadRequest();
            }
            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!ArticuloExists(id))
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

        private bool ArticuloExists(int id)
        {
            throw new NotImplementedException();
        }

        //post api/articulo
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = articulo.idArticulo }, articulo);
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.idcategoria == id);
        }
    }
}