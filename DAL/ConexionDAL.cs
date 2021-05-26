using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEmpleados.DAL
{
    class ConexionDAL
    {
        private string CadenaConexion = "Data Source=DESKTOP-6MQABRN; Initial Catalog=dbSistema; Integrated Security=True";
        SqlConnection Conexion;
        
        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return.this.Conexion;
        }

        public bool PruebaConectar()
        {
            try {
                
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "select * from Empleados";
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            } catch {
                return false;
            }
        }
    }
}
