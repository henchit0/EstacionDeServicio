using EstacionDeServicio.Clases.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public class EstacionFsociety : Establecimiento
    {
        public override int idEstablecimiento { get; set; }
        public override string estbCUIT { get; set; }
        public override string estbNombre { get; set; }
        public override string estbTelefono { get; set; }
        public override string estbDireccion { get; set; }
        public override string estbHorario { get; set; }

        public EstacionFsociety(int idEstablecimiento, string estbCUIT, string estbNombre, string estbTelefono, string estbDireccion, string estbHorario)
        {
            this.idEstablecimiento = idEstablecimiento;
            this.estbCUIT = estbCUIT;
            this.estbNombre = estbNombre;
            this.estbTelefono = estbTelefono;
            this.estbDireccion = estbDireccion;
            this.estbHorario = estbHorario;
        }
    }
}
