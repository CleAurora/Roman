using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.Domains;
using Roman.Repositories;

namespace Roman.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TemasController : ControllerBase
    {
        TemaRepository temaRepository = new TemaRepository();

        [Authorize(Roles = "1")]
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(temaRepository.Listar());
        }
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Temas tema)
        {
            try
            {
                temaRepository.Cadastrar(tema);
                return Ok();
            }
            catch
            {

                return BadRequest();
            }
        }
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id,Temas tema)
        {
            try
            {
                tema.IdTema = id;
                temaRepository.Atualizar(tema);
                return Ok();
            }
            catch
            {

                return BadRequest();
            }
        }
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                temaRepository.Deletar(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}