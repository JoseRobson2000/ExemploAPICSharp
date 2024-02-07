using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExemploAPISharp.Model;

namespace ExemploAPISharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa GetPessoa()
        {
            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "José Robson";
            vPessoa.NomeroCelular = "(18) 12345-6789";

            return vPessoa;

        }

    }
}
