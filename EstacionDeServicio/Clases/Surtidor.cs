using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionDeServicio.Clases;
using EstacionDeServicio.Clases.Interfaces;

namespace EstacionDeServicio.Clases
{
    public class Surtidor : ISurtidor
    {
        public int idSurtidor { get; set; }
        public Playero playero { get; set; }
        public Tanque tipoTanque { get; set; }
        public int litrosSurtidos { get; set; }
        public int montoSurtido { get; set; }
        public int cantOperaciones { get; set; }

        public Surtidor(int idSurtidor, Playero playero, Tanque tipoTanque, int litrosSurtidos, int montoSurtido, int cantOperaciones)
        {
            this.idSurtidor = idSurtidor;
            this.playero = playero;
            this.tipoTanque = tipoTanque;
            this.litrosSurtidos = litrosSurtidos;
            this.montoSurtido = montoSurtido;
            this.cantOperaciones = cantOperaciones;
        }

        public void CalcularMonto(int litros)
        {
            this.montoSurtido += litros * this.tipoTanque.precioPorLitro;
        }

        public void SurtirCombustible(int litros)
        {
            this.tipoTanque.disponibleTanque -= litros;
        }
    }
}
