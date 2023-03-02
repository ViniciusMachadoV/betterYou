namespace teamKeep
{
    partial class cadastrar
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
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro2 = new System.Windows.Forms.Label();
            this.txtSenhaCadastro2 = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnExibirSenhaCadastro = new System.Windows.Forms.Button();
            this.lblErroCadastrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadastro.Location = new System.Drawing.Point(179, 79);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome";
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.ForeColor = System.Drawing.Color.White;
            this.txtNomeCadastro.Location = new System.Drawing.Point(149, 108);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCadastro.TabIndex = 1;
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNomeCadastro_TextChanged);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.ForeColor = System.Drawing.Color.White;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(149, 224);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCadastro.TabIndex = 5;
            this.txtSenhaCadastro.TextChanged += new System.EventHandler(this.txtSenhaCadastro_TextChanged);
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.ForeColor = System.Drawing.Color.White;
            this.txtEmailCadastro.Location = new System.Drawing.Point(152, 159);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCadastro.TabIndex = 3;
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.ForeColor = System.Drawing.Color.White;
            this.lblEmailCadastro.Location = new System.Drawing.Point(179, 143);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCadastro.TabIndex = 2;
            this.lblEmailCadastro.Text = "E-mail";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.ForeColor = System.Drawing.Color.White;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(160, 208);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(89, 13);
            this.lblSenhaCadastro.TabIndex = 4;
            this.lblSenhaCadastro.Text = "Digite uma senha";
            // 
            // lblSenhaCadastro2
            // 
            this.lblSenhaCadastro2.AutoSize = true;
            this.lblSenhaCadastro2.ForeColor = System.Drawing.Color.White;
            this.lblSenhaCadastro2.Location = new System.Drawing.Point(160, 261);
            this.lblSenhaCadastro2.Name = "lblSenhaCadastro2";
            this.lblSenhaCadastro2.Size = new System.Drawing.Size(89, 13);
            this.lblSenhaCadastro2.TabIndex = 6;
            this.lblSenhaCadastro2.Text = "Confirme a senha";
            // 
            // txtSenhaCadastro2
            // 
            this.txtSenhaCadastro2.ForeColor = System.Drawing.Color.White;
            this.txtSenhaCadastro2.Location = new System.Drawing.Point(149, 277);
            this.txtSenhaCadastro2.Name = "txtSenhaCadastro2";
            this.txtSenhaCadastro2.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCadastro2.TabIndex = 7;
            this.txtSenhaCadastro2.TextChanged += new System.EventHandler(this.txtSenhaCadastro2_TextChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(149, 341);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(89, 23);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnExibirSenhaCadastro
            // 
            this.btnExibirSenhaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirSenhaCadastro.ForeColor = System.Drawing.Color.White;
            this.btnExibirSenhaCadastro.Location = new System.Drawing.Point(141, 303);
            this.btnExibirSenhaCadastro.Name = "btnExibirSenhaCadastro";
            this.btnExibirSenhaCadastro.Size = new System.Drawing.Size(111, 23);
            this.btnExibirSenhaCadastro.TabIndex = 8;
            this.btnExibirSenhaCadastro.Text = "EXIBIR SENHA";
            this.btnExibirSenhaCadastro.UseVisualStyleBackColor = true;
            this.btnExibirSenhaCadastro.Click += new System.EventHandler(this.btnExibirSenhaCadastro_Click);
            // 
            // lblErroCadastrar
            // 
            this.lblErroCadastrar.ForeColor = System.Drawing.Color.Red;
            this.lblErroCadastrar.Location = new System.Drawing.Point(0, 367);
            this.lblErroCadastrar.Name = "lblErroCadastrar";
            this.lblErroCadastrar.Size = new System.Drawing.Size(400, 15);
            this.lblErroCadastrar.TabIndex = 13;
            this.lblErroCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.lblErroCadastrar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnExibirSenhaCadastro);
            this.Controls.Add(this.txtSenhaCadastro2);
            this.Controls.Add(this.lblSenhaCadastro2);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.lblSenhaCadastro);
            this.Controls.Add(this.txtEmailCadastro);
            this.Controls.Add(this.lblEmailCadastro);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.lblNomeCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro2;
        private System.Windows.Forms.TextBox txtSenhaCadastro2;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnExibirSenhaCadastro;
        private System.Windows.Forms.Label lblErroCadastrar;
    }
}