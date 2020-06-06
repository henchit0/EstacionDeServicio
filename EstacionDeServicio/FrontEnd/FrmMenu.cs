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

namespace EstacionDeServicio
{
    public partial class FrmMenu : Form
    {
        private Operaciones _objOperaciones;
        private Surtidor surtidorDiesel;
        private Surtidor surtidorSuper;
        private Surtidor surtidorPremium;

        public FrmMenu(Operaciones operaciones)
        {
            InitializeComponent();
            this._objOperaciones = operaciones;
            surtidorDiesel = IniciarSurtidorDiesel();
            surtidorSuper = IniciarSurtidorSuper();
            surtidorPremium = IniciarSurtidorPremium();
            CalcularLitros();
            LlenarDatos();
        }   

        private Surtidor IniciarSurtidorDiesel()
        {
            Surtidor surtidorDiesel = new Surtidor(1, _objOperaciones.tanqueDiesel, 0, 0, 0);
            return surtidorDiesel;
        }
        private Surtidor IniciarSurtidorSuper()
        {
            Surtidor surtidorSuper = new Surtidor(2, _objOperaciones.tanqueSuper, 0, 0, 0);
            return surtidorSuper;
        }
        private Surtidor IniciarSurtidorPremium()
        {
            Surtidor surtidorPremium = new Surtidor(3, _objOperaciones.tanquePremium, 0, 0, 0);
            return surtidorPremium;
        }


        private void LlenarDatos()
        {
            //Llenamos los datos de la estacion
            lblStationName.Text = $"Estación: {_objOperaciones.estacion.estbNombre}";
            lblCUIT.Text = $"CUIT: {_objOperaciones.estacion.estbCUIT}";
            lblAddress.Text = $"Dirección: {_objOperaciones.estacion.estbDireccion}";

            //Llenamos los datos de los tanques
            //Diesel
            lblPlayeroDiesel.Text = "Player@: Roberto";
            lblCapacidadDiesel.Text = $"Capacidad: {_objOperaciones.tanqueDiesel.capacidadTanque.ToString()}";
            lblDisponibleDiesel.Text = $"Disponible: {_objOperaciones.tanqueDiesel.disponibleTanque.ToString()}";
            lblTotalLitrosDiesel.Text = $"Total surtido: {surtidorDiesel.litrosSurtidos}lts.";
            lblCantOperacionesDiesel.Text = $"Cant. operaciones: {surtidorDiesel.cantOperaciones}";
            lblMontoTotalDiesel.Text = $"Monto Total: ${surtidorDiesel.montoSurtido}";
            //Super
            lblPlayeroSuper.Text = "Player@: Manolo";
            lblCapacidadSuper.Text = $"Capacidad: {_objOperaciones.tanqueSuper.capacidadTanque.ToString()}";
            lblDisponibleSuper.Text = $"Disponible: {_objOperaciones.tanqueSuper.disponibleTanque.ToString()}";
            lblTotalLitrosSuper.Text = $"Total surtido: {surtidorSuper.litrosSurtidos}lts.";
            lblCantOperacionesSuper.Text = $"Cant. operaciones: {surtidorSuper.cantOperaciones}";
            lblMontoTotalSuper.Text = $"Monto Total: ${surtidorSuper.montoSurtido}";
            //Super
            lblPlayeroPremium.Text = "Player@: Marian";
            lblCapacidadPremium.Text = $"Capacidad: {_objOperaciones.tanquePremium.capacidadTanque.ToString()}";
            lblDisponiblePremium.Text = $"Disponible: {_objOperaciones.tanquePremium.disponibleTanque.ToString()}";
            lblTotalLitrosPremium.Text = $"Total surtido: {surtidorPremium.litrosSurtidos}lts.";
            lblCantOperacionesPremium.Text = $"Cant. Operaciones: {surtidorPremium.cantOperaciones}";
            lblMontoTotalPremium.Text = $"Monto Total: ${surtidorPremium.montoSurtido}";
        }

        private void CalcularLitros()
        {
            _objOperaciones.totalLitros = surtidorDiesel.litrosSurtidos + surtidorSuper.litrosSurtidos + surtidorPremium.litrosSurtidos;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblOperacionesDiesel_Click(object sender, EventArgs e)
        {

        }

        private void lblCapacidadDiesel_Click(object sender, EventArgs e)
        {

        }

        private void lblDisponibleDiesel_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalLitrosDiesel_Click(object sender, EventArgs e)
        {

        }

        private void btnDiesel_Click(object sender, EventArgs e)
        {                        
            FrmSurtidor frmDiesel = new FrmSurtidor(surtidorDiesel);
            frmDiesel.ShowDialog();
            CalcularLitros();
            LlenarDatos();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            FrmSurtidor frmSuper = new FrmSurtidor(surtidorSuper);
            frmSuper.ShowDialog();
            CalcularLitros();
            LlenarDatos();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            FrmSurtidor frmPremium = new FrmSurtidor(surtidorPremium);
            frmPremium.ShowDialog();
            CalcularLitros();
            LlenarDatos();
        }
    }
}
