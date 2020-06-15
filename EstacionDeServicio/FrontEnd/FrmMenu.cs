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
using EstacionDeServicio.Clases.Interfaces;
using EstacionDeServicio.FrontEnd;

namespace EstacionDeServicio
{
    public partial class FrmMenu : Form
    {
        private Operaciones _objOperaciones;
        private Surtidor surtidorDiesel;
        private Surtidor surtidorSuper;
        private Surtidor surtidorPremium;
        private Playero playeroDiesel;
        private Playero playeroSuper;
        private Playero playeroPremium;

        public FrmMenu(Operaciones operaciones)
        {
            InitializeComponent();
            this._objOperaciones = operaciones;
            playeroDiesel = IniciarPlayeroDiesel();
            playeroSuper = IniciarPlayeroSuper();
            playeroPremium = IniciarPlayeroPremium();
            surtidorDiesel = IniciarSurtidorDiesel();
            surtidorSuper = IniciarSurtidorSuper();
            surtidorPremium = IniciarSurtidorPremium();            
            CalcularTotales();
            LlenarDatos();
        }

        private Playero IniciarPlayeroPremium()
        {
            Playero playeroPremium = new Playero("Tamara");
            return playeroPremium;
        }

        private Playero IniciarPlayeroSuper()
        {
            Playero playeroSuper = new Playero("Marcelo");
            return playeroSuper;
        }

        private Playero IniciarPlayeroDiesel()
        {
            Playero playeroDiesel = new Playero("Dionel");
            return playeroDiesel;
        }

        private Surtidor IniciarSurtidorDiesel()
        {
            Surtidor surtidorDiesel = new Surtidor(1, playeroDiesel, _objOperaciones.tanqueDiesel, 0, 0, 0);
            return surtidorDiesel;
        }
        private Surtidor IniciarSurtidorSuper()
        {
            Surtidor surtidorSuper = new Surtidor(2, playeroSuper, _objOperaciones.tanqueSuper, 0, 0, 0);
            return surtidorSuper;
        }
        private Surtidor IniciarSurtidorPremium()
        {
            Surtidor surtidorPremium = new Surtidor(3, playeroPremium, _objOperaciones.tanquePremium, 0, 0, 0);
            return surtidorPremium;
        }


        private void LlenarDatos()
        {
            //Llenamos los datos de la estacion
            lblStationName.Text = $"ESTACIÓN DE SERVICIOS {_objOperaciones.estacion.estbNombre}";
            lblCUIT.Text = $"CUIT: {_objOperaciones.estacion.estbCUIT}";
            lblAddress.Text = $"Dirección: {_objOperaciones.estacion.estbDireccion}";
            lblPhone.Text = $"Telefono: {_objOperaciones.estacion.estbTelefono}";
            lblHours.Text = $"Horario: {_objOperaciones.estacion.estbHorario}";

            //Llenamos los datos de los tanques
            //Diesel
            lblPlayeroDiesel.Text = $"Player@: {surtidorDiesel.playero.Nombre}";
            lblCapacidadDiesel.Text = $"Capacidad: {_objOperaciones.tanqueDiesel.capacidadTanque.ToString()}";
            lblDisponibleDiesel.Text = $"Disponible: {_objOperaciones.tanqueDiesel.disponibleTanque.ToString()}";
            lblTotalLitrosDiesel.Text = $"Total surtido: {surtidorDiesel.litrosSurtidos}lts.";
            lblCantOperacionesDiesel.Text = $"Cant. operaciones: {surtidorDiesel.cantOperaciones}";
            lblMontoTotalDiesel.Text = $"Monto Total: ${surtidorDiesel.montoSurtido}";
            //Super
            lblPlayeroSuper.Text = $"Player@: {surtidorSuper.playero.Nombre}";
            lblCapacidadSuper.Text = $"Capacidad: {_objOperaciones.tanqueSuper.capacidadTanque}";
            lblDisponibleSuper.Text = $"Disponible: {_objOperaciones.tanqueSuper.disponibleTanque}";
            lblTotalLitrosSuper.Text = $"Total surtido: {surtidorSuper.litrosSurtidos}lts.";
            lblCantOperacionesSuper.Text = $"Cant. operaciones: {surtidorSuper.cantOperaciones}";
            lblMontoTotalSuper.Text = $"Monto Total: ${surtidorSuper.montoSurtido}";
            //Premium
            lblPlayeroPremium.Text = $"Player@: {surtidorPremium.playero.Nombre}";
            lblCapacidadPremium.Text = $"Capacidad: {_objOperaciones.tanquePremium.capacidadTanque}";
            lblDisponiblePremium.Text = $"Disponible: {_objOperaciones.tanquePremium.disponibleTanque}";
            lblTotalLitrosPremium.Text = $"Total surtido: {surtidorPremium.litrosSurtidos}lts.";
            lblCantOperacionesPremium.Text = $"Cant. Operaciones: {surtidorPremium.cantOperaciones}";
            lblMontoTotalPremium.Text = $"Monto Total: ${surtidorPremium.montoSurtido}";
            //Operaciones
            label1.Text = $"Total facturado: ${_objOperaciones.totalFacturado}";
            label2.Text = $"Total lts. Surtidos: ${_objOperaciones.totalLitros}";
        }

        private void CalcularTotales()
        {
            _objOperaciones.CalcularTotalLitros(surtidorDiesel.litrosSurtidos, surtidorSuper.litrosSurtidos, surtidorPremium.litrosSurtidos);
            _objOperaciones.CalcularTotalFacturado(surtidorDiesel.montoSurtido, surtidorSuper.montoSurtido, surtidorPremium.montoSurtido);
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
            CalcularTotales();
            LlenarDatos();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            FrmSurtidor frmSuper = new FrmSurtidor(surtidorSuper);
            frmSuper.ShowDialog();
            CalcularTotales();
            LlenarDatos();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            FrmSurtidor frmPremium = new FrmSurtidor(surtidorPremium);
            frmPremium.ShowDialog();
            CalcularTotales();
            LlenarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
