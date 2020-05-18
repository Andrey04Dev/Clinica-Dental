using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Clases
{
    public class Funciones
    {
        CapaGlobal.Clases.Messages mssg = new CapaGlobal.Clases.Messages();

        /* Se encarga de forma general de tomar los datos por medio de consultas SQL y mostrar los resultados en 
         * el componente listview.
         * LLena el ListView en forma de Matriz, con columnas en Y y filas en X con el recorrido del ciclo FOR.
         */

        public void fillListView(CapaDatos.Clases.Conexion conn, System.Windows.Forms.ListView listView, String query)
        {
            try
            {
                int x = 0;
                int y = 0;

                conn.querySQL(query);
                conn.fillDataset("", "");
                listView.Clear();

                if (conn.getDataSet().Tables.Count != 0)
                {
                    while (y < conn.getDataSet().Tables[0].Rows.Count)
                    {
                        x = 0;
                        while (x < conn.getDataSet().Tables[0].Columns.Count)
                        {
                            if (y == 0)
                            {
                                listView.Columns.Add(conn.getDataSet().Tables[0].Columns[x].ColumnName, 150, HorizontalAlignment.Left);
                            }
                            if (x == 0)
                            {
                                listView.Items.Add(conn.getDataSet().Tables[0].Rows[y].ItemArray[x].ToString());
                            }
                            else
                            {
                                listView.Items[y].SubItems.Add(conn.getDataSet().Tables[0].Rows[y].ItemArray[x].ToString());
                            }
                            x += 1;
                        }

                        if (y % 2 == 0)
                        {
                            // Damos color gris a las filas pares para dar un efecto de resaltado intercalado
                            listView.Items[y].BackColor = Color.WhiteSmoke;
                        }
                        y += 1;
                    }
                }

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        public void fillImagenSystem(CapaDatos.Clases.Conexion conn, System.Windows.Forms.ListView listView, String query)
        {
            try
            {
                int x = 0;
                int y = 0;

                conn.querySQL(query);
                conn.fillDataset("", "");
                listView.Clear();

                if (conn.getDataSet().Tables.Count != 0)
                {
                    while (y < conn.getDataSet().Tables[0].Rows.Count)
                    {
                        x = 0;
                        while (x < conn.getDataSet().Tables[0].Columns.Count)
                        {
                            if (y == 0)
                            {
                                listView.Columns.Add(conn.getDataSet().Tables[0].Columns[x].ColumnName, 150, HorizontalAlignment.Left);
                            }
                            if (x == 0)
                            {
                                listView.Items.Add(conn.getDataSet().Tables[0].Rows[y].ItemArray[x].ToString());
                            }
                            else
                            {
                                listView.Items[y].SubItems.Add(conn.getDataSet().Tables[0].Rows[y].ItemArray[x].ToString());
                            }
                            x += 1;
                        }

                        if (y % 2 == 0)
                        {
                            // Damos color gris a las filas pares para dar un efecto de resaltado intercalado
                            listView.Items[y].BackColor = Color.WhiteSmoke;
                        }
                        y += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        public void fillString(CapaDatos.Clases.Conexion conn, String query)
        {
            try
            {
                conn.querySQL(query);
                conn.fillDataset("", "");
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

    }
}
