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
    public class UsuariosController : ControllerBase
    {
        UsuarioRepository usuariosRepository = new UsuarioRepository();

        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(usuariosRepository.Listar());
        }
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Usuarios usuario)
        {
            try
            {
                usuariosRepository.Cadastrar(usuario);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuarios usuario)
        {
            try
            {
                usuario.IdUsuario = id;
                usuariosRepository.Atualizar(usuario);
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
                usuariosRepository.Deletar(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}