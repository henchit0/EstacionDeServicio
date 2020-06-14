using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases.Interfaces
{
    interface ISurtidor
    {
        int idSurtidor { get; set; }
        Playero playero { get; set; }
        Tanque tipoTanque { get; set; }
        int litrosSurtidos { get; set; }
        int montoSurtido { get; set; }
        int cantOperaciones { get; set; }

        void SurtirCombustible(int litros);
        void CalcularMonto(int litros);
    }
}
