using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Odontograma
    {
        Funciones func;
        CapaGlobal.Clases.Messages mssg;
        public Odontograma()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        public void searchOdontograma(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT cedula_paciente AS Cedula, categoria_odontograma AS Categoria, imagen_odontograma AS Imagen"
                + "FROM tbl_odontograma"
                + " WHERE (UPPER(cedula_paciente) LIKE UPPER('" + textdata + "%')";
                func.fillListView(conn, listView, stringSQL);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        public List<string> getOdontograma(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT cedula_paciente, categoria_odontograma, imagen_odontograma"
                + "FROM tbl_odontograma"
                + " WHERE cedula_paciente = '" + listView.SelectedItems[0].Text + "'";
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

        public bool editOdontograma(Conexion conn, List<string> listData)
        {
            bool edit = false;

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT * FROM tbl_odontograma WHERE cedula_paciente = '" + listData[0] + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables[0].Rows.Count == 0)
                {
                    conn.getDataSet().Clear();
                    stringSQL = "   INSERT INTO tbl_odontograma (cedula_paciente, categoria_odontograma, imagen_odontograma )"
                        + " VALUES ('" + listData[0] + "','" + listData[1] + "', '" + listData[2] + "');";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = false;
                }
                else
                {
                    conn.getDataSet().Clear();
                    stringSQL = "UPDATE tbl_odontograma SET cedula_paciente = '" + listData[0] + "', categoria_odontograma = '" + listData[1]
                        + "', imagen_odontograma ='" + listData[2] + "' WHERE cedula_paciente='" + listData[0] + "';";
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

