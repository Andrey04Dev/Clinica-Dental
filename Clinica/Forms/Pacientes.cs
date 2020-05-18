using CapaGlobal.Clases;
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
    public partial class Pacientes : Form
    {
        public CapaNegocio.Clases.Login sesion;
        //Instanciamos la variable de la clase Mensajes
        CapaGlobal.Clases.Messages mssg;
        //Instanciamos la variable de la clase Movies
        CapaNegocio.Clases.Paciente paciente;
        public Pacientes()
        {
            mssg = new CapaGlobal.Clases.Messages();
            sesion = new CapaNegocio.Clases.Login();
            paciente = new CapaNegocio.Clases.Paciente();
            InitializeComponent();
        }

        public CapaNegocio.Clases.Login session { get; set; }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que los campos de texto requeridos no estén vacíos
                if (checkEmpty())
                {
                    

                    //Actualizamos en caso de existir el código, sino insertamos
                    if (paciente.editPaciente(sesion, getDataForm()))
                    {
                        mssg.showMessage("", "info", "success_update");
                    }
                    else
                    {
                        mssg.showMessage("", "info", "success_insert");
                    }
                }
                else
                {
                    mssg.showMessage("", "warning", "empty_data");
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            limpiar_campos();
        }
        private bool checkEmpty()
        {
                if (txt_cedula.Text != "" && txt_nombre.Text != ""
                && txt_apellido.Text != "" && txt_direccion.Text != ""
                && txt_edad.Text != "" && txt_lugar_nacimiento.Text != ""
                && txt_telefono.Text != "" && txt_mcabecera.Text != ""
                && txt_edad.Text != ""
                && txt_queja.Text != ""
                && txt_telefono_emergencia.Text != ""
                && txt_pareentesco.Text != "")
                {
                    return true;
                }

                return false;
            
            
        }

        private void limpiar_campos()
        {
                txt_nombre.Text = "";
                txt_apellido.Text = "";
                txt_cedula.Text = "";
                txt_direccion.Text = "";
                txt_lugar_nacimiento.Text = "";
                txt_telefono.Text = "";
                txt_edad.Text = "";
                txt_enfermedad.Text = "";
                txt_mcabecera.Text = "";
                txt_edad.Text = "";
                txt_queja.Text = "";
                txt_telefono_emergencia.Text = "";
                txt_pareentesco.Text = "";
            
        }

        private void fillForm(List<string> listData)
        {
                txt_cedula.Text = listData[0];
                txt_nombre.Text = listData[1];
                txt_apellido.Text = listData[2];
                txt_telefono.Text = listData[3];
                txt_direccion.Text = listData[4];
                txt_edad.Text = listData[5];
                cmb_sexo.Text = listData[6];
                txt_lugar_nacimiento.Text = listData[7];
                txt_enfermedad.Text = listData[8];
                if (listData[9] != "No")
                {
                    chb_si.Checked = true;
                }
                else
                {
                    chb_si.Checked = false;
                }
                if (listData[10] != "No")
                {
                    chb_si1.Checked = true;
                }
                else
                {
                    chb_si1.Checked = false;
                }
                txt_mcabecera.Text = listData[11];
                cmb_sangre.Text = listData[12];
                txt_telefono_emergencia.Text = listData[13];
                txt_pareentesco.Text = listData[14];
                txt_queja.Text = listData[15];
            
        }

        private List<string> getDataForm()
        {
                List<string> listDataForm = new List<string>();

                listDataForm.Add(txt_cedula.Text);
                listDataForm.Add(txt_nombre.Text);
                listDataForm.Add(txt_apellido.Text);
                listDataForm.Add(txt_telefono.Text);
                listDataForm.Add(txt_direccion.Text);
                listDataForm.Add(txt_edad.Text);
                listDataForm.Add(cmb_sexo.Text);
                listDataForm.Add(txt_lugar_nacimiento.Text);
                listDataForm.Add(txt_enfermedad.Text);

                if (chb_si.Checked)
                {
                    listDataForm.Add("Si");
                }
                else
                {
                    listDataForm.Add("No");
                }
                if (chb_si1.Checked)
                {
                    listDataForm.Add("Si");
                }
                else
                {
                    listDataForm.Add("No");
                }
                listDataForm.Add(txt_mcabecera.Text);
                listDataForm.Add(cmb_sangre.Text);
                listDataForm.Add(txt_telefono_emergencia.Text);
                listDataForm.Add(txt_pareentesco.Text);
                listDataForm.Add(txt_queja.Text);

                return listDataForm;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar buscar = new Buscar();
                buscar.Tag = "buscar_paciente";
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

        private void chb_si_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chb_si.Checked)
                {
                    chb_si.Text = "Si";
                }
                else
                {
                    chb_si.Text = "No";
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void chb_si1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chb_si1.Checked)
                {
                    chb_si1.Text = "Si";
                }
                else
                {
                    chb_si1.Text = "No";
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
           
        }

        private void btn_odontograma_Click(object sender, EventArgs e)
        {
            try
            {
                Odontograma odonto = new Odontograma();
                odonto.ShowDialog();
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
           
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_lugar_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_enfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloNumeros(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloNumeros(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void Pacientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_pareentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void txt_queja_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloLetras(e);

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    try
                    {
                        //Comprobamos que los campos de texto requeridos no estén vacíos
                        if (checkEmpty())
                        {


                            //Actualizamos en caso de existir el código, sino insertamos
                            if (paciente.editPaciente(sesion, getDataForm()))
                            {
                                mssg.showMessage("", "info", "success_update");
                            }
                            else
                            {
                                mssg.showMessage("", "info", "success_insert");
                            }
                        }
                        else
                        {
                            mssg.showMessage("", "warning", "empty_data");
                        }
                    }
                    catch (Exception ex)
                    {
                        mssg.showMessage(ex.Message, "error", "");
                    }
                    limpiar_campos();
                }

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
           
        }

        private void txt_telefono_emergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloNumeros(e);
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_cedula.Text != ""){
                    if (MessageBox.Show("¿Desea Eliminar?", "Se ha eliminado con exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    mssg.showMessage("", "info", "sucess_delete");
                    paciente.eliminarPaciente(sesion, txt_cedula.Text);
                    limpiar_campos();
                }
                    
                }
                else
                {
                    MessageBox.Show("Debe llenar la casilla de la cedula para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }

        }

        

    }
}
