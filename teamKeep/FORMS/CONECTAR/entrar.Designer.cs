namespace teamKeep

{
    partial class entrar
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
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblErroEntrar = new System.Windows.Forms.Label();
            this.linkLembrarSenha = new System.Windows.Forms.LinkLabel();
            this.btnExibirSenhaLogin = new System.Windows.Forms.Button();
            this.checkLembrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(144, 132);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(109, 20);
            this.txtUsuarioLogin.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(180, 99);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(180, 177);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(144, 205);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(109, 20);
            this.txtSenhaLogin.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(166, 287);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblErroEntrar
            // 
            this.lblErroEntrar.ForeColor = System.Drawing.Color.Red;
            this.lblErroEntrar.Location = new System.Drawing.Point(0, 345);
            this.lblErroEntrar.Name = "lblErroEntrar";
            this.lblErroEntrar.Size = new System.Drawing.Size(400, 15);
            this.lblErroEntrar.TabIndex = 9;
            this.lblErroEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLembrarSenha
            // 
            this.linkLembrarSenha.AutoSize = true;
            this.linkLembrarSenha.LinkColor = System.Drawing.Color.White;
            this.linkLembrarSenha.Location = new System.Drawing.Point(151, 318);
            this.linkLembrarSenha.Name = "linkLembrarSenha";
            this.linkLembrarSenha.Size = new System.Drawing.Size(102, 13);
            this.linkLembrarSenha.TabIndex = 8;
            this.linkLembrarSenha.TabStop = true;
            this.linkLembrarSenha.Text = "Esqueceu a senha?";
            // 
            // btnExibirSenhaLogin
            // 
            this.btnExibirSenhaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.btnExibirSenhaLogin.Location = new System.Drawing.Point(144, 231);
            this.btnExibirSenhaLogin.Name = "btnExibirSenhaLogin";
            this.btnExibirSenhaLogin.Size = new System.Drawing.Size(109, 23);
            this.btnExibirSenhaLogin.TabIndex = 5;
            this.btnExibirSenhaLogin.Text = "EXIBIR SENHA";
            this.btnExibirSenhaLogin.UseVisualStyleBackColor = true;
            this.btnExibirSenhaLogin.Click += new System.EventHandler(this.btnExibirSenhaLogin_Click);
            // 
            // checkLembrar
            // 
            this.checkLembrar.AutoSize = true;
            this.checkLembrar.ForeColor = System.Drawing.Color.White;
            this.checkLembrar.Location = new System.Drawing.Point(143, 264);
            this.checkLembrar.Name = "checkLembrar";
            this.checkLembrar.Size = new System.Drawing.Size(119, 17);
            this.checkLembrar.TabIndex = 6;
            this.checkLembrar.Text = "LEMBRAR DADOS";
            this.checkLembrar.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.lblErroEntrar);
            this.Controls.Add(this.linkLembrarSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.checkLembrar);
            this.Controls.Add(this.btnExibirSenhaLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "entrar";
            this.Text = "entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        public System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblErroEntrar;
        private System.Windows.Forms.LinkLabel linkLembrarSenha;
        private System.Windows.Forms.Button btnExibirSenhaLogin;
        private System.Windows.Forms.CheckBox checkLembrar;
    }
}