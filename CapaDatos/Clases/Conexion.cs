using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Conexion
    {
        OdbcConnection connection;
        OdbcDataAdapter recordset;
        DataSet setData;
        CapaGlobal.Clases.Messages mssg = new CapaGlobal.Clases.Messages();

        //Función principal de conexión
        public Conexion(char opcion, string basedatos, string servidor, string usuario, string password, string puerto)
        {
            openConexion(getStringConexion(opcion, basedatos, servidor, usuario, password, puerto));
        }

        //Obtención de la Cadena de Conexión basado en la opción elegida (option)
        public string getStringConexion(char option, string database, string server, string user, string password, string port)
        {

            string stringConnection = "";

            switch (option)
            {
                case '1':
                    //CONEXION SQL SERVER (OLEDB)
                    stringConnection = "Provider=SQLOLEDB; Data Source=" + server + "; Integrated Security=SSPI ; Initial Catalog=" + database + ";";
                    break;
                case '2':
                    //CONEXION MySQL con Driver 3.51 (ODBC)
                    stringConnection = "DRIVER={MySQL ODBC 3.51 Driver}; Database=" + database + "; Port=" + port + "; Server=" + server + "; Uid=" + user + "; Password=" + password + ";";
                    break;
                case '3':
                    //CONEXION PostgreSQL (ODBC)
                    stringConnection = "DRIVER={PostgreSQL ODBC Driver(UNICODE)}; DATABASE=" + database + "; PORT=" + port + "; SERVER=" + server + "; UID=" + user + "; PWD=" + password + ";";
                    break;
            }
            return stringConnection;
        }

        //Función para abrir la conexión ODBC
        public bool openConexion(string stringConnection)
        {
            try
            {
                connection = new OdbcConnection(stringConnection);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
                return false;
            }

        }

        //Función para cerrar la conexión ODBC
        public void closeConexion()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        //Función para ejecutar consultas SQL 
        public void querySQL(string query)
        {
            try
            {
                recordset = new OdbcDataAdapter(query, connection);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        //Función de llenado e inicialización del resultado de datos
        public void fillDataset(string tableName, string DataSetName)
        {
            try
            {
                if (DataSetName == "")
                {
                    setData = new DataSet();
                }
                else
                {
                    setData = new DataSet(DataSetName);
                }

                if (tableName == "")
                {
                    recordset.Fill(setData);
                }
                else
                {
                    recordset.Fill(setData, tableName);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        //Función de obtención del resultado de datos
        public DataSet getDataSet()
        {
            return setData;
        }

        //Función de obtención de la instancia de Conexión
        public OdbcConnection getConnection()
        {
            return this.connection;
        }
    }
}
