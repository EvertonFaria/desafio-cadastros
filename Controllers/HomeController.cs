using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cadastros.Models;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Cadastros.Services;
using Cadastros.Repositories;

namespace Shop.Controllers {
    [Route("v1/account")]
    public class HomeController : Controller {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model) {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(
                    new { 
                        message = "Usuário ou senha inválidos" 
                    }
                );

            var token = TokenService.GenerateToken(user);
            user.Password = "";

            return new {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";

        [HttpGet]
        [Route("consultaCadastro")]
        [Authorize]
        public async Task<ActionResult<dynamic>> ConsultarCadastro([FromBody]Cadastro model) {
            var Cadastro = CadastrosRepository.Get();

            return new {
                Cadastro = Cadastro
            };
        }
    }
}