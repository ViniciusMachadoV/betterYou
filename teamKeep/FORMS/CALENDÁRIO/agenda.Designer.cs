namespace teamKeep.FORMS.CALENDÁRIO
{
    partial class agenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlDescricao = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.Label();
            this.lblErroLembrete = new System.Windows.Forms.Label();
            this.lblIDLembrete = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDescricao.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descricão";
            // 
            // txt_desc
            // 
            this.txt_desc.ForeColor = System.Drawing.Color.White;
            this.txt_desc.Location = new System.Drawing.Point(15, 25);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(494, 87);
            this.txt_desc.TabIndex = 3;
            this.txt_desc.Text = "Digite aqui a descrição do evento";
            this.txt_desc.Enter += new System.EventHandler(this.txt_desc_Enter);
            this.txt_desc.Leave += new System.EventHandler(this.txt_desc_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(108, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(13, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(175, 231);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(200, 41);
            this.pnlBotoes.TabIndex = 6;
            // 
            // pnlDescricao
            // 
            this.pnlDescricao.Controls.Add(this.txt_desc);
            this.pnlDescricao.Controls.Add(this.label2);
            this.pnlDescricao.Location = new System.Drawing.Point(12, 70);
            this.pnlDescricao.Name = "pnlDescricao";
            this.pnlDescricao.Size = new System.Drawing.Size(526, 137);
            this.pnlDescricao.TabIndex = 7;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.txt_data);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(213, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(137, 43);
            this.pnlData.TabIndex = 8;
            // 
            // txt_data
            // 
            this.txt_data.ForeColor = System.Drawing.Color.White;
            this.txt_data.Location = new System.Drawing.Point(3, 19);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(131, 22);
            this.txt_data.TabIndex = 1;
            this.txt_data.Text = "01/01/2000";
            this.txt_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErroLembrete
            // 
            this.lblErroLembrete.AutoSize = true;
            this.lblErroLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblErroLembrete.ForeColor = System.Drawing.Color.Red;
            this.lblErroLembrete.Location = new System.Drawing.Point(111, 210);
            this.lblErroLembrete.Name = "lblErroLembrete";
            this.lblErroLembrete.Size = new System.Drawing.Size(328, 20);
            this.lblErroLembrete.TabIndex = 9;
            this.lblErroLembrete.Text = "Digite algo antes de salvar o compromisso";
            this.lblErroLembrete.Visible = false;
            // 
            // lblIDLembrete
            // 
            this.lblIDLembrete.AutoSize = true;
            this.lblIDLembrete.ForeColor = System.Drawing.Color.White;
            this.lblIDLembrete.Location = new System.Drawing.Point(381, 243);
            this.lblIDLembrete.Name = "lblIDLembrete";
            this.lblIDLembrete.Size = new System.Drawing.Size(61, 13);
            this.lblIDLembrete.TabIndex = 10;
            this.lblIDLembrete.Text = "id_lembrete";
            this.lblIDLembrete.Visible = false;
            // 
            // agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(550, 275);
            this.Controls.Add(this.lblIDLembrete);
            this.Controls.Add(this.lblErroLembrete);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agenda";
            this.Text = "agenda";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDescricao.ResumeLayout(false);
            this.pnlDescricao.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlDescricao;
        private System.Windows.Forms.Panel pnlData;
        public System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label lblErroLembrete;
        public System.Windows.Forms.Label lblIDLembrete;
    }
}