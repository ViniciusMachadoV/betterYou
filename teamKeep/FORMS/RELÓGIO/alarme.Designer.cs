namespace teamKeep.FORMS.RELÓGIO
{
    partial class alarme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alarme));
            this.lblNotaAlarme = new System.Windows.Forms.Label();
            this.txtNotaAlarme = new System.Windows.Forms.TextBox();
            this.lblTextoAlarme = new System.Windows.Forms.Label();
            this.timerAlarme = new System.Windows.Forms.Timer(this.components);
            this.btnDomingo = new System.Windows.Forms.CheckBox();
            this.btnMenosHora = new System.Windows.Forms.Button();
            this.btnMaisHora = new System.Windows.Forms.Button();
            this.btnSegunda = new System.Windows.Forms.CheckBox();
            this.btnTerça = new System.Windows.Forms.CheckBox();
            this.btnQuarta = new System.Windows.Forms.CheckBox();
            this.btnQuinta = new System.Windows.Forms.CheckBox();
            this.btnSexta = new System.Windows.Forms.CheckBox();
            this.btnSabado = new System.Windows.Forms.CheckBox();
            this.btnMaisMinuto = new System.Windows.Forms.Button();
            this.btnMenosMinuto = new System.Windows.Forms.Button();
            this.btnSalvarAlarme = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.btnEditarAlarme = new System.Windows.Forms.Button();
            this.alarmeSwitch = new teamKeep.CLASSES.CONTROLES.chaveSwitch();
            this.SuspendLayout();
            // 
            // lblNotaAlarme
            // 
            this.lblNotaAlarme.AutoSize = true;
            this.lblNotaAlarme.ForeColor = System.Drawing.Color.White;
            this.lblNotaAlarme.Location = new System.Drawing.Point(54, 339);
            this.lblNotaAlarme.Name = "lblNotaAlarme";
            this.lblNotaAlarme.Size = new System.Drawing.Size(175, 20);
            this.lblNotaAlarme.TabIndex = 24;
            this.lblNotaAlarme.Text = "Mensagem do alarme:";
            // 
            // txtNotaAlarme
            // 
            this.txtNotaAlarme.ForeColor = System.Drawing.Color.White;
            this.txtNotaAlarme.Location = new System.Drawing.Point(33, 371);
            this.txtNotaAlarme.Name = "txtNotaAlarme";
            this.txtNotaAlarme.Size = new System.Drawing.Size(238, 26);
            this.txtNotaAlarme.TabIndex = 23;
            // 
            // lblTextoAlarme
            // 
            this.lblTextoAlarme.AutoSize = true;
            this.lblTextoAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAlarme.ForeColor = System.Drawing.Color.White;
            this.lblTextoAlarme.Location = new System.Drawing.Point(85, 162);
            this.lblTextoAlarme.Name = "lblTextoAlarme";
            this.lblTextoAlarme.Size = new System.Drawing.Size(113, 25);
            this.lblTextoAlarme.TabIndex = 20;
            this.lblTextoAlarme.Text = "ALARMES";
            // 
            // timerAlarme
            // 
            this.timerAlarme.Tick += new System.EventHandler(this.timerAlarme_Tick);
            // 
            // btnDomingo
            // 
            this.btnDomingo.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDomingo.AutoSize = true;
            this.btnDomingo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDomingo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDomingo.FlatAppearance.BorderSize = 0;
            this.btnDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomingo.Location = new System.Drawing.Point(22, 294);
            this.btnDomingo.Name = "btnDomingo";
            this.btnDomingo.Size = new System.Drawing.Size(32, 30);
            this.btnDomingo.TabIndex = 36;
            this.btnDomingo.Text = "D";
            this.btnDomingo.UseVisualStyleBackColor = true;
            // 
            // btnMenosHora
            // 
            this.btnMenosHora.FlatAppearance.BorderSize = 0;
            this.btnMenosHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosHora.Image = ((System.Drawing.Image)(resources.GetObject("btnMenosHora.Image")));
            this.btnMenosHora.Location = new System.Drawing.Point(101, 262);
            this.btnMenosHora.Name = "btnMenosHora";
            this.btnMenosHora.Size = new System.Drawing.Size(40, 25);
            this.btnMenosHora.TabIndex = 37;
            this.btnMenosHora.UseVisualStyleBackColor = true;
            this.btnMenosHora.Visible = false;
            this.btnMenosHora.Click += new System.EventHandler(this.btnMenosHora_Click);
            // 
            // btnMaisHora
            // 
            this.btnMaisHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaisHora.FlatAppearance.BorderSize = 0;
            this.btnMaisHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisHora.Image = ((System.Drawing.Image)(resources.GetObject("btnMaisHora.Image")));
            this.btnMaisHora.Location = new System.Drawing.Point(101, 199);
            this.btnMaisHora.Name = "btnMaisHora";
            this.btnMaisHora.Size = new System.Drawing.Size(40, 25);
            this.btnMaisHora.TabIndex = 38;
            this.btnMaisHora.UseVisualStyleBackColor = true;
            this.btnMaisHora.Visible = false;
            this.btnMaisHora.Click += new System.EventHandler(this.btnMaisHora_Click);
            // 
            // btnSegunda
            // 
            this.btnSegunda.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSegunda.AutoSize = true;
            this.btnSegunda.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegunda.FlatAppearance.BorderSize = 0;
            this.btnSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegunda.Location = new System.Drawing.Point(59, 294);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(30, 30);
            this.btnSegunda.TabIndex = 39;
            this.btnSegunda.Text = "S";
            this.btnSegunda.UseVisualStyleBackColor = true;
            // 
            // btnTerça
            // 
            this.btnTerça.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTerça.AutoSize = true;
            this.btnTerça.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTerça.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerça.FlatAppearance.BorderSize = 0;
            this.btnTerça.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerça.Location = new System.Drawing.Point(94, 294);
            this.btnTerça.Name = "btnTerça";
            this.btnTerça.Size = new System.Drawing.Size(29, 30);
            this.btnTerça.TabIndex = 40;
            this.btnTerça.Text = "T";
            this.btnTerça.UseVisualStyleBackColor = true;
            // 
            // btnQuarta
            // 
            this.btnQuarta.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnQuarta.AutoSize = true;
            this.btnQuarta.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuarta.FlatAppearance.BorderSize = 0;
            this.btnQuarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuarta.Location = new System.Drawing.Point(128, 294);
            this.btnQuarta.Name = "btnQuarta";
            this.btnQuarta.Size = new System.Drawing.Size(32, 30);
            this.btnQuarta.TabIndex = 41;
            this.btnQuarta.Text = "Q";
            this.btnQuarta.UseVisualStyleBackColor = true;
            // 
            // btnQuinta
            // 
            this.btnQuinta.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnQuinta.AutoSize = true;
            this.btnQuinta.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuinta.FlatAppearance.BorderSize = 0;
            this.btnQuinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuinta.Location = new System.Drawing.Point(165, 294);
            this.btnQuinta.Name = "btnQuinta";
            this.btnQuinta.Size = new System.Drawing.Size(32, 30);
            this.btnQuinta.TabIndex = 42;
            this.btnQuinta.Text = "Q";
            this.btnQuinta.UseVisualStyleBackColor = true;
            // 
            // btnSexta
            // 
            this.btnSexta.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSexta.AutoSize = true;
            this.btnSexta.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSexta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSexta.FlatAppearance.BorderSize = 0;
            this.btnSexta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSexta.Location = new System.Drawing.Point(202, 294);
            this.btnSexta.Name = "btnSexta";
            this.btnSexta.Size = new System.Drawing.Size(32, 30);
            this.btnSexta.TabIndex = 43;
            this.btnSexta.Text = "D";
            this.btnSexta.UseVisualStyleBackColor = true;
            // 
            // btnSabado
            // 
            this.btnSabado.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSabado.AutoSize = true;
            this.btnSabado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSabado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSabado.FlatAppearance.BorderSize = 0;
            this.btnSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSabado.Location = new System.Drawing.Point(239, 294);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(32, 30);
            this.btnSabado.TabIndex = 44;
            this.btnSabado.Text = "D";
            this.btnSabado.UseVisualStyleBackColor = true;
            // 
            // btnMaisMinuto
            // 
            this.btnMaisMinuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaisMinuto.FlatAppearance.BorderSize = 0;
            this.btnMaisMinuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisMinuto.Image = ((System.Drawing.Image)(resources.GetObject("btnMaisMinuto.Image")));
            this.btnMaisMinuto.Location = new System.Drawing.Point(155, 199);
            this.btnMaisMinuto.Name = "btnMaisMinuto";
            this.btnMaisMinuto.Size = new System.Drawing.Size(40, 25);
            this.btnMaisMinuto.TabIndex = 45;
            this.btnMaisMinuto.UseVisualStyleBackColor = true;
            this.btnMaisMinuto.Visible = false;
            this.btnMaisMinuto.Click += new System.EventHandler(this.btnMaisMinuto_Click);
            // 
            // btnMenosMinuto
            // 
            this.btnMenosMinuto.FlatAppearance.BorderSize = 0;
            this.btnMenosMinuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosMinuto.Image = ((System.Drawing.Image)(resources.GetObject("btnMenosMinuto.Image")));
            this.btnMenosMinuto.Location = new System.Drawing.Point(155, 262);
            this.btnMenosMinuto.Name = "btnMenosMinuto";
            this.btnMenosMinuto.Size = new System.Drawing.Size(40, 25);
            this.btnMenosMinuto.TabIndex = 46;
            this.btnMenosMinuto.UseVisualStyleBackColor = true;
            this.btnMenosMinuto.Visible = false;
            this.btnMenosMinuto.Click += new System.EventHandler(this.btnMenosMinuto_Click);
            // 
            // btnSalvarAlarme
            // 
            this.btnSalvarAlarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlarme.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlarme.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAlarme.Image")));
            this.btnSalvarAlarme.Location = new System.Drawing.Point(49, 231);
            this.btnSalvarAlarme.Name = "btnSalvarAlarme";
            this.btnSalvarAlarme.Size = new System.Drawing.Size(40, 30);
            this.btnSalvarAlarme.TabIndex = 47;
            this.btnSalvarAlarme.UseVisualStyleBackColor = true;
            this.btnSalvarAlarme.Visible = false;
            this.btnSalvarAlarme.Click += new System.EventHandler(this.btnSalvarAlarme_Click);
            // 
            // txtHora
            // 
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Enabled = false;
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(103, 230);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(40, 26);
            this.txtHora.TabIndex = 48;
            this.txtHora.Text = "10";
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutos
            // 
            this.txtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinutos.Enabled = false;
            this.txtMinutos.ForeColor = System.Drawing.Color.White;
            this.txtMinutos.Location = new System.Drawing.Point(155, 230);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(40, 26);
            this.txtMinutos.TabIndex = 49;
            this.txtMinutos.Text = "00";
            this.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditarAlarme
            // 
            this.btnEditarAlarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAlarme.FlatAppearance.BorderSize = 0;
            this.btnEditarAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAlarme.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAlarme.Image")));
            this.btnEditarAlarme.Location = new System.Drawing.Point(49, 231);
            this.btnEditarAlarme.Name = "btnEditarAlarme";
            this.btnEditarAlarme.Size = new System.Drawing.Size(40, 30);
            this.btnEditarAlarme.TabIndex = 50;
            this.btnEditarAlarme.UseVisualStyleBackColor = true;
            this.btnEditarAlarme.Click += new System.EventHandler(this.btnEditarAlarme_Click);
            // 
            // alarmeSwitch
            // 
            this.alarmeSwitch.BotaoSwitchDesligado = System.Drawing.Color.Gainsboro;
            this.alarmeSwitch.BotaoSwitchLigado = System.Drawing.Color.WhiteSmoke;
            this.alarmeSwitch.FundoSwitchDesligado = System.Drawing.Color.Gray;
            this.alarmeSwitch.FundoSwitchLigado = System.Drawing.Color.MediumSlateBlue;
            this.alarmeSwitch.Location = new System.Drawing.Point(217, 228);
            this.alarmeSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.alarmeSwitch.Name = "alarmeSwitch";
            this.alarmeSwitch.Size = new System.Drawing.Size(54, 28);
            this.alarmeSwitch.TabIndex = 32;
            this.alarmeSwitch.UseVisualStyleBackColor = true;
            // 
            // alarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(300, 520);
            this.Controls.Add(this.btnEditarAlarme);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnSalvarAlarme);
            this.Controls.Add(this.btnMenosMinuto);
            this.Controls.Add(this.btnMaisMinuto);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnSexta);
            this.Controls.Add(this.btnQuinta);
            this.Controls.Add(this.btnQuarta);
            this.Controls.Add(this.btnTerça);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.btnMaisHora);
            this.Controls.Add(this.btnMenosHora);
            this.Controls.Add(this.btnDomingo);
            this.Controls.Add(this.alarmeSwitch);
            this.Controls.Add(this.lblNotaAlarme);
            this.Controls.Add(this.txtNotaAlarme);
            this.Controls.Add(this.lblTextoAlarme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "alarme";
            this.Text = "alarme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotaAlarme;
        private System.Windows.Forms.TextBox txtNotaAlarme;
        private System.Windows.Forms.Label lblTextoAlarme;
        private CLASSES.CONTROLES.chaveSwitch alarmeSwitch;
        private System.Windows.Forms.Timer timerAlarme;
        private System.Windows.Forms.CheckBox btnDomingo;
        private System.Windows.Forms.Button btnMenosHora;
        private System.Windows.Forms.Button btnMaisHora;
        private System.Windows.Forms.CheckBox btnSegunda;
        private System.Windows.Forms.CheckBox btnTerça;
        private System.Windows.Forms.CheckBox btnQuarta;
        private System.Windows.Forms.CheckBox btnQuinta;
        private System.Windows.Forms.CheckBox btnSexta;
        private System.Windows.Forms.CheckBox btnSabado;
        private System.Windows.Forms.Button btnMaisMinuto;
        private System.Windows.Forms.Button btnMenosMinuto;
        private System.Windows.Forms.Button btnSalvarAlarme;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button btnEditarAlarme;
    }
}