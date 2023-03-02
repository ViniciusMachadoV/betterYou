namespace teamKeep.FORMS.RELÓGIO
{
    partial class relogio
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
            this.pnlAlarme = new System.Windows.Forms.Panel();
            this.pnlTemporizador = new System.Windows.Forms.Panel();
            this.pnlCronometro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAlarme
            // 
            this.pnlAlarme.AutoSize = true;
            this.pnlAlarme.ForeColor = System.Drawing.Color.White;
            this.pnlAlarme.Location = new System.Drawing.Point(10, 10);
            this.pnlAlarme.Name = "pnlAlarme";
            this.pnlAlarme.Size = new System.Drawing.Size(280, 500);
            this.pnlAlarme.TabIndex = 9;
            // 
            // pnlTemporizador
            // 
            this.pnlTemporizador.ForeColor = System.Drawing.Color.White;
            this.pnlTemporizador.Location = new System.Drawing.Point(310, 10);
            this.pnlTemporizador.Name = "pnlTemporizador";
            this.pnlTemporizador.Size = new System.Drawing.Size(280, 240);
            this.pnlTemporizador.TabIndex = 10;
            // 
            // pnlCronometro
            // 
            this.pnlCronometro.Location = new System.Drawing.Point(310, 270);
            this.pnlCronometro.Name = "pnlCronometro";
            this.pnlCronometro.Size = new System.Drawing.Size(280, 240);
            this.pnlCronometro.TabIndex = 11;
            // 
            // relogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.pnlCronometro);
            this.Controls.Add(this.pnlTemporizador);
            this.Controls.Add(this.pnlAlarme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "relogio";
            this.Text = "relogio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlarme;
        private System.Windows.Forms.Panel pnlTemporizador;
        private System.Windows.Forms.Panel pnlCronometro;
    }
}