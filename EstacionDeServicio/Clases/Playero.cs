using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    class Playero : Persona
    {
        public Playero(int nroLegajo, string nombre, string apellido, string nroDocumento, string email) 
        {
            NroLegajo = nroLegajo;
            Nombre = nombre;
            Apellido = apellido;
            NroDocumento = nroDocumento;
            Email = email;
        }

    }
}
