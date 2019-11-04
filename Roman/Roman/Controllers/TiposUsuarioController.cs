using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.Repositories;

namespace Roman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        TipoUsuarioRepository tipoRepository = new TipoUsuarioRepository();
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(tipoRepository.Listar());
        }
    }
}