using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace API.Controllers
{
    [ApiController]
    [Route("API/imc")]
    public class ImcController : ControllerBase
    {
        private readonly AppDataContext _ctx;
        public ImcController(AppDataContext context)
        {
            _ctx = context;
        }
   /*   [HttpGet]
    [Route("listar")]
    public IActionResult Listar(){
            
            List<Imc> imcs = _ctx.Imcs.ToList();
            return imcs.Count == 0 ? NotFound() : Ok(imcs);
    } */
         [HttpPost]
         [Route("cadastrar")]
         public IActionResult Cadastrar([FromBody] Imc imc){
             CalcularImc(imc); 
            _ctx.Imcs.Add(imc);
            _ctx.SaveChanges();
            return Created("", imc);
         }
         
           [NonAction]
         public float CalcularImc(Imc imc){
            //?
            float dgc = imc.Peso / imc.Altura;
            imc.Imcc = dgc*dgc;
            return imc.Imcc;
        }
        public String CalClassificacao(Imc imc){
            if(imc.Imcc < 18.5){
                imc.Classificacao = "MAGREZA";
                return imc.Classificacao;
            }else if(imc.Imcc > 18.5 && imc.Imcc < 24.9){
                imc.Classificacao = "NORMAL";
            return imc.Classificacao;
        } return imc.Classificacao;
        }
    }
}
    