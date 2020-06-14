using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases.Interfaces
{
    public interface ITanque
    {
        int idTanque { get; set; }
        string tipoCombustible { get; set; }
        int capacidadTanque { get; set; }
        int disponibleTanque { get; set; }
        int precioPorLitro { get; set; }
        int montoTotal { get; set; }

        void CargarTanque();
    }
}


