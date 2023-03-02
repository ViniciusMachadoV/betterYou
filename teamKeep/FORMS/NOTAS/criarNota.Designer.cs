namespace teamKeep
{
    partial class criarNota
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
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.lblTituloNota = new System.Windows.Forms.Label();
            this.txtDescricaoNota = new System.Windows.Forms.RichTextBox();
            this.txtTituloNota = new System.Windows.Forms.TextBox();
            this.id_update = new System.Windows.Forms.Label();
            this.lblErroCriarNota = new System.Windows.Forms.Label();
            this.btnCancelarCriarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarNota.ForeColor = System.Drawing.Color.White;
            this.btnSalvarNota.Location = new System.Drawing.Point(293, 481);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(80, 30);
            this.btnSalvarNota.TabIndex = 7;
            this.btnSalvarNota.Text = "SALVAR";
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // lblTituloNota
            // 
            this.lblTituloNota.ForeColor = System.Drawing.Color.White;
            this.lblTituloNota.Location = new System.Drawing.Point(264, 17);
            this.lblTituloNota.Name = "lblTituloNota";
            this.lblTituloNota.Size = new System.Drawing.Size(60, 20);
            this.lblTituloNota.TabIndex = 4;
            this.lblTituloNota.Text = "TÍTULO";
            this.lblTituloNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricaoNota
            // 
            this.txtDescricaoNota.ForeColor = System.Drawing.Color.White;
            this.txtDescricaoNota.Location = new System.Drawing.Point(54, 72);
            this.txtDescricaoNota.Name = "txtDescricaoNota";
            this.txtDescricaoNota.Size = new System.Drawing.Size(480, 376);
            this.txtDescricaoNota.TabIndex = 6;
            this.txtDescricaoNota.Text = "";
            this.txtDescricaoNota.Enter += new System.EventHandler(this.txtDescricaoNota_Enter);
            // 
            // txtTituloNota
            // 
            this.txtTituloNota.ForeColor = System.Drawing.Color.White;
            this.txtTituloNota.Location = new System.Drawing.Point(204, 42);
            this.txtTituloNota.Name = "txtTituloNota";
            this.txtTituloNota.Size = new System.Drawing.Size(180, 20);
            this.txtTituloNota.TabIndex = 5;
            // 
            // id_update
            // 
            this.id_update.AutoSize = true;
            this.id_update.Location = new System.Drawing.Point(464, 40);
            this.id_update.Name = "id_update";
            this.id_update.Size = new System.Drawing.Size(0, 13);
            this.id_update.TabIndex = 8;
            this.id_update.Visible = false;
            // 
            // lblErroCriarNota
            // 
            this.lblErroCriarNota.AutoSize = true;
            this.lblErroCriarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblErroCriarNota.ForeColor = System.Drawing.Color.Red;
            this.lblErroCriarNota.Location = new System.Drawing.Point(112, 456);
            this.lblErroCriarNota.Name = "lblErroCriarNota";
            this.lblErroCriarNota.Size = new System.Drawing.Size(358, 20);
            this.lblErroCriarNota.TabIndex = 9;
            this.lblErroCriarNota.Text = "Não é possível salvar uma nota sem descrição";
            this.lblErroCriarNota.Visible = false;
            // 
            // btnCancelarCriarNota
            // 
            this.btnCancelarCriarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCriarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCriarNota.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCriarNota.Location = new System.Drawing.Point(204, 481);
            this.btnCancelarCriarNota.Name = "btnCancelarCriarNota";
            this.btnCancelarCriarNota.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarCriarNota.TabIndex = 10;
            this.btnCancelarCriarNota.Text = "CANCELAR";
            this.btnCancelarCriarNota.UseVisualStyleBackColor = true;
            this.btnCancelarCriarNota.Click += new System.EventHandler(this.btnCancelarCriarNota_Click);
            // 
            // criarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 523);
            this.Controls.Add(this.btnCancelarCriarNota);
            this.Controls.Add(this.lblErroCriarNota);
            this.Controls.Add(this.id_update);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.lblTituloNota);
            this.Controls.Add(this.txtDescricaoNota);
            this.Controls.Add(this.txtTituloNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "criarNota";
            this.Text = "criarNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.Label lblTituloNota;
        public System.Windows.Forms.RichTextBox txtDescricaoNota;
        public System.Windows.Forms.TextBox txtTituloNota;
        public System.Windows.Forms.Label id_update;
        private System.Windows.Forms.Label lblErroCriarNota;
        private System.Windows.Forms.Button btnCancelarCriarNota;
    }
}