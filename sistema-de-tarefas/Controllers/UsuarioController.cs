using Microsoft.AspNetCore.Mvc;
using SistemasDeTarefas.Models;

namespace SistemasDeTarefas.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}

