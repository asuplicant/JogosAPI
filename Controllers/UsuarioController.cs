using JogosAPI.Domains;
using JogosAPI.Interfaces;
using JogosAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JogosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _UsuarioRepository;

        public UsuarioController(IUsuarioRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }

        //-----------------------------------------------------
        // Listar Usuário
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Usuario> listaDeUsuario = _UsuarioRepository.Listar();

                return Ok(listaDeUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //-----------------------------------------------------
        // Cadastrar Usuário
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                _UsuarioRepository.Cadastrar(novoUsuario);

                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //-----------------------------------------------------
        // Atualizar Usuário
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Usuario usuario)
        {
            try
            {
                _UsuarioRepository.Atualizar(id, usuario);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //-----------------------------------------------------
        // Deletar Jogo
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _UsuarioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
