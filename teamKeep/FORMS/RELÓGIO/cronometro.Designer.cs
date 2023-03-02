namespace teamKeep.FORMS.RELÓGIO
{
    partial class cronometro
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
            this.lblCronometro = new System.Windows.Forms.Label();
            this.btnCronometro = new System.Windows.Forms.Button();
            this.txt_tempo = new System.Windows.Forms.Label();
            this.inputTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.ForeColor = System.Drawing.Color.Red;
            this.lblCronometro.Location = new System.Drawing.Point(31, 142);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(257, 20);
            this.lblCronometro.TabIndex = 19;
            this.lblCronometro.Text = "Adicione um tempo em segundos";
            this.lblCronometro.Visible = false;
            // 
            // btnCronometro
            // 
            this.btnCronometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronometro.Location = new System.Drawing.Point(177, 91);
            this.btnCronometro.Name = "btnCronometro";
            this.btnCronometro.Size = new System.Drawing.Size(75, 33);
            this.btnCronometro.TabIndex = 18;
            this.btnCronometro.Text = "Iniciar";
            this.btnCronometro.UseVisualStyleBackColor = true;
            this.btnCronometro.Click += new System.EventHandler(this.btnCronometro_Click);
            // 
            // txt_tempo
            // 
            this.txt_tempo.AutoSize = true;
            this.txt_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_tempo.Location = new System.Drawing.Point(126, 184);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(54, 20);
            this.txt_tempo.TabIndex = 17;
            this.txt_tempo.Text = "00:00";
            // 
            // inputTempo
            // 
            this.inputTempo.ForeColor = System.Drawing.Color.White;
            this.inputTempo.Location = new System.Drawing.Point(48, 98);
            this.inputTempo.Name = "inputTempo";
            this.inputTempo.Size = new System.Drawing.Size(100, 26);
            this.inputTempo.TabIndex = 16;
            this.inputTempo.Enter += new System.EventHandler(this.inputTempo_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(40, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Defina o tempo (s)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "CRONÔMETRO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCronometro
            // 
            this.timerCronometro.Interval = 1000;
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnCronometro);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.inputTempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cronometro";
            this.Text = "cronometro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Button btnCronometro;
        private System.Windows.Forms.Label txt_tempo;
        private System.Windows.Forms.TextBox inputTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerCronometro;
        private System.Windows.Forms.Label label5;
    }
}