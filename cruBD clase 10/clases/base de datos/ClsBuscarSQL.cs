using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace cruBD_clase_10.clases.base_de_datos
{
    public class ClsBuscarSQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")//esta parte es donde busca los datos de la base de datos  de SQL server
        {
            ClsConexion conexionn = new ClsConexion();
            DataTable datos = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";//esta condicion es para que reconozca los datos copn esta condicion
            datos = conexionn.consultaTablaDirecta(sentencia);
            return datos;//los retorna
        }
    }
}