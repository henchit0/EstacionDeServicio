using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases.Interfaces
{
    interface IOperaciones
    {
        int idOperacion { get; set; }
        DateTime fechaOperacion { get; set; }
        int totalFacturado { get; set; }
        int totalLitros { get; set; }
        EstacionFsociety estacion { get; set; }
        Tanque tanqueDiesel { get; set; }
        Tanque tanqueSuper { get; set; }
        Tanque tanquePremium { get; set; }

        void CalcularTotalLitros(int litrosDiesel,int litrosSuper,int litrosPremium);
        void CalcularTotalFacturado(int montoDiesel, int montoSuper, int montoPremium);

    }
}
