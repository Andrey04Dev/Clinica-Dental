namespace Clinica.Forms
{
    partial class FacturaRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Encabezado";
            reportDataSource1.Value = this.EFacturaBindingSource;
            reportDataSource2.Name = "Detalle";
            reportDataSource2.Value = this.EArticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinica.Forms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1352, 723);
            this.reportViewer1.TabIndex = 0;
            // 
            // EFacturaBindingSource
            // 
            this.EFacturaBindingSource.DataSource = typeof(Clinica.Forms.EFactura);
            // 
            // EArticuloBindingSource
            // 
            this.EArticuloBindingSource.DataSource = typeof(Clinica.Forms.EArticulo);
            // 
            // FacturaRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FacturaRpt";
            this.Text = "FacturaRpt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FacturaRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EFacturaBindingSource;
        private System.Windows.Forms.BindingSource EArticuloBindingSource;
    }
}