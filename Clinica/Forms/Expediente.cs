using Clinica.forms;
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
    public partial class Expediente : Form
    {
        public CapaNegocio.Clases.Login sesion;
        CapaGlobal.Clases.Messages mssg;
        public Expediente()
        {
            sesion = new CapaNegocio.Clases.Login();
            mssg = new CapaGlobal.Clases.Messages();
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar buscar = new Buscar();
                buscar.Tag = "buscar_expediente";
                buscar.session = this.sesion;
                buscar.ShowDialog();

                if (buscar.resultData.Count != 0)
                {
                    fillForm(buscar.resultData);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private void fillForm(List<string> listData)
        {

            txt_cedula.Text = listData[0];
            txt_nombre.Text = listData[1];
            txt_apellido.Text = listData[2];
            txt_telefono.Text = listData[3];
            txt_sexo.Text = listData[4];
            txt_enfermedad.Text = listData[5];
            txt_presion_alta.Text = listData[6];
            txt_fiebre_reumatica.Text = listData[7];
            txt_medico.Text = listData[8] ;
            txt_tipo.Text = listData[9];
            txt_telefono_emergencia.Text = listData[10];
            txt_parentesco.Text = listData[11];
            txt_historia_queja.Text = listData[12];
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
