using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{

    public class Tratamiento
    {
        //Variables de la Clase Functions (funciones genéricas) y Messages (gestión de mensajes)
        Funciones func;
        CapaGlobal.Clases.Messages mssg;

        public Tratamiento()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        /* Función para búsqueda de datos de Películas mediante un sólo parámetro (nombre o código)
         * y llenado de resultado de datos (se invoca el llenado del ListView)
         * */
        public bool editTratamiento(Conexion conn, List<string> listData)
        {
            bool edit = false;

            try
            {
                //conn.getDataSet().Clear();
                string stringSQL = "SELECT * FROM tbl_tratamiento WHERE nombre_tratamiento = '" + listData[0] + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables[0].Rows.Count == 0)
                {
                    conn.getDataSet().Clear();
                    stringSQL = "   INSERT INTO tbl_tratamiento (nombre_tratamiento, precio)"
                        + " VALUES ('" + listData[0] + "'," + listData[1] + ");";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = false;
                }
                else
                {
                    conn.getDataSet().Clear();
                    stringSQL = "UPDATE tbl_tratamiento SET nombre_tratamiento = '" + listData[0] + "', precio = " + listData[1]
                        + " WHERE nombre_tratamiento='" + listData[0] + "';";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = true;
                }

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }

            return edit;
        }

        public void searchTratamiento(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT nombre_tratamiento AS Nombre, precio AS Precio"
                            + " FROM tbl_tratamiento"
                            + " WHERE (UPPER(nombre_tratamiento) LIKE UPPER('" + textdata + "%'))";
                func.fillListView(conn, listView, stringSQL);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        public List<string> getTratamiento(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT nombre_tratamiento, precio "
                + "FROM tbl_tratamiento"
                + " WHERE nombre_tratamiento = '" + listView.SelectedItems[0].Text + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables.Count != 0)
                {
                    for (int cont = 0; cont < conn.getDataSet().Tables[0].Columns.Count; cont++)
                    {
                        listData.Add(conn.getDataSet().Tables[0].Rows[0].ItemArray[cont].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }

            return listData;
        }

    }
}
