using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace cruBD_clase_10.clases.base_de_datos
{
    public class ClsBuscarMySQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")// sta clase busca los datos de la base de datos de MYSQL hacendo la inserseccion 
        {
            ClsConexionMySQL cn = new ClsConexionMySQL();
            DataTable datos = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            datos = cn.consultaTablaDirecta(sentencia);
            return datos;
        }
    }
}