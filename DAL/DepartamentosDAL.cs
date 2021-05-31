using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AdminEmpleados.BLL;

namespace AdminEmpleados.DAL
{
    class DepartamentosDAL
    {
        ConexionDAL conexion;
        
        public DepartamentosDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar(DepartamentoBLL oDepartamentosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("insert into Departamentos values (@Departamente)");
            SQLComando.Parameters.Add("@Departamente", SqlDbType.VarChar).Value=oDepartamentosBLL.Departamento;
            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);
            //return conexion.ejecutarComandoSinRetornoDatos("INSERT INTO Departamentos (departamento) VALUES ('"+oDepartamentosBLL.Departamento+"')");
            
        }
        public int Eliminar(DepartamentoBLL oDepartamentosBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("delete from Departamentos where id ="+oDepartamentosBLL.ID);

            return 1;
        }
        public int Modificar(DepartamentoBLL oDepartamentosBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("update Departamentos set departamento" +
                "set departamento='"+oDepartamentosBLL.Departamento+"'"+
                "where id = "+ oDepartamentosBLL);
                                                                                                                
            return 1;
        }

        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("select * form Departamentos");

            return conexion.EjecutarSentencia(sentencia);
        }

    }
}
