using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace cruBD_clase_10.clases.archivos
{
    public class ClsArchivos
    {
        public string[] LeerArchivo(string archivo)//esta parte permite abrir el archivo cvs
        {
            string[] Lineas = File.ReadAllLines(archivo, Encoding.Default); //lee cada linea del documento
            return Lineas;//retorna cada linea
        }

        
    }
}