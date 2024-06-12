namespace WindForm11_06_24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.CargarTiempos = new System.Windows.Forms.Button();
            this.VerResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(114, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Competidor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // CargarTiempos
            // 
            this.CargarTiempos.Location = new System.Drawing.Point(114, 96);
            this.CargarTiempos.Name = "CargarTiempos";
            this.CargarTiempos.Size = new System.Drawing.Size(174, 23);
            this.CargarTiempos.TabIndex = 1;
            this.CargarTiempos.Text = "Cargar tiempos de Competidores";
            this.CargarTiempos.UseVisualStyleBackColor = true;
            this.CargarTiempos.Click += new System.EventHandler(this.btnCargarTiempos_Click);
            // 
            // VerResultados
            // 
            this.VerResultados.Location = new System.Drawing.Point(114, 153);
            this.VerResultados.Name = "VerResultados";
            this.VerResultados.Size = new System.Drawing.Size(174, 23);
            this.VerResultados.TabIndex = 2;
            this.VerResultados.Text = "Ver Resultados";
            this.VerResultados.UseVisualStyleBackColor = true;
            this.VerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 217);
            this.Controls.Add(this.VerResultados);
            this.Controls.Add(this.CargarTiempos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button CargarTiempos;
        private System.Windows.Forms.Button VerResultados;
    }
}

