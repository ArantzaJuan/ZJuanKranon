using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
 
    public class apiController : Controller
    {
        [HttpGet("GetAutor")]
        public IActionResult GetAutor(string Autor)
        {

            ML.Result result = BL.Libro.GetAutor(Autor);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("GetTitulo")]
        public IActionResult GetATitulo(string TItulo)
        {

            ML.Result result = BL.Libro.GetTitulo(TItulo);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("GetTitulo")]
        public IActionResult GetEditorial(string Editorial)
        {

            ML.Result result = BL.Libro.GetEditorial(Editorial);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("Add")]
        public IActionResult Post([FromBody] ML.Libro libro)
        {

            ML.Result result = BL.Libro.AddLibro(libro);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
