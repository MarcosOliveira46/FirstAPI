using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FilmeController : ControllerBase
    {
        private static List<Filme> _filmes = new List<Filme>();
        private static int Id = 0;
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody]Filme filme)
        {
            filme.Id = Id++;
            _filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            return CreatedAtAction(nameof(ExibirFilme), new{Id = filme.Id},filme) ;
        }

        [HttpGet]
        public IActionResult ExibirFilme(){
           return Ok(_filmes);
        }

        [HttpGet("{id}")]
        public IActionResult ExibirFilme(int id){
            Filme filme = _filmes.Where(x=>x.Id == id).First();
            if( filme != null){
                return Ok(filme);
            }
            return NotFound();
        }
    }
}