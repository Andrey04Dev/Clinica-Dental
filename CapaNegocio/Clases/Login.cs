using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Login
    {
        CapaDatos.Clases.Login login;
        public Login()
        {
            login = new CapaDatos.Clases.Login();
        }
        public bool loginSystem(string user, string password)
        {
            return login.loginSystem(user, password);
        }
        public void logoutSystem()
        {
            login.logoutSystem();
        }

        public CapaDatos.Clases.Conexion getConnection()
        {
            return login.getConnection();
        }
    }
}
