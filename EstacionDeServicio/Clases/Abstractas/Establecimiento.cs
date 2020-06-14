using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases.Abstractas
{
    public abstract class Establecimiento
    {
        public abstract int idEstablecimiento { get; set; }
        public abstract string estbCUIT { get; set; }
        public abstract string estbNombre { get; set; }
        public abstract string estbTelefono { get; set; }
        public abstract string estbDireccion { get; set; }
        public abstract string estbHorario { get; set; }
    }
}
