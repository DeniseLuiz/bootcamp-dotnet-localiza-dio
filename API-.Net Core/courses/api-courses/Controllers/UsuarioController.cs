using api_courses.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_courses.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns></returns>
        /// 
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar.", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios.", Type = typeof(ValidarCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno. Contate a equipe responsável.", Type = typeof(ErroGenericoViewModel) )]
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput regitroViewModelInput)
        {
            return Created("", regitroViewModelInput);
        }
    }
}
