using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionDeServicio.Clases.Abstractas;

namespace EstacionDeServicio.Clases
{
    public class Playero : Persona
    {
        public override int IdPersona { get; set; }
        public override int NroLegajo { get; set; }
        public override String Nombre { get; set; }
        public override String Apellido { get; set; }
        public override String NroDocumento { get; set; }
        public override String Email { get; set; }

        public Playero(int idPersona, int nroLegajo, string nombre, string apellido, string nroDocumento, string email)
        {
            IdPersona = idPersona;
            NroLegajo = nroLegajo;
            Nombre = nombre;
            Apellido = apellido;
            NroDocumento = nroDocumento;
            Email = email;
        }

        public Playero(String nombre) { this.Nombre = nombre; }


    }
}
