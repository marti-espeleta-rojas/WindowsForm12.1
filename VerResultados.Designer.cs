namespace WindForm11_06_24
{
    partial class VerResultados
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
            this.gpboxResultados = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gpboxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxResultados
            // 
            this.gpboxResultados.Controls.Add(this.listBox1);
            this.gpboxResultados.Controls.Add(this.btnCerrar);
            this.gpboxResultados.Location = new System.Drawing.Point(26, 13);
            this.gpboxResultados.Name = "gpboxResultados";
            this.gpboxResultados.Size = new System.Drawing.Size(762, 425);
            this.gpboxResultados.TabIndex = 0;
            this.gpboxResultados.TabStop = false;
            this.gpboxResultados.Text = "Resultados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(348, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(736, 355);
            this.listBox1.TabIndex = 1;
            // 
            // VerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpboxResultados);
            this.Name = "VerResultados";
            this.Text = "VerResultados";
            this.Load += new System.EventHandler(this.VerResultados_Load);
            this.gpboxResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxResultados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox listBox1;
    }
}