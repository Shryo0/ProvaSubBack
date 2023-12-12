using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("API/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDataContext _ctx;
        public UsuarioController(AppDataContext context)
        {
            _ctx = context;
        }
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar(){
        
                try{
            List<Usuario> usuarios = _ctx.Usuarios.Include(x => x.Imc).ToList();
            return usuarios.Count == 0 ? NotFound() : Ok(usuarios);
        }catch (Exception e){
            return BadRequest(e.Message);
        }
    }
         [HttpPost]
         [Route("cadastrar")]
         public IActionResult Cadastrar([FromBody] Usuario usuario){
            _ctx.Usuarios.Add(usuario);
            _ctx.SaveChanges();
            return Created("", usuario);
         }
       
    }
}