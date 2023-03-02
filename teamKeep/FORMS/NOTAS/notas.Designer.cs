namespace teamKeep

{
    partial class notas
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
            this.lblSemNotas = new System.Windows.Forms.Label();
            this.btnCriarNota = new System.Windows.Forms.Button();
            this.tblNotas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSemNotas
            // 
            this.lblSemNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemNotas.ForeColor = System.Drawing.Color.White;
            this.lblSemNotas.Location = new System.Drawing.Point(0, 260);
            this.lblSemNotas.Name = "lblSemNotas";
            this.lblSemNotas.Size = new System.Drawing.Size(600, 20);
            this.lblSemNotas.TabIndex = 0;
            this.lblSemNotas.Text = "Você não possui notas salvas";
            this.lblSemNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSemNotas.Visible = false;
            // 
            // btnCriarNota
            // 
            this.btnCriarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarNota.ForeColor = System.Drawing.Color.White;
            this.btnCriarNota.Location = new System.Drawing.Point(260, 15);
            this.btnCriarNota.Name = "btnCriarNota";
            this.btnCriarNota.Size = new System.Drawing.Size(80, 30);
            this.btnCriarNota.TabIndex = 0;
            this.btnCriarNota.Text = "CRIAR";
            this.btnCriarNota.UseVisualStyleBackColor = true;
            this.btnCriarNota.Click += new System.EventHandler(this.btnCriarNota_Click);
            // 
            // tblNotas
            // 
            this.tblNotas.AutoScroll = true;
            this.tblNotas.Location = new System.Drawing.Point(25, 60);
            this.tblNotas.Name = "tblNotas";
            this.tblNotas.Size = new System.Drawing.Size(550, 450);
            this.tblNotas.TabIndex = 2;
            // 
            // notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.lblSemNotas);
            this.Controls.Add(this.tblNotas);
            this.Controls.Add(this.btnCriarNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notas";
            this.Text = "notas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSemNotas;
        private System.Windows.Forms.Button btnCriarNota;
        private System.Windows.Forms.FlowLayoutPanel tblNotas;
    }
}