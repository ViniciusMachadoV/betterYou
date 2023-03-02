namespace teamKeep
{
    partial class nota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nota));
            this.btnEditarNota = new System.Windows.Forms.Button();
            this.lblTituloNota = new System.Windows.Forms.Label();
            this.btnExcluirNota = new System.Windows.Forms.Button();
            this.lblIdNota = new System.Windows.Forms.Label();
            this.lblDescricaoNota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarNota
            // 
            this.btnEditarNota.FlatAppearance.BorderSize = 0;
            this.btnEditarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNota.ForeColor = System.Drawing.Color.White;
            this.btnEditarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNota.Image")));
            this.btnEditarNota.Location = new System.Drawing.Point(12, 78);
            this.btnEditarNota.Name = "btnEditarNota";
            this.btnEditarNota.Size = new System.Drawing.Size(40, 40);
            this.btnEditarNota.TabIndex = 1;
            this.btnEditarNota.UseVisualStyleBackColor = true;
            this.btnEditarNota.Click += new System.EventHandler(this.btnEditarNota_Click);
            // 
            // lblTituloNota
            // 
            this.lblTituloNota.ForeColor = System.Drawing.Color.White;
            this.lblTituloNota.Location = new System.Drawing.Point(12, 19);
            this.lblTituloNota.Name = "lblTituloNota";
            this.lblTituloNota.Size = new System.Drawing.Size(132, 13);
            this.lblTituloNota.TabIndex = 0;
            this.lblTituloNota.Text = "TÍTULO";
            this.lblTituloNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluirNota
            // 
            this.btnExcluirNota.FlatAppearance.BorderSize = 0;
            this.btnExcluirNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirNota.ForeColor = System.Drawing.Color.White;
            this.btnExcluirNota.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirNota.Image")));
            this.btnExcluirNota.Location = new System.Drawing.Point(58, 78);
            this.btnExcluirNota.Name = "btnExcluirNota";
            this.btnExcluirNota.Size = new System.Drawing.Size(40, 40);
            this.btnExcluirNota.TabIndex = 2;
            this.btnExcluirNota.UseVisualStyleBackColor = true;
            this.btnExcluirNota.Click += new System.EventHandler(this.btnExcluirNota_Click);
            // 
            // lblIdNota
            // 
            this.lblIdNota.AutoSize = true;
            this.lblIdNota.ForeColor = System.Drawing.Color.White;
            this.lblIdNota.Location = new System.Drawing.Point(118, 112);
            this.lblIdNota.Name = "lblIdNota";
            this.lblIdNota.Size = new System.Drawing.Size(42, 13);
            this.lblIdNota.TabIndex = 3;
            this.lblIdNota.Text = "id_nota";
            this.lblIdNota.Visible = false;
            // 
            // lblDescricaoNota
            // 
            this.lblDescricaoNota.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoNota.Location = new System.Drawing.Point(12, 32);
            this.lblDescricaoNota.Name = "lblDescricaoNota";
            this.lblDescricaoNota.Size = new System.Drawing.Size(136, 51);
            this.lblDescricaoNota.TabIndex = 4;
            this.lblDescricaoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(160, 130);
            this.Controls.Add(this.lblDescricaoNota);
            this.Controls.Add(this.lblIdNota);
            this.Controls.Add(this.btnExcluirNota);
            this.Controls.Add(this.btnEditarNota);
            this.Controls.Add(this.lblTituloNota);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "nota";
            this.Text = "nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarNota;
        public System.Windows.Forms.Label lblTituloNota;
        private System.Windows.Forms.Button btnExcluirNota;
        public System.Windows.Forms.Label lblIdNota;
        public System.Windows.Forms.Label lblDescricaoNota;

    }
}