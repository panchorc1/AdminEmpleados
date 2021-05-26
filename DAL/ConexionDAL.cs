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
        public bool PruebaConectar()
        {
            try {
                SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-6MQABRN; Initial Catalog=dbSistema; Integrated Security=True");
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "select * from Empleados";
                Comando.Connection = Conexion;
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
