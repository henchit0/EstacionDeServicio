using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionDeServicio.Clases;
using EstacionDeServicio.FrontEnd;

namespace EstacionDeServicio.FrontEnd
{
    public partial class FrmSurtidor : Form
    {
        private Surtidor _objSurtidor;        
        
        public FrmSurtidor(Surtidor surtidor)
        {
            InitializeComponent();
            this._objSurtidor = surtidor;            
            LlenarDatos();
        }

        public void LlenarDatos()
        {
            // Completo datos
            lblCapacidad.Text = $"Capacidad: {_objSurtidor.tipoTanque.capacidadTanque} lts";
            lblDisponible.Text = $"Disponible: {_objSurtidor.tipoTanque.disponibleTanque} lts";
            lblSurtidor.Text = _objSurtidor.tipoTanque.tipoCombustible;
            lblPrecio.Text = $"Precio: ${_objSurtidor.tipoTanque.precioPorLitro}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numLitros.Value += 1;
            _objSurtidor.SurtirCombustible(1);            
            lblDisponible.Text = $"Disponible: {_objSurtidor.tipoTanque.disponibleTanque} litros";
            lblMontoSurtido.Text = $"Monto: ${_objSurtidor.tipoTanque.precioPorLitro * numLitros.Value}";
        }

        private void btnSurtir_Click(object sender, EventArgs e)
        {
            lblCobrado.Text = "";
            timer.Enabled = true;
            btnSurtir.Enabled = false;
            btnFinalizar.Enabled = true;
            btnVolver.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;            
            btnFinalizar.Enabled = false;
            btnCobrar.Enabled = true;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            _objSurtidor.CalcularMonto(Convert.ToInt32(numLitros.Value));
            _objSurtidor.litrosSurtidos += Convert.ToInt32(numLitros.Value);

            lblCobrado.Text = $"Se cobró: ${_objSurtidor.montoSurtido}";
            btnSurtir.Enabled = true;
            btnCobrar.Enabled = false;
            btnVolver.Enabled = true;
            lblMontoSurtido.Text = "Monto: $0,00";
            numLitros.Value = 0;
            _objSurtidor.cantOperaciones++;
        }

        private void lblSurtidor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmSurtidor.ActiveForm.Hide();            
        }

        private void lblDisponible_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
