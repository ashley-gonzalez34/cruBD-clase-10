

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace cruBD_clase_10.clases.base_de_datos
{
    public class ClsConexionMySQL
    {
        public MySqlConnection conexion;
        private String _conexion { get; }
        public ClsConexionMySQL()//esta es la contactamiento de l base de datos de MYSQL

        {
            _conexion = "Service=127.0.0.1; database=dbprogranueva; User=root; pwd=Umg$2019";// esta cadena reconoce la conexion de esta base da datos
        }

        public void cerrarConexionBD()//cierra la conexion
        {
            conexion.Close();
        }

        public void abrirConexion()//abre la conexion
        {
            conexion = new MySqlConnection(_conexion);
            conexion.Open();
        }

        public DataTable consultaTablaDirecta(String Mysqll)// hace la consulta de la base de datos
        {
            abrirConexion();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(Mysqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }

        public void EjecutaMySQLDirecto(String Mysqll)//al momento de que ejecutada
        {
            abrirConexion();
            try
            {

                MySqlCommand comm = new MySqlCommand(Mysqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }
        }

        public void EjecutaMySQLManual(String Mysqll)//termina de formular toda la informacion
        {
            MySqlCommand comm = new MySqlCommand(Mysqll, conexion);
            comm.ExecuteReader();
        }

    }
}