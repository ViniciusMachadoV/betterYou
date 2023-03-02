namespace teamKeep
{
    partial class alertas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alertas));
            this.timerAlerta = new System.Windows.Forms.Timer(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnFecharAlerta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerAlerta
            // 
            this.timerAlerta.Tick += new System.EventHandler(this.timerAlerta_Tick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(239, 54);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Message Text";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFecharAlerta
            // 
            this.btnFecharAlerta.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharAlerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharAlerta.BackgroundImage")));
            this.btnFecharAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharAlerta.FlatAppearance.BorderSize = 0;
            this.btnFecharAlerta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFecharAlerta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFecharAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharAlerta.ForeColor = System.Drawing.Color.White;
            this.btnFecharAlerta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFecharAlerta.Location = new System.Drawing.Point(269, 7);
            this.btnFecharAlerta.Name = "btnFecharAlerta";
            this.btnFecharAlerta.Size = new System.Drawing.Size(64, 56);
            this.btnFecharAlerta.TabIndex = 4;
            this.btnFecharAlerta.UseVisualStyleBackColor = false;
            this.btnFecharAlerta.Click += new System.EventHandler(this.btnFecharAlerta_Click);
            // 
            // alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(335, 72);
            this.Controls.Add(this.btnFecharAlerta);
            this.Controls.Add(this.lblMensagem);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "alertas";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer timerAlerta;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnFecharAlerta;
    }
}