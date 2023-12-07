using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia.interfaces
{
    public interface IGuardar<T>
    {
        string RutaDeArchivos { get; set; }
        bool Guardar();
        T Leer();
    }
}
