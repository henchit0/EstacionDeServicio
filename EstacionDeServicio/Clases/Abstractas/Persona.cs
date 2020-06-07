using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public abstract class Persona
    {
        protected int NroLegajo { get; set; }
        protected String Nombre { get; set; }
        protected String Apellido { get; set; }
        protected String NroDocumento { get; set; }
        protected String Email { get; set; }        
    }
}
