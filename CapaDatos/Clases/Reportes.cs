using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Reportes
    {
        CapaGlobal.Clases.Messages mssg;

        public Reportes()
        {
            mssg = new CapaGlobal.Clases.Messages();
        }

        public DataSet getReportSQL( Conexion conn, List<string> listvalues, string numrpt)
        {
            try
            {
                string stringSQL = "";
                switch (numrpt)
                {
                    case"0":
                        conn.getDataSet().Clear();
                        stringSQL = "SELECT cedula_paciente, nombre_paciente, apellido_paciente, telefono_paciente, direccion_paciente,"
                            +"edad_paciente, sexo_paciente, lugar_nacimiento, enfermedad_padecimiento, problema_presion, fiebre_reumatica"
                            +"FROM tbl_paciente ORDER BY nombre_paciente ASC";
                        conn.querySQL(stringSQL);
                        conn.fillDataset("tbl_paciente", conn.getDataSet().DataSetName);
                        break;

                    case "1":
                        conn.getDataSet().Clear();
                        stringSQL = "SELECT cedula_paciente, nombre_paciente, apellido_paciente, telefono_paciente, direccion_paciente,"
                            + " edad_paciente, sexo_paciente, lugar_nacimiento, enfermedad_padecimiento, problema_presion, fiebre_reumatica,"
                            + " medico_cabecera, tipo_sangre, telefono_emergencia, parentesco, historia_queja_medica "
                            + " FROM tbl_paciente "
                            + " WHERE cedula_paciente = '" + listvalues[0] + "'";
                        conn.querySQL(stringSQL);
                        conn.fillDataset("tbl_paciente", conn.getDataSet().DataSetName);
                        break;


                }

            }catch(Exception ex){
                mssg.showMessage("Seleccione 'Aceptar' para mostrar el reporte", "", ""); 
                return null;
            }
            return conn.getDataSet();
        }
    }
}
