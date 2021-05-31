﻿using MongoDB.Driver.Core.Configuration;
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
            return this.Conexion;
        }
        /*Metodo INSERT, DELETE, UPDATE*/
        public bool ejecutarComandoSinRetornoDatos(string strComando)
        {
            try {
                
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            } catch {
                return false;
            }
        }
        //Sobrecarga Metodo INSERT, DELETE, UPDATE
        public bool ejecutarComandoSinRetornoDatos(SqlCommand SQLComando)
        {
            try
            {

                SqlCommand Comando = SQLComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*SELECT (Retorno datos)*/
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch {
                return DS;
            }
        }
    }
}
