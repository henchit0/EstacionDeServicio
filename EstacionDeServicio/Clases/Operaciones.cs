using EstacionDeServicio.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public class Operaciones : IOperaciones
    {
        public int idOperacion { get; set; }
        public DateTime fechaOperacion { get; set; }
        public int totalFacturado { get; set; }
        public int totalLitros { get; set; }
        public EstacionFsociety estacion { get; set; }
        public Tanque tanqueDiesel { get; set; }
        public Tanque tanqueSuper { get; set; }
        public Tanque tanquePremium { get; set; }

        public Operaciones(int idOperacion, DateTime fechaOperacion, int totalFacturado, int totalLitros, EstacionFsociety estacion, Tanque tanqueDiesel, Tanque tanqueSuper, Tanque tanquePremium)
        {
            this.idOperacion = idOperacion;
            this.fechaOperacion = fechaOperacion;
            this.totalFacturado = totalFacturado;
            this.totalLitros = totalLitros;
            this.estacion = estacion;
            this.tanqueDiesel = tanqueDiesel;
            this.tanqueSuper = tanqueSuper;
            this.tanquePremium = tanquePremium;
        }

        public Operaciones(int idOperacion, EstacionFsociety estacion, Tanque tanqueDiesel, Tanque tanqueSuper, Tanque tanquePremium) 
        {
            this.idOperacion = idOperacion;
            this.estacion = estacion;
            this.tanqueDiesel = tanqueDiesel;
            this.tanqueSuper = tanqueSuper;
            this.tanquePremium = tanquePremium;
        }

        public void CalcularTotalFacturado(int montoDiesel, int montoSuper, int montoPremium)
        {
            this.totalFacturado = montoDiesel + montoSuper + montoPremium;
        }

        public void CalcularTotalLitros(int litrosDiesel, int litrosSuper, int litrosPremium)
        {
            this.totalLitros = litrosDiesel + litrosSuper + litrosPremium;
        }

        //Metodos de clase
        /*public void IniciarJornada()
        {

        }

        public void FinalizarJornada(){
        {*/



    }
}
