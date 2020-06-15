using EstacionDeServicio.Clases;
using EstacionDeServicio.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionDeServicio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu(Iniciar()));
        }

        static private Operaciones Iniciar()
        {
            EstacionFsociety objEstbUno = new EstacionFsociety(1,"20332030702","FSOCIETY", "43516655", "Jose Juan Biedma 435","Lun. a Dom. 24hs");
            
            Tanque objTanqueDiesel = new Tanque(1, "Diesel", 2000, 2000,10);
            Tanque objTanqueSuper = new Tanque(1, "Super", 3000, 3000,25);
            Tanque objTanquePremium = new Tanque(1, "Premium", 2500, 2500,35);
            int totalLitros = objTanqueDiesel.disponibleTanque + objTanqueSuper.disponibleTanque + objTanquePremium.disponibleTanque;
            return new Operaciones(1,objEstbUno, objTanqueDiesel,objTanqueSuper,objTanquePremium);
        }
    }
}
