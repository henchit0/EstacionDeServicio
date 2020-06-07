using EstacionDeServicio.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionDeServicio.Clases
{
    public class Tanque : ITanque
    {
        // Atributos
        public int idTanque { get; set; }
        public string tipoCombustible { get; set; }
        public int capacidadTanque { get; set; }
        public int disponibleTanque { get; set; }
        public int precioPorLitro { get; set; }
        public int montoTotal { get; set; }

        // Constructor
        public Tanque(int idTanque, string tipoCombustible, int capacidadTanque, int disponibleTanque, int precioPorLitro)
        {
            this.idTanque = idTanque;
            this.tipoCombustible = tipoCombustible;
            this.capacidadTanque = capacidadTanque;
            this.disponibleTanque = disponibleTanque;
            this.precioPorLitro = precioPorLitro;
        }        

        public void CargarTanque() 
        {
            this.disponibleTanque = this.capacidadTanque;
        }
        
    }
}
