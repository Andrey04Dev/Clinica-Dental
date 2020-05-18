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
    public partial class Reportes : Form
    {
        public CapaNegocio.Clases.Login session;
        CapaGlobal.Clases.Messages mssg;
        public Reportes()
        {
            InitializeComponent();
            mssg = new CapaGlobal.Clases.Messages();
            session = new CapaNegocio.Clases.Login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportesViewer reportes = new ReportesViewer();
                reportes.Tag = cmb_reporte.SelectedIndex;
                reportes.session = this.session;
                reportes.ShowDialog();
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

    }
}
