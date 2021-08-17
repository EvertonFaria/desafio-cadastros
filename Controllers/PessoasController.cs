using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cadastros.Domain.Models;
using Cadastros.Domain.Services;

namespace Cadastros.Controllers {
    [Route("v1/[controller]")]
    public class PessoasController : Controller {
        private readonly IPessoasService _pessoasService;
        public PessoasController(IPessoasService pessoasService) {
            _pessoasService = pessoasService;
        }
        
        [HttpGet]
        [Route("pessoas")]
        public async Task<IEnumerable<Pessoas>> GetAllAsync() {
            var pessoas = await _pessoasService.ListAsync();
            return pessoas;            
        }
    }
}