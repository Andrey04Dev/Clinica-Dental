using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGlobal.Clases
{
    public class Messages
    {

        //Selecciona el tipo de ícono a mostrar en la caja de diálogo del mensaje (Información, Alerta y Error)
        public void showMessage(string text, string type, string reason)
        {
            if (type == "error")
            {
                MessageBox.Show(messages(reason, text), reason, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (type == "warning")
                {
                    MessageBox.Show(messages(reason, text), reason, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(messages(reason, text), reason, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        // Función que devuelve la cadena con el mensaje según la razón indicada
        private string messages(string reason, string text)
        {
            string message = "";

            switch (reason)
            {
                //Mensaje de inserción exitosa
                case "success_insert":
                    message = "La información ha sido ingresada correctamente";
                    break;
                //Mensaje de actualización exitosa
                case "success_update":
                    message = "La información ha sido actualizada correctamente";
                    break;
                //Mensaje de eliminación exitosa
                case "success_delete":
                    message = "La información ha sido eliminada correctamente";
                    break;
                //Mensaje de fallo en la autenticación
                case "fail_auth":
                    message = "El Usuario o Password suministrados son incorrectos";
                    break;
                //Mensaje de sesión expirada
                case "expired_session":
                    message = "Su sesión ha expirado, por favor vuelva a ingresar sus datos de autentificación.";
                    break;
                //Mensaje de indicación de campos requeridos
                case "empty_data":
                    message = "Se deben llenar todos los campos requeridos";
                    break;
                case "bienvenida":
                    message = "Bienvenido Usuario";
                    break;

                case "":
                    message = text;
                    break;
            }
            return message;
        }
    }
}
