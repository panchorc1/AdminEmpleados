﻿using System;
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
            return conexion.ejecutarComandoSinRetornoDatos("INSERT INTO Departamentos (departamento) VALUES ('"+oDepartamentosBLL.Departamento+"')");
        }
        public int Eliminar(DepartamentoBLL oDepartamentosBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("delete from Departamentos where id ="+oDepartamentosBLL.ID);

            return 1;
        }

        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("select * form Departamentos");

            return conexion.EjecutarSentencia(sentencia);
        }

    }
}
