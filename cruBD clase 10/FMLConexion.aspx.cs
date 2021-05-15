using cruBD_clase_10.clases.archivos;
using cruBD_clase_10.clases.base_de_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cruBD_clase_10
{
    public partial class FMLConexion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\crudDB.csv"; //esta cadena es para ubicar el documento 
            ClsArchivos archivo = new ClsArchivos();
            ClsConexion conexi = new ClsConexion();
            ClsConexionMySQL conexiMYSQL = new ClsConexionMySQL();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = archivo.LeerArchivo(fuente);
            string sentencia = "";
            int Numerolinea = 0;

            

            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');//esta cadena reconoce los datos de el documento
                if (Numerolinea > 0)
                {
                    sentencia = sentencia + $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;// la sencia es para tomar en cuenta los datos de SQl server y poder hacer la conexion con la base datos
            }

            conexi.EjecutaSQLDirecto(sentencia);
            conexiMYSQL.EjecutaMySQLDirecto(sentencia);
        }
        protected void ButtonCargarArchivo_Click(object sender, EventArgs e) // el boton cargar permite que documento sea ingresado al momento de ejecutar el programa
        {

            cargarArchivoExterno();

        }

        protected void Button1_Click(object sender, EventArgs e)//este botn lo que hace es buscar el correlativo para dar el correlativo del nombre
        {
            ClsBuscarSQL buscarnombre = new ClsBuscarSQL();
            string id = TextBox1.Text.Trim();
            string condicion = $"correlativo = {id}";//esta funcion busca el nombre si uno ingresa el numero
            DataTable dt = buscarnombre.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxBuscar.Text = nombre;
            }
            else
            {
                TextBoxBuscar.Text = "No hay informacion";
            }

        }

        protected void ButtonBuscarNombre_Click(object sender, EventArgs e) //este boton su funcion es buscar   el nombre con el numero
        {


            ClsBuscarSQL buscar = new ClsBuscarSQL();
            string nombre = TextBox2.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBoxBuscarpornombre.Text = id + "";
            }
            else
            {
                TextBoxBuscarpornombre.Text = "No hay informacion";
            }

        }

        protected void ButtonBuscarcorrelativo_Click(object sender, EventArgs e) //este botn  lo que hace es aparecer los datos en los texbox
        {
            ClsBuscarSQL buscarnombre = new ClsBuscarSQL();
            string id = TextBoxCorrelativo1.Text.Trim();
            string condicion = $"correlativo = {id}";// busca el nombre y da la posicion en que esta
            DataTable dt = buscarnombre.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxCorrelativo2.Text = nombre;
            }
            else
            {
                TextBoxCorrelativo2.Text = "No hay informacion";// al momento de dar un numeo incorrecto informa que no hay info.
            }

        }

        protected void ButtonBuscarpornombre_Click(object sender, EventArgs e)
        {
            ClsBuscarMySQL buscar = new ClsBuscarMySQL();
            string nombre = TextBoxnombre1.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBoxnombre2.Text = id + "";
            }
            else
            {
                TextBoxnombre2.Text = "No hay informacion";
            }

        }
    }
}

