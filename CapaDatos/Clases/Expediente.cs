    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Clases
{
    public class Expediente
    {
        Funciones func;
        CapaGlobal.Clases.Messages mssg;
        public Expediente()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        public void searchExpediente(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT cedula_paciente AS Cedula, nombre_paciente AS Nombre,apellido_paciente AS Apellido, telefono_paciente AS Telefono,"
                            + "  sexo_paciente AS Sexo, lugar_nacimiento AS Lugar, enfermedad_padecimiento AS Enfermedad,"
                            + " problema_presion AS Presion, fiebre_reumatica AS Fiebre,"
                            + " medico_cabecera AS Medico, tipo_sangre AS Tipo, telefono_emergencia AS Telefono, parentesco AS Parentesco, historia_queja_medica AS Historia"
                            + " FROM tbl_paciente "
                            + " WHERE (UPPER(cedula_paciente) LIKE UPPER('" + textdata + "%')"
                            + " OR UPPER(nombre_paciente) LIKE UPPER('" + textdata + "%'))";
                func.fillListView(conn, listView, stringSQL);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        public List<string> getExpediente(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT cedula_paciente, nombre_paciente, apellido_paciente, telefono_paciente, sexo_paciente, enfermedad_padecimiento, problema_presion, fiebre_reumatica,"
                            + " medico_cabecera, tipo_sangre, telefono_emergencia, parentesco, historia_queja_medica"
                            + " FROM tbl_paciente"
                            + " WHERE tbl_paciente.cedula_paciente = '" + listView.SelectedItems[0].Text + "'";
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

