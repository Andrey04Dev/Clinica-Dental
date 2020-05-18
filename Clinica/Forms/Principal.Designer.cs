namespace Clinica.Forms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_expediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_proforma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_acerca = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ayuda = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.Image")));
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(144, 137);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(181, 77);
            this.btn_ingresar.TabIndex = 1;
            this.btn_ingresar.Text = "Ingresar Paciente";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_expediente
            // 
            this.btn_expediente.FlatAppearance.BorderSize = 0;
            this.btn_expediente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btn_expediente.Image = ((System.Drawing.Image)(resources.GetObject("btn_expediente.Image")));
            this.btn_expediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_expediente.Location = new System.Drawing.Point(563, 137);
            this.btn_expediente.Name = "btn_expediente";
            this.btn_expediente.Size = new System.Drawing.Size(202, 77);
            this.btn_expediente.TabIndex = 3;
            this.btn_expediente.Text = "Expediente Paciente";
            this.btn_expediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_expediente.UseVisualStyleBackColor = true;
            this.btn_expediente.Click += new System.EventHandler(this.btn_expediente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(475, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLÍNICA DENTAL LAUREL";
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(784, 137);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(175, 77);
            this.btn_reportes.TabIndex = 4;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_proforma
            // 
            this.btn_proforma.FlatAppearance.BorderSize = 0;
            this.btn_proforma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btn_proforma.Image = ((System.Drawing.Image)(resources.GetObject("btn_proforma.Image")));
            this.btn_proforma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proforma.Location = new System.Drawing.Point(344, 137);
            this.btn_proforma.Name = "btn_proforma";
            this.btn_proforma.Size = new System.Drawing.Size(198, 77);
            this.btn_proforma.TabIndex = 2;
            this.btn_proforma.Text = "Proforma";
            this.btn_proforma.UseVisualStyleBackColor = true;
            this.btn_proforma.Click += new System.EventHandler(this.btn_proforma_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 457);
            this.panel1.TabIndex = 5;
            // 
            // lbl_acerca
            // 
            this.lbl_acerca.AutoSize = true;
            this.lbl_acerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_acerca.Location = new System.Drawing.Point(1231, 9);
            this.lbl_acerca.Name = "lbl_acerca";
            this.lbl_acerca.Size = new System.Drawing.Size(59, 20);
            this.lbl_acerca.TabIndex = 6;
            this.lbl_acerca.TabStop = true;
            this.lbl_acerca.Text = "Acerca";
            this.lbl_acerca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_acerca_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(976, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda.Location = new System.Drawing.Point(1296, 9);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(54, 20);
            this.lbl_ayuda.TabIndex = 7;
            this.lbl_ayuda.TabStop = true;
            this.lbl_ayuda.Text = "Ayuda";
            this.lbl_ayuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ayuda_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 623);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_acerca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_proforma);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_expediente);
            this.Controls.Add(this.btn_ingresar);
            this.Name = "Principal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_expediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_proforma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_acerca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lbl_ayuda;
    }
}