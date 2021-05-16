using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_courses.Models.Usuarios
{
    public class LoginViewModelInput
    {
        public string Login { get; set; }

        public string Senha { get; set; }
    }
}
