using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_courses.Models.Usuarios
{
    public class ValidarCampoViewModelOutput
    {
        public IEnumerable<string> Errors { get; private set; }

        public ValidarCampoViewModelOutput(IEnumerable<string> errors)
        {
            Errors = errors;
        }

    }
}
