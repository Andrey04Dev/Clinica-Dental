using Clinica.forms;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportesViewer : Form
    {
        public CapaNegocio.Clases.Login session;
        CapaNegocio.Clases.Reportes rpt;
        CapaGlobal.Clases.Messages mssg;
        public ReportesViewer()
        {
            mssg = new CapaGlobal.Clases.Messages();
            rpt = new CapaNegocio.Clases.Reportes();
            session = new CapaNegocio.Clases.Login();
            InitializeComponent();
        }

        private void ReportesViewer_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument myreport = new ReportDocument();
                //Para poder usar las propiedades de Crystal Reports
                List<string> listvalues = new List<string>();
                // Guardará los datos que alimentará la consulta del reporte  
                switch (this.Tag.ToString())
                {
                    case "0":

                        //Cargamos el reporte de Todas la Películas desde la respectiva carpeta  
                        myreport.Load(@"..\..\Reportes\Todos_pacientes.rpt");
                        //Indicamos el reporte (índice del combo)                     
                        myreport.SetDataSource(rpt.getReportesSQL(session, listvalues, this.Tag.ToString()));
                        myreport.SetParameterValue("prm_dato", "Reportes de todos los pacientes");
                        //LLenamos el parámetro creado en el reporte              

                        crv_viewer.ReportSource = myreport;

                        break;
                    case "1": //Cargamos el reporte por Película individual            
                        listvalues.Add(getData()); //Usando el formulario buscar definimos cual dato solicitar  
                        myreport.Load(@"..\..\Reportes\Reporte_paciente.rpt");
                        //Indicamos el reporte (índice del combo)                      
                        myreport.SetDataSource(rpt.getReportesSQL(session, listvalues, this.Tag.ToString()));
                        //LLenamos los parámetros creados en el reporte               
                        myreport.SetParameterValue("prm_dato", "Reportes del expediente");
                        crv_viewer.ReportSource = myreport;

                        break;
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private string getData()
        {             //Invocamos nuevo formulario          
            Buscar formSearch = new Buscar();
            formSearch.lbl_datasearch.Text += " Digite la cedula o  nombre";
            //Usamos el parámetro público de los formularios denominado TAG para pasar el tipo de búsqueda   
            formSearch.Tag = "buscar_expediente";
            formSearch.session = this.session; //Paso del objeto de la conexión         
            formSearch.ShowDialog();
            //Si el formulario de búsqueda devuelve datos se procede a llenar el formulario actual con los datos devueltos        
            if (formSearch.resultData.Count != 0)
            {
                return formSearch.resultData[0]; //retorna el valor seleccionado       
            }
            else
            {
                return null;
            }
        }


    }
}
