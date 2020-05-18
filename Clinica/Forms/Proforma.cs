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
    public partial class Proforma : Form
    {
        public CapaNegocio.Clases.Login sesion;
        //Instanciamos la variable de la clase Mensajes
        CapaGlobal.Clases.Messages mssg;
        //Instanciamos la variable de la clase Movies
        CapaNegocio.Clases.Paciente paciente;
        public Proforma()
        {
            mssg = new CapaGlobal.Clases.Messages();
            sesion = new CapaNegocio.Clases.Login();
            paciente = new CapaNegocio.Clases.Paciente();
            InitializeComponent();
            
        }

        private void buscarp_Click(object sender, EventArgs e)
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

                dataGridViewproforma.Rows.Clear();
                contador_fila = 0;
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
            txt_telefono.Text = listData[3];
            txt_direccion.Text = listData[4];
        }

        private void fillForm2(List<string> listData)
        {

            txt_tratamiento.Text = listData[0];
            txt_precio.Text = listData[1];
        }

        private List<string> getDataForm()
        {
            List<string> listDataForm = new List<string>();

            listDataForm.Add(txt_cedula.Text);
            listDataForm.Add(txt_nombre.Text);
            listDataForm.Add(txt_telefono.Text);
            listDataForm.Add(txt_direccion.Text);
          
            return listDataForm;

        }
        public static int contador_fila;
        public static double totall;
        String tratamiento;
        String cantidad;
        String precio;
        
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cedula.Text != "" && txt_tratamiento.Text != "" && txt_precio.Text != "" && txt_cantidad.Text != "")
                {
                    tratamiento = txt_tratamiento.Text;
                    cantidad = txt_cantidad.Text;
                    precio = txt_precio.Text;

                    dataGridViewproforma.Rows.Add(tratamiento, cantidad, precio);
                    double total = Convert.ToDouble(dataGridViewproforma.Rows[contador_fila].Cells[1].Value) * Convert.ToDouble(dataGridViewproforma.Rows[contador_fila].Cells[2].Value);
                    dataGridViewproforma.Rows[contador_fila].Cells[3].Value = total;
                    contador_fila++;


                    totall = 0;
                    foreach (DataGridViewRow Fila in dataGridViewproforma.Rows)
                    {
                        totall += Convert.ToDouble(Fila.Cells[3].Value);
                    }

                    txt_total.Text = totall.ToString();
                    MessageBox.Show("Se han agregado los tratamientos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ninguna casilla debe de estar vacia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Proforma_Load(object sender, EventArgs e)
        {
            try
            {
         
                dataGridViewproforma.AutoGenerateColumns = false;
                
                dataGridViewproforma.Columns["Column1"].DataPropertyName = "Tratamiento";
                dataGridViewproforma.Columns["Column2"].DataPropertyName = "Cantidad";
                dataGridViewproforma.Columns["Column3"].DataPropertyName = "Precio";
                dataGridViewproforma.Columns["Column4"].DataPropertyName = "Subtotal";

            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            
        }

        private void InvoiceGenerate()
        {
            //
            //Hacemos una instancia de la clase EFactura para
            //llenarla con los valores contenidos en los controles del Formulario
            EFactura invoice = new EFactura();
           
            invoice.nombre = txt_nombre.Text;
            invoice.cedula = Convert.ToInt32(txt_cedula.Text);
            //invoice.fechaFacturacion = fechaFacturacion.Value.Date;
            

            //Recorremos los Rows existentes actualmente en el control DataGridView
            //para asignar los datos a las propiedades
            foreach (DataGridViewRow row in dataGridViewproforma.Rows)
            {
                EArticulo article = new EArticulo();
                //
                //Vamos tomando los valores de las celdas del row que estamos 
                //recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
                //
                article.nombret = Convert.ToString(row.Cells["Column1"].Value);
                article.cantidad = Convert.ToInt32(row.Cells["Column2"].Value);
                article.precio = Convert.ToInt32(row.Cells["Column3"].Value);
                article.subtotal = Convert.ToInt32(row.Cells["Column4"].Value);
                article.total = Convert.ToInt32(txt_total.Text);

                //
                //Vamos agregando el Item a la lista del detalle
                //
                invoice.Detail.Add(article);
            }

            //
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
            FacturaRpt frm = new FacturaRpt();
            //
            //Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
            //que se mostrara en los parametros creados en el LocalReport, para este ejemplo
            //estamos Seteando los valores directamente pero usted puede usar algun control
            //
           frm.Titulo = "Reporte de Proforma";
            frm.Empresa = "Clinica Dental Laurel";
            //
            //Recuerde que invoice es una Lista Generica declarada en el FacturaRtp, es una lista
            //porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
            //implementen IEnumerable.
            //
            //Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
            frm.Invoice.Add(invoice);
            //
            //Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
            //es un lista del tipo EArticulo bastara con igualarla
            //
            frm.Detail = invoice.Detail;
            frm.Show();
        }

       
       // public static bool AutoGenerateColumns { get; set; }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cedula.Text != "" && txt_tratamiento.Text != "" && txt_precio.Text != "" && txt_cantidad.Text != "" && txt_total.Text != "")
                {
                    InvoiceGenerate();
                    MessageBox.Show("Se generara la preforma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ninguna casilla debe de estar vacia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }  

        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.SoloNumeros(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones.SoloNumeros(e);
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txt_cedula.Text != "" && txt_tratamiento.Text != "" && txt_precio.Text != "" && txt_cantidad.Text != "")
                    {
                        tratamiento = txt_tratamiento.Text;
                        cantidad = txt_cantidad.Text;
                        precio = txt_precio.Text;

                        dataGridViewproforma.Rows.Add(tratamiento, cantidad, precio);
                        double total = Convert.ToDouble(dataGridViewproforma.Rows[contador_fila].Cells[1].Value) * Convert.ToDouble(dataGridViewproforma.Rows[contador_fila].Cells[2].Value);
                        dataGridViewproforma.Rows[contador_fila].Cells[3].Value = total;
                        contador_fila++;


                        totall = 0;
                        foreach (DataGridViewRow Fila in dataGridViewproforma.Rows)
                        {
                            totall += Convert.ToDouble(Fila.Cells[3].Value);
                        }

                        txt_total.Text = totall.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ninguna casilla deberia quedar vacia");
                    }
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private void txt_tratamiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_buscar_tratamiento_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar buscar = new Buscar();
                buscar.Tag = "buscar_tratamiento";
                buscar.session = this.sesion;
                buscar.ShowDialog();

                if (buscar.resultData.Count != 0)
                {
                    fillForm2(buscar.resultData);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    if (txt_cedula.Text != "" && txt_tratamiento.Text != "" && txt_precio.Text != "" && txt_cantidad.Text != "")
                    {
                        totall = totall - (Convert.ToDouble(dataGridViewproforma.Rows[dataGridViewproforma.CurrentRow.Index].Cells[3].Value));
                        txt_total.Text = totall.ToString();

                        dataGridViewproforma.Rows.RemoveAt(dataGridViewproforma.CurrentRow.Index);
                        contador_fila--;
                        mssg.showMessage("", "info", "success_delete");
                    }
                    else
                    {
                        MessageBox.Show("Ninguna casilla debe de estar vacia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    mssg.showMessage("No hay tratamiento ingresados", "", "");
                }
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

    }

        
       
    }

