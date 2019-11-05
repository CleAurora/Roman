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
    [ApiController]
    [Produces("application/json")]
    public class ProjetosController : ControllerBase
    {
        ProjetoRepository projetoRepository = new ProjetoRepository();

        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(projetoRepository.Listar());
        }
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Projetos projeto)
        {
            projetoRepository.Cadastrar(projeto);
            return Ok();
        }
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id,Projetos projeto)
        {
            projeto.IdProjeto = id;
            projetoRepository.Atualizar(projeto);
            return Ok();
        }
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            projetoRepository.Deletar(id);
            return Ok();
        }
    }
}