namespace WindForm11_06_24
{
    partial class TiemposCompetidores
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
            this.lbNroCompetidor = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.tbTiempo1 = new System.Windows.Forms.TextBox();
            this.tbTiempo2 = new System.Windows.Forms.TextBox();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.btnAgregarTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNroCompetidor
            // 
            this.lbNroCompetidor.AutoSize = true;
            this.lbNroCompetidor.Location = new System.Drawing.Point(132, 85);
            this.lbNroCompetidor.Name = "lbNroCompetidor";
            this.lbNroCompetidor.Size = new System.Drawing.Size(100, 13);
            this.lbNroCompetidor.TabIndex = 0;
            this.lbNroCompetidor.Text = "Número Competidor";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(135, 140);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(42, 13);
            this.lbTiempo.TabIndex = 1;
            this.lbTiempo.Text = "Tiempo";
            // 
            // tbTiempo1
            // 
            this.tbTiempo1.Location = new System.Drawing.Point(225, 140);
            this.tbTiempo1.Name = "tbTiempo1";
            this.tbTiempo1.Size = new System.Drawing.Size(64, 20);
            this.tbTiempo1.TabIndex = 2;
            // 
            // tbTiempo2
            // 
            this.tbTiempo2.Location = new System.Drawing.Point(313, 139);
            this.tbTiempo2.Name = "tbTiempo2";
            this.tbTiempo2.Size = new System.Drawing.Size(68, 20);
            this.tbTiempo2.TabIndex = 3;
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Location = new System.Drawing.Point(297, 142);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(10, 13);
            this.lbPuntos.TabIndex = 4;
            this.lbPuntos.Text = ":";
            // 
            // btnAgregarTiempo
            // 
            this.btnAgregarTiempo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarTiempo.Location = new System.Drawing.Point(135, 191);
            this.btnAgregarTiempo.Name = "btnAgregarTiempo";
            this.btnAgregarTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTiempo.TabIndex = 5;
            this.btnAgregarTiempo.Text = "Agregar";
            this.btnAgregarTiempo.UseVisualStyleBackColor = true;
            this.btnAgregarTiempo.Click += new System.EventHandler(this.btnAgregarTiempo_Click);
            // 
            // TiemposCompetidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 256);
            this.Controls.Add(this.btnAgregarTiempo);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.tbTiempo2);
            this.Controls.Add(this.tbTiempo1);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbNroCompetidor);
            this.Name = "TiemposCompetidores";
            this.Text = "TiemposCompetidores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNroCompetidor;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Button btnAgregarTiempo;
        public System.Windows.Forms.TextBox tbTiempo1;
        public System.Windows.Forms.TextBox tbTiempo2;
    }
}