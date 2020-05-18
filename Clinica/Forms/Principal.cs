using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Forms
{
    public partial class Principal : Form
    {
        public CapaNegocio.Clases.Login session;
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            /*this.Close();
            Pacientes paciente = new Pacientes();
            paciente.sesion = this.session;
            paciente.ShowDialog();*/

            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Pacientes hijo1 = new Pacientes();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            // hijo1.seccion = this.session;//ESTO
            this.panel1.Controls.Add(hijo1);
            this.panel1.Tag = hijo1;
            hijo1.Show();
           
        }

        private void btn_expediente_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Expediente hijo1 = new Expediente();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            // hijo1.seccion = this.session;//ESTO
            this.panel1.Controls.Add(hijo1);
            this.panel1.Tag = hijo1;
            hijo1.Show();

        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Reportes hijo1 = new Reportes();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            // hijo1.seccion = this.session;//ESTO
            this.panel1.Controls.Add(hijo1);
            this.panel1.Tag = hijo1;
            hijo1.Show();
        }

        private void lbl_acerca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.Visible = true;
        }

        private void btn_proforma_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Proforma hijo1 = new Proforma();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            // hijo1.seccion = this.session;//ESTO
            this.panel1.Controls.Add(hijo1);
            this.panel1.Tag = hijo1;
            hijo1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
     
            
            
        }

        private void lbl_ayuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual-Usuario.pdf");

            Process.Start(pdfPath);
        }

        

      

      
    }
}
