using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_courses.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "Campo login obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo e-mail obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo senha obrigatório")]
        public string Senha { get; set; }
    }
}
