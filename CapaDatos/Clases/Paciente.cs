using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Clases
{
    public class Paciente
    {  
        Funciones func;
        CapaGlobal.Clases.Messages mssg;

        public Paciente()
        {
            mssg = new CapaGlobal.Clases.Messages();
            func = new Funciones();
        }

        /* Función para búsqueda de datos de Películas mediante un sólo parámetro (nombre o código)
         * y llenado de resultado de datos (se invoca el llenado del ListView)
         * */
        public void searchPaciente(Conexion conn, System.Windows.Forms.ListView listView, String textdata)
        {
            try
            {
                string stringSQL = "SELECT cedula_paciente AS Cedula, nombre_paciente AS Nombre,apellido_paciente AS Apellido, telefono_paciente AS Telefono,"
                + " direccion_paciente AS Direccion, edad_paciente AS Edad, sexo_paciente AS Sexo, lugar_nacimiento AS Lugar, enfermedad_padecimiento AS Enfermedad,"
                + " problema_presion AS Presion, fiebre_reumatica AS Fiebre, medico_cabecera AS Medico, tipo_sangre AS Tipo, telefono_emergencia AS Telefono_Emergencia, parentesco AS Parentesco, historia_queja_medica AS Queja_Medica"
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


        /* Obtiene una lista dinámica de Strings con los datos de las Películas
         * Se llena dicha lista con los resultados de la consulta
         */
        public List<string> getPaciente(Conexion conn, System.Windows.Forms.ListView listView)
        {
            List<string> listData = new List<string>();

            try
            {
                conn.getDataSet().Clear();
                string stringSQL = "SELECT cedula_paciente, nombre_paciente, apellido_paciente, telefono_paciente, direccion_paciente, edad_paciente, sexo_paciente, lugar_nacimiento, enfermedad_padecimiento, problema_presion, fiebre_reumatica,"
                    + "medico_cabecera, tipo_sangre, telefono_emergencia, parentesco, historia_queja_medica"
                    + " FROM tbl_paciente "
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

        /* Función de edición de datos de Películas, decide insertar en caso 
         * de que la consulta no devuelva nada con el código actual, 
         * en caso de existir el registro lo actualiza
         */

        public bool editPaciente(Conexion conn, List<string> listData)
        {
            bool edit = false;

            try
            {
               // conn.getDataSet().Clear();
                string stringSQL = "SELECT * FROM tbl_paciente WHERE cedula_paciente = '" + listData[0] + "'";
                conn.querySQL(stringSQL);
                conn.fillDataset("", "");

                if (conn.getDataSet().Tables[0].Rows.Count == 0)
                {
                    conn.getDataSet().Clear();
                    stringSQL = "   INSERT INTO tbl_paciente (cedula_paciente, nombre_paciente, apellido_paciente, telefono_paciente, direccion_paciente, edad_paciente, sexo_paciente, lugar_nacimiento, enfermedad_padecimiento, problema_presion, fiebre_reumatica,"
                        + " medico_cabecera, tipo_sangre, telefono_emergencia, parentesco, historia_queja_medica )"
                        + " VALUES ('" + listData[0] + "','" + listData[1] + "', '" + listData[2]
                        + "', " + listData[3] + ", '" + listData[4] + "', " + listData[5] + ",'" + listData[6] + "','" + listData[7] + "','" + listData[8] + "','" + listData[9] + "','" + listData[10]
                        + "', '" + listData[11] + "','" + listData[12] + "'," + listData[13] + ",'" + listData[14] + "','" + listData[15] + "');";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = false;
                }
                else
                {
                    conn.getDataSet().Clear();
                    stringSQL = "UPDATE tbl_paciente SET cedula_paciente = '" + listData[0] + "', nombre_paciente= '" + listData[1]
                        + "', apellido_paciente='" + listData[2] + "', telefono_paciente=" + listData[3] + ", direccion_paciente='" + listData[4]
                        + "', edad_paciente=" + listData[5] + ", sexo_paciente='" + listData[6] + "', lugar_nacimiento='" + listData[7] + "', enfermedad_padecimiento='" + listData[8]
                        + "', problema_presion='" + listData[9] + "', fiebre_reumatica='" + listData[10] + "', medico_cabecera='" + listData[11] + "', tipo_sangre='" + listData[12]
                        + "', telefono_emergencia=" + listData[13] + ", parentesco='" + listData[14] + "', historia_queja_medica='" + listData[15]
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

        public bool eliminarPaciente(Conexion conn, String textdata)
        {
            bool edit = false;

            try
            {
               
                    conn.getDataSet().Clear();
                    string stringSQL = "DELETE FROM tbl_paciente WHERE cedula_paciente= '"+ textdata+ "'";
                    conn.querySQL(stringSQL);
                    conn.fillDataset("", "");

                    edit = true;

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }

            return edit;
        }
    }
}
