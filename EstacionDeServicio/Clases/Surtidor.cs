using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionDeServicio.Clases;

namespace EstacionDeServicio.Clases
{
    public class Surtidor
    {
        public int idSurtidor { get; set; }
        //public Persona playero { get; set; }
        public Tanque tipoTanque { get; set; }
        public int litrosSurtidos { get; set; }
        public int montoSurtido { get; set; }
        public int cantOperaciones { get; set; }


        public Surtidor(int idSurtidor, Tanque tipoTanque, int litrosSurtidos, int montoSurtido, int cantOperaciones)
        {
            this.idSurtidor = idSurtidor;
            this.tipoTanque = tipoTanque;
            this.litrosSurtidos = litrosSurtidos;
            this.montoSurtido = montoSurtido;
            this.cantOperaciones = cantOperaciones;
        }

        public void SurtirCombustible(int litros)
        {
            this.tipoTanque.ExtraerCombustible(litros);
            //this.litrosSurtidos += litros;
        }

        public void CalcularMonto(int litros)
        {
            this.montoSurtido += litros * this.tipoTanque.precioPorLitro;
        }

    }
}
