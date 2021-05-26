using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.BLL;

namespace AdminEmpleados.PL
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtiene la información de los campos rellenados
            RecuperarInformacion();
        }
        //Se crea un metodo, crea una instancia utilizando la clase DepartamentoBLL
        private void RecuperarInformacion()
        {
            DepartamentoBLL oDepartamento = new DepartamentoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamento.ID = ID;

            oDepartamento.Departamento = txtNombre.Text;
            //ToString hace pasar el ID (int) a ID (String)
            MessageBox.Show(oDepartamento.ID.ToString());
            MessageBox.Show(oDepartamento.Departamento);
        }
    }
}
