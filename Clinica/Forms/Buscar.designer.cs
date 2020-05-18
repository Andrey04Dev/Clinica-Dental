namespace Clinica.forms
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.lbl_datasearch = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.ltv_data = new System.Windows.Forms.ListView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_datasearch
            // 
            this.lbl_datasearch.AutoSize = true;
            this.lbl_datasearch.Location = new System.Drawing.Point(9, 9);
            this.lbl_datasearch.Name = "lbl_datasearch";
            this.lbl_datasearch.Size = new System.Drawing.Size(103, 13);
            this.lbl_datasearch.TabIndex = 0;
            this.lbl_datasearch.Text = "Búsqueda de Datos:";
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(12, 25);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(462, 22);
            this.txb_search.TabIndex = 1;
            this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
            // 
            // ltv_data
            // 
            this.ltv_data.FullRowSelect = true;
            this.ltv_data.GridLines = true;
            this.ltv_data.Location = new System.Drawing.Point(12, 51);
            this.ltv_data.Name = "ltv_data";
            this.ltv_data.Size = new System.Drawing.Size(462, 198);
            this.ltv_data.TabIndex = 2;
            this.ltv_data.UseCompatibleStateImageBehavior = false;
            this.ltv_data.View = System.Windows.Forms.View.Details;
            this.ltv_data.DoubleClick += new System.EventHandler(this.ltv_data_DoubleClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(399, 255);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 35);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Salir";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 301);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.ltv_data);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.lbl_datasearch);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_datasearch;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.ListView ltv_data;
        private System.Windows.Forms.Button btn_exit;
    }
}