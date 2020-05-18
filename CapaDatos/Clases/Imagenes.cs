using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Imagenes
    {
        Funciones func;
        CapaGlobal.Clases.Messages mssg;

        public Imagenes()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        public void searchImagenes(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT nombre_imagen AS Nombre"
               + " FROM tbl_imagen "
               + " WHERE (UPPER(nombre_imagen) LIKE UPPER('" + textdata + "%'))";
                func.fillImagenSystem(conn, listView, stringSQL);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }

        }
        public List<string> getImagenes(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT nombre_imagen"
                + " FROM tbl_imagen "
                + " WHERE nombre_imagen = '" + listView.SelectedItems[0].Text + "'";
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

        public bool editImagenes(Conexion conn, List<string> listData)
        {
            bool edit = false;

            try
            {
                //conn.getDataSet().Clear();
                string stringSQL = "SELECT * FROM tbl_imagen WHERE nombre_imagen = '" + listData[0] + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables[0].Rows.Count == 0)
                {
                    conn.getDataSet().Clear();
                    stringSQL = "   INSERT INTO tbl_imagen (nombre_imagen)"
                        + " VALUES ('" + listData[0] + "');";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = false;
                }
                else
                {
                    conn.getDataSet().Clear();
                    stringSQL = "UPDATE tbl_imagenes SET nombre_imagen = '"+listData[0]+"' WHERE nombre_imagen='" + listData[0] + "';";
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
    }
}
