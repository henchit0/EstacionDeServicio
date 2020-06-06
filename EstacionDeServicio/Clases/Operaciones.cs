using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public class Operaciones
    {
        //Atributos de clase
        public int idOperacion { get; set; }
        public DateTime fechaOperacion { get; set; }
        public int totalFacturado { get; set; }
        public int totalLitros { get; set; }
        public int montoSurtido { get; set; }
        public Establecimiento estacion { get; set; }
        public Tanque tanqueDiesel { get; set; }
        public Tanque tanqueSuper { get; set; }
        public Tanque tanquePremium { get; set; }

        // Constructor
        public Operaciones(int idOperacion, int totalLitros, Establecimiento estacion, Tanque tanqueDiesel, Tanque tanqueSuper, Tanque tanquePremium)
        {
            this.idOperacion = idOperacion;
            this.totalLitros = totalLitros;
            this.estacion = estacion;
            this.tanqueDiesel = tanqueDiesel;
            this.tanqueSuper = tanqueSuper;
            this.tanquePremium = tanquePremium;

        //Metodos de clase
        /*public void IniciarJornada()
        {

        }

        public void FinalizarJornada()
        {*/

        }
    }
}
