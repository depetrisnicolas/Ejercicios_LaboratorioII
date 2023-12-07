using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string? message) : base(message)
        {

        }
    }
}
