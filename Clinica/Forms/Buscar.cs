using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.forms
{
    public partial class Buscar : Form
    {
        public CapaNegocio.Clases.Login session;
        CapaGlobal.Clases.Messages mssg;
        CapaNegocio.Clases.Paciente paciente;
        CapaNegocio.Clases.Expediente expediente;
        CapaNegocio.Clases.Tratamiento tratamiento;
        public List<string> resultData;
        
        public Buscar()
        {
            mssg = new CapaGlobal.Clases.Messages();
            session = new CapaNegocio.Clases.Login();
            paciente = new CapaNegocio.Clases.Paciente();
            expediente = new CapaNegocio.Clases.Expediente();
            tratamiento = new CapaNegocio.Clases.Tratamiento();
            resultData = new List<string>();

            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_search.Text != "")
                {
                    //Se evalua la propiedad Tag del forulario Origen para saber que datos buscar
                    switch (this.Tag.ToString())
                    {
                        case "buscar_paciente":
                            paciente.searchPacientes(session, ltv_data, txb_search.Text);
                            break;

                        case "buscar_expediente":
                            expediente.searchExpediente(session, ltv_data, txb_search.Text);
                            break;

                        case "buscar_tratamiento":
                            tratamiento.searchTratamiento(session, ltv_data, txb_search.Text);
                            break;

                    }

                }
                else
                {
                    ltv_data.Clear();
                }

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private void ltv_data_DoubleClick(object sender, EventArgs e)
        {
            /* Al hacer doble click en un ítem del ListView se llena el formulario 
             con la informacion seleccionada mediante el retorno de una lista de Strings*/
            try
            {
                if (txb_search.Text != "")
                {
                    //Se evalua la propiedad Tag del forulario Origen para saber que datos buscar
                    switch (this.Tag.ToString())
                    {
                        case "buscar_paciente":
                            resultData = paciente.getDataPaciente(session, ltv_data);
                            MessageBox.Show("Se ha encontado el paciente con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "buscar_expediente":
                            resultData = expediente.getExpediente(session, ltv_data);
                            MessageBox.Show("Se ha encontrado el expediente con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "buscar_tratamiento":
                            resultData = tratamiento.getDataTratamiento(session, ltv_data);
                            MessageBox.Show("Se ha encontrado el tratamiento con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }

                }
                else
                {
                    ltv_data.Clear();
                }

                this.Close();

            }catch(Exception ex){
                mssg.showMessage(ex.Message, "error", "");
            }
        }
    }
}
