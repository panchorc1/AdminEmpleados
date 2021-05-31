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
using AdminEmpleados.DAL;

namespace AdminEmpleados.PL
{
    public partial class frmDepartamentos : Form
    {

        DepartamentosDAL oDepartamentosDAL;

        public frmDepartamentos()
        {
            oDepartamentosDAL = new DepartamentosDAL();
            InitializeComponent();
            LlenarGrid();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtiene la información de los campos rellenados
            MessageBox.Show("Conectado...");

            //Clase DAL Departamentos, pasando objeto con la informacion de la interfaz grafica
            oDepartamentosDAL.Agregar(RecuperarInformacion());
            LlenarGrid();
        }
        //Se crea un metodo, crea una instancia utilizando la clase DepartamentoBLL
        private DepartamentoBLL RecuperarInformacion()
        {
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamentoBLL.ID = ID;

            oDepartamentoBLL.Departamento = txtNombre.Text;

            return oDepartamentoBLL;
        }

        private void Selecionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Eliminar(RecuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Modificar(RecuperarInformacion());
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            //dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }
    }
}
