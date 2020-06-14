using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public abstract class Persona
    {
        public abstract int IdPersona { get; set; }
        public abstract int NroLegajo { get; set; }
        public abstract String Nombre { get; set; }
        public abstract String Apellido { get; set; }
        public abstract String NroDocumento { get; set; }
        public abstract String Email { get; set; }
        
    }
}
