namespace teamKeep.FORMS.CALENDÁRIO
{
    partial class comp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comp));
            this.Titulo_comp = new System.Windows.Forms.Label();
            this.desc_comp = new System.Windows.Forms.Label();
            this.btnEditarLembrete = new System.Windows.Forms.Button();
            this.btnExcluirLembrete = new System.Windows.Forms.Button();
            this.lblIdLembrete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo_comp
            // 
            this.Titulo_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_comp.ForeColor = System.Drawing.Color.White;
            this.Titulo_comp.Location = new System.Drawing.Point(58, 36);
            this.Titulo_comp.Name = "Titulo_comp";
            this.Titulo_comp.Size = new System.Drawing.Size(138, 33);
            this.Titulo_comp.TabIndex = 0;
            this.Titulo_comp.Text = "DATA";
            this.Titulo_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desc_comp
            // 
            this.desc_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_comp.ForeColor = System.Drawing.Color.White;
            this.desc_comp.Location = new System.Drawing.Point(21, 72);
            this.desc_comp.Name = "desc_comp";
            this.desc_comp.Size = new System.Drawing.Size(191, 111);
            this.desc_comp.TabIndex = 1;
            this.desc_comp.Text = "DESCRIÇÃO";
            this.desc_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarLembrete
            // 
            this.btnEditarLembrete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLembrete.FlatAppearance.BorderSize = 0;
            this.btnEditarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLembrete.ForeColor = System.Drawing.Color.White;
            this.btnEditarLembrete.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarLembrete.Image")));
            this.btnEditarLembrete.Location = new System.Drawing.Point(12, 33);
            this.btnEditarLembrete.Name = "btnEditarLembrete";
            this.btnEditarLembrete.Size = new System.Drawing.Size(40, 36);
            this.btnEditarLembrete.TabIndex = 2;
            this.btnEditarLembrete.UseVisualStyleBackColor = true;
            this.btnEditarLembrete.Click += new System.EventHandler(this.btnEditarLembrete_Click);
            // 
            // btnExcluirLembrete
            // 
            this.btnExcluirLembrete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirLembrete.FlatAppearance.BorderSize = 0;
            this.btnExcluirLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirLembrete.ForeColor = System.Drawing.Color.White;
            this.btnExcluirLembrete.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirLembrete.Image")));
            this.btnExcluirLembrete.Location = new System.Drawing.Point(212, 12);
            this.btnExcluirLembrete.Name = "btnExcluirLembrete";
            this.btnExcluirLembrete.Size = new System.Drawing.Size(26, 25);
            this.btnExcluirLembrete.TabIndex = 3;
            this.btnExcluirLembrete.UseVisualStyleBackColor = true;
            this.btnExcluirLembrete.Click += new System.EventHandler(this.btnExcluirLembrete_Click);
            // 
            // lblIdLembrete
            // 
            this.lblIdLembrete.AutoSize = true;
            this.lblIdLembrete.Location = new System.Drawing.Point(122, 9);
            this.lblIdLembrete.Name = "lblIdLembrete";
            this.lblIdLembrete.Size = new System.Drawing.Size(61, 13);
            this.lblIdLembrete.TabIndex = 4;
            this.lblIdLembrete.Text = "id_lembrete";
            this.lblIdLembrete.Visible = false;
            // 
            // comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.lblIdLembrete);
            this.Controls.Add(this.btnExcluirLembrete);
            this.Controls.Add(this.btnEditarLembrete);
            this.Controls.Add(this.Titulo_comp);
            this.Controls.Add(this.desc_comp);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "comp";
            this.Text = "comp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Titulo_comp;
        public System.Windows.Forms.Label desc_comp;
        private System.Windows.Forms.Button btnEditarLembrete;
        private System.Windows.Forms.Button btnExcluirLembrete;
        public System.Windows.Forms.Label lblIdLembrete;
    }
}