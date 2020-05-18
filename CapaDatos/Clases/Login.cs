using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class Login
    {
        Conexion conn;
        CapaGlobal.Clases.Messages mssg;

        public Login()
        {
            //Inicializamos el constructor con los datos de de conexion
            conn = new Conexion('2', "bd_clinica", "localhost", "root", "123", "");
            mssg = new CapaGlobal.Clases.Messages();
        }

        public bool loginSystem(String user, String password)
        {
            try
            {
                //Comprobamos si el usuario y el password en MD5 son correctos
                conn.querySQL("SELECT username FROM tbl_users WHERE tbl_users.username = '"
                    + user + "' AND tbl_users.password ='" + password + "'");
                conn.fillDataset("tbl_users", "");

                //Si obtenemos al menos una fila nos logueamos en el sistema devolviendo verdadero
                if (conn.getDataSet().Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
                return false;
            }
        }

        //Función de desconexión
        public void logoutSystem()
        {
            try
            {
                conn.closeConexion();
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        //Obtenemos la conexión actual
        public Conexion getConnection()
        {
            return this.conn;
        }
    }
}
