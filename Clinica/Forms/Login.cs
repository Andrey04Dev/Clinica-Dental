using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Clinica.Forms 
{
    public partial class Login : Form
    {
        public CapaNegocio.Clases.Login sesion;
        CapaGlobal.Clases.Messages mssg;
        public Login()
        {
            mssg = new CapaGlobal.Clases.Messages();
            sesion = new CapaNegocio.Clases.Login(); 

            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos los campos de usuario y password, ademas removemos los caracteres de espacios 
                //para evitar inserción de datos o código malicioso
                if (sesion.loginSystem(txt_usuario.Text.Replace(" ", ""), txt_password.Text.Replace(" ", "")))
                {
                    //Inicializamos e invocamos el llamado de un nuevo formulario
                    MessageBox.Show("Bienvenido Usuario", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal formMain = new Principal();
                    this.Visible = false;
                    //Pasamos por parámetro público la variable session, la cual contiene la conexión actual
                    formMain.session = this.sesion;
                    formMain.Show();
                }
                else
                {
                    mssg.showMessage("", "warning", "fail_auth");
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    //Comprobamos los campos de usuario y password, ademas removemos los caracteres de espacios 
                    //para evitar inserción de datos o código malicioso
                    if (sesion.loginSystem(txt_usuario.Text.Replace(" ", ""), txt_password.Text.Replace(" ", "")))
                    {
                        //Inicializamos e invocamos el llamado de un nuevo formulario
                        Principal formMain = new Principal();
                        this.Visible = false;
                        //Pasamos por parámetro público la variable session, la cual contiene la conexión actual
                        formMain.session = this.sesion;
                        formMain.Show();
                    }
                    else
                    {
                        mssg.showMessage("", "warning", "fail_auth");
                    }
                }
                catch (Exception ex)
                {
                    mssg.showMessage(ex.Message, "error", "");
                }
                
            }
        }

    }
}
