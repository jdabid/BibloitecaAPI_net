using BibloitecaAPI.Datos;
using BibloitecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibloitecaAPI.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController: ControllerBase
    {
        private readonly AplicationDbContext context;

        public LibrosController(AplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Libro>> Get()
        {
            return await context.Libros.ToListAsync();
        }

        [HttpGet("{id:int}")] //api/libros/id
        public async Task<ActionResult<Libro>> Get(int id)
        {
            var libro = await context.Libros
                .Include(x => x.Autor)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (libro is null)
            {
                return NotFound();
            }
            return Ok(libro);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Libro libro)
        {
            context.Add(libro);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] //api/libros/id
        public async Task<ActionResult> Put(int id, Libro libro)
        {
            if (id != libro.Id)
            {
                return BadRequest("Los id deben coincidir");
            }
            context.Update(libro);
            await context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var libro = await context.Libros.FirstOrDefaultAsync(x => x.Id == id);
            if (libro is null)
            {
                return NotFound();
            }
            context.Remove(libro);
            await context.SaveChangesAsync();
            return Ok(libro);
        }
    }
}
