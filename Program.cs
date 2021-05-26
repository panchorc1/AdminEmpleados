using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.PL;//Se hace llamado para poder utilziar los archivos dentro de la carpeta PL

namespace AdminEmpleados
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Se agrega frmDepartamentos, para que inicie desde ese formulario
            Application.Run(new frmDepartamentos());
        }
    }
}
