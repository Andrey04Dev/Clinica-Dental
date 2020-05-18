using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public  class Anamnesis
    {
        Funciones func;
        CapaGlobal.Clases.Messages mssg;
        public Anamnesis()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        public void searchAnamnesis(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT cedula_paciente AS Cedula, medico_cabecera AS Medico, tipo_sangre AS Tipo, persona_avisar AS Persona, telefono_emergencia AS Telefono,"
                + " direccion AS Direccion, parentesco AS Parentesco, queja_principal AS Queja, historia_queja_historia AS Queja_Historiar"
                + " FROM tbl_anamnesis "
                + " WHERE (UPPER(cedula_paciente) LIKE UPPER('" + textdata + "%')"
                + " OR UPPER(nombre_paciente) LIKE UPPER('" + textdata + "%'))";

                func.fillListView(conn, listView, stringSQL);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }
        public List<string> getAnamnesis(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT cedula_paciente, medico_cabecera, tipo_sangre, persona_avisar, telefono_emergencia,"
                + " direccion, parentesco, queja_principal, historia_queja_historia"
                + " FROM tbl_anamnesis "
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
        public bool editAnamenesis(Conexion conn, List<string> listData)
        {
            bool edit = false;

            try
            {
                //conn.getDataSet().Clear();
                string stringSQL = "SELECT * FROM tbl_anamnesis WHERE cedula_paciente = '" + listData[0] + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables[0].Rows.Count == 0)
                {
                    conn.getDataSet().Clear();
                    stringSQL = "   INSERT INTO tbl_anamnesis (cedula_paciente, medico_cabecera, tipo_sangre, persona_avisar, telefono_emergencia, direccion, parentesco, queja_principal, historia_queja_historia )"
                        + " VALUES ('" + listData[0] + "','" + listData[1] + "', '" + listData[2]
                        + "', '" + listData[3] + "', " + listData[4] + ", '" + listData[5] + "','" + listData[6] + "','" + listData[7] + "','" + listData[8] + "');";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = false;
                }
                else
                {
                    conn.getDataSet().Clear();
                    stringSQL = "UPDATE tbl_anamnesis SET cedula_paciente = '" + listData[0] + "', medico_cabecera= '" + listData[1]
                        + "', tipo_sangre='" + listData[2] + "', persona_avisar='" + listData[3] + "', telefono_emergencia=" + listData[4]
                        + ", direccion'" + listData[5] + "', parentesco='" + listData[6] + "', queja_principal='" + listData[7] + "', historia_queja_historia='" + listData[8]
                        + "' WHERE cedula_paciente='" + listData[0] + "';";
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
