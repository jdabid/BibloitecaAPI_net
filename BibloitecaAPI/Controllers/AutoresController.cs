using BibloitecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace BibloitecaAPI.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Autor> Get() 
        {
            return new List<Autor>
            {
                new Autor{ID = 1, Nombre = "Rafael"},
                new Autor{ID = 2, Nombre = "Leandra"}
            };
        }
    }
}
