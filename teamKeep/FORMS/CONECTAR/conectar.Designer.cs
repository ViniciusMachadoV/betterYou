namespace teamKeep

{
    partial class conectar
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
            this.lblTipoConexao = new System.Windows.Forms.Label();
            this.pnlTipoConexao = new System.Windows.Forms.Panel();
            this.btnPanelEntrar = new System.Windows.Forms.Button();
            this.btnPanelCadastrar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlSelecionadoConectar = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoConexao
            // 
            this.lblTipoConexao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipoConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConexao.ForeColor = System.Drawing.Color.White;
            this.lblTipoConexao.Location = new System.Drawing.Point(0, 0);
            this.lblTipoConexao.Name = "lblTipoConexao";
            this.lblTipoConexao.Size = new System.Drawing.Size(600, 50);
            this.lblTipoConexao.TabIndex = 2;
            this.lblTipoConexao.Text = "Olá, vamos começar?";
            this.lblTipoConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTipoConexao
            // 
            this.pnlTipoConexao.Location = new System.Drawing.Point(100, 80);
            this.pnlTipoConexao.Name = "pnlTipoConexao";
            this.pnlTipoConexao.Size = new System.Drawing.Size(400, 430);
            this.pnlTipoConexao.TabIndex = 3;
            // 
            // btnPanelEntrar
            // 
            this.btnPanelEntrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanelEntrar.FlatAppearance.BorderSize = 0;
            this.btnPanelEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelEntrar.ForeColor = System.Drawing.Color.White;
            this.btnPanelEntrar.Location = new System.Drawing.Point(0, 0);
            this.btnPanelEntrar.Name = "btnPanelEntrar";
            this.btnPanelEntrar.Size = new System.Drawing.Size(200, 30);
            this.btnPanelEntrar.TabIndex = 4;
            this.btnPanelEntrar.Text = "ENTRAR";
            this.btnPanelEntrar.UseVisualStyleBackColor = true;
            this.btnPanelEntrar.Click += new System.EventHandler(this.btnPanelEntrar_Click);
            // 
            // btnPanelCadastrar
            // 
            this.btnPanelCadastrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPanelCadastrar.FlatAppearance.BorderSize = 0;
            this.btnPanelCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnPanelCadastrar.Location = new System.Drawing.Point(200, 0);
            this.btnPanelCadastrar.Name = "btnPanelCadastrar";
            this.btnPanelCadastrar.Size = new System.Drawing.Size(200, 30);
            this.btnPanelCadastrar.TabIndex = 5;
            this.btnPanelCadastrar.Text = "CADASTRAR";
            this.btnPanelCadastrar.UseVisualStyleBackColor = true;
            this.btnPanelCadastrar.Click += new System.EventHandler(this.btnPanelCadastrar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.pnlSelecionadoConectar);
            this.pnlBotoes.Controls.Add(this.btnPanelEntrar);
            this.pnlBotoes.Controls.Add(this.btnPanelCadastrar);
            this.pnlBotoes.Location = new System.Drawing.Point(100, 50);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(400, 30);
            this.pnlBotoes.TabIndex = 6;
            // 
            // pnlSelecionadoConectar
            // 
            this.pnlSelecionadoConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlSelecionadoConectar.Location = new System.Drawing.Point(0, 28);
            this.pnlSelecionadoConectar.Name = "pnlSelecionadoConectar";
            this.pnlSelecionadoConectar.Size = new System.Drawing.Size(200, 2);
            this.pnlSelecionadoConectar.TabIndex = 0;
            // 
            // conectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlTipoConexao);
            this.Controls.Add(this.lblTipoConexao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conectar";
            this.Text = "conectar";
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConexao;
        private System.Windows.Forms.Panel pnlTipoConexao;
        private System.Windows.Forms.Button btnPanelEntrar;
        private System.Windows.Forms.Button btnPanelCadastrar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlSelecionadoConectar;
    }
}