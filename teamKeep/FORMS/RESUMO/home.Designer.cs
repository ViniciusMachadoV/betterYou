namespace teamKeep

{
    partial class home
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
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.pnlDataHora = new System.Windows.Forms.Panel();
            this.pnlAlarmes = new System.Windows.Forms.Panel();
            this.lblAlarme = new System.Windows.Forms.Label();
            this.lblTextoAlarme = new System.Windows.Forms.Label();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTextoEventos = new System.Windows.Forms.Label();
            this.pnlFinancas = new System.Windows.Forms.Panel();
            this.lblTextoFinancas = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotalGanhos = new System.Windows.Forms.Label();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.pnlProgresso = new System.Windows.Forms.Panel();
            this.lblTextoProgresso = new System.Windows.Forms.Label();
            this.pnlDataHora.SuspendLayout();
            this.pnlAlarmes.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.pnlFinancas.SuspendLayout();
            this.pnlProgresso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelogio
            // 
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.ForeColor = System.Drawing.Color.White;
            this.lblRelogio.Location = new System.Drawing.Point(0, 58);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(344, 73);
            this.lblRelogio.TabIndex = 1;
            this.lblRelogio.Text = "06:00:00";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(0, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(344, 25);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Dia de hoje (Dia da semana)";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDataHora
            // 
            this.pnlDataHora.Controls.Add(this.lblRelogio);
            this.pnlDataHora.Controls.Add(this.lblData);
            this.pnlDataHora.Location = new System.Drawing.Point(138, 23);
            this.pnlDataHora.Name = "pnlDataHora";
            this.pnlDataHora.Size = new System.Drawing.Size(344, 155);
            this.pnlDataHora.TabIndex = 3;
            // 
            // pnlAlarmes
            // 
            this.pnlAlarmes.Controls.Add(this.lblAlarme);
            this.pnlAlarmes.Controls.Add(this.lblTextoAlarme);
            this.pnlAlarmes.Location = new System.Drawing.Point(323, 184);
            this.pnlAlarmes.Name = "pnlAlarmes";
            this.pnlAlarmes.Size = new System.Drawing.Size(231, 80);
            this.pnlAlarmes.TabIndex = 4;
            // 
            // lblAlarme
            // 
            this.lblAlarme.AutoSize = true;
            this.lblAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarme.ForeColor = System.Drawing.Color.White;
            this.lblAlarme.Location = new System.Drawing.Point(33, 29);
            this.lblAlarme.Name = "lblAlarme";
            this.lblAlarme.Size = new System.Drawing.Size(164, 42);
            this.lblAlarme.TabIndex = 5;
            this.lblAlarme.Text = "14:00:00";
            // 
            // lblTextoAlarme
            // 
            this.lblTextoAlarme.AutoSize = true;
            this.lblTextoAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAlarme.ForeColor = System.Drawing.Color.White;
            this.lblTextoAlarme.Location = new System.Drawing.Point(42, 9);
            this.lblTextoAlarme.Name = "lblTextoAlarme";
            this.lblTextoAlarme.Size = new System.Drawing.Size(155, 20);
            this.lblTextoAlarme.TabIndex = 6;
            this.lblTextoAlarme.Text = "PROXIMO ALARME";
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.listView1);
            this.pnlEventos.Controls.Add(this.lblTextoEventos);
            this.pnlEventos.Location = new System.Drawing.Point(28, 184);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(289, 163);
            this.pnlEventos.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Location = new System.Drawing.Point(8, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 105);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTextoEventos
            // 
            this.lblTextoEventos.AutoSize = true;
            this.lblTextoEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoEventos.Location = new System.Drawing.Point(55, 9);
            this.lblTextoEventos.Name = "lblTextoEventos";
            this.lblTextoEventos.Size = new System.Drawing.Size(175, 20);
            this.lblTextoEventos.TabIndex = 3;
            this.lblTextoEventos.Text = "PROXIMOS EVENTOS";
            // 
            // pnlFinancas
            // 
            this.pnlFinancas.Controls.Add(this.lblTextoFinancas);
            this.pnlFinancas.Controls.Add(this.lblTotalSaldo);
            this.pnlFinancas.Controls.Add(this.lblSaldo);
            this.pnlFinancas.Controls.Add(this.lblTotalGanhos);
            this.pnlFinancas.Controls.Add(this.lblGanhos);
            this.pnlFinancas.Controls.Add(this.lblTotalGastos);
            this.pnlFinancas.Controls.Add(this.lblGastos);
            this.pnlFinancas.Location = new System.Drawing.Point(28, 353);
            this.pnlFinancas.Name = "pnlFinancas";
            this.pnlFinancas.Size = new System.Drawing.Size(289, 144);
            this.pnlFinancas.TabIndex = 6;
            // 
            // lblTextoFinancas
            // 
            this.lblTextoFinancas.AutoSize = true;
            this.lblTextoFinancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoFinancas.Location = new System.Drawing.Point(49, 17);
            this.lblTextoFinancas.Name = "lblTextoFinancas";
            this.lblTextoFinancas.Size = new System.Drawing.Size(199, 20);
            this.lblTextoFinancas.TabIndex = 24;
            this.lblTextoFinancas.Text = "CONTROLE FINANCEIRO";
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldo.Location = new System.Drawing.Point(189, 102);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(49, 16);
            this.lblTotalSaldo.TabIndex = 23;
            this.lblTotalSaldo.Text = "R$0,00";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(49, 102);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(53, 16);
            this.lblSaldo.TabIndex = 22;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblTotalGanhos
            // 
            this.lblTotalGanhos.AutoSize = true;
            this.lblTotalGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGanhos.Location = new System.Drawing.Point(189, 48);
            this.lblTotalGanhos.Name = "lblTotalGanhos";
            this.lblTotalGanhos.Size = new System.Drawing.Size(49, 16);
            this.lblTotalGanhos.TabIndex = 21;
            this.lblTotalGanhos.Text = "R$0,00";
            // 
            // lblGanhos
            // 
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhos.Location = new System.Drawing.Point(49, 48);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(66, 16);
            this.lblGanhos.TabIndex = 20;
            this.lblGanhos.Text = "GANHOS";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(189, 76);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(49, 16);
            this.lblTotalGastos.TabIndex = 19;
            this.lblTotalGastos.Text = "R$0,00";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(49, 76);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(64, 16);
            this.lblGastos.TabIndex = 18;
            this.lblGastos.Text = "GASTOS";
            // 
            // pnlProgresso
            // 
            this.pnlProgresso.Controls.Add(this.lblTextoProgresso);
            this.pnlProgresso.Location = new System.Drawing.Point(323, 270);
            this.pnlProgresso.Name = "pnlProgresso";
            this.pnlProgresso.Size = new System.Drawing.Size(231, 227);
            this.pnlProgresso.TabIndex = 7;
            // 
            // lblTextoProgresso
            // 
            this.lblTextoProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoProgresso.Location = new System.Drawing.Point(0, 9);
            this.lblTextoProgresso.Name = "lblTextoProgresso";
            this.lblTextoProgresso.Size = new System.Drawing.Size(228, 24);
            this.lblTextoProgresso.TabIndex = 0;
            this.lblTextoProgresso.Text = "PROGRESSO NAS METAS";
            this.lblTextoProgresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.pnlProgresso);
            this.Controls.Add(this.pnlFinancas);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlAlarmes);
            this.Controls.Add(this.pnlDataHora);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.pnlDataHora.ResumeLayout(false);
            this.pnlAlarmes.ResumeLayout(false);
            this.pnlAlarmes.PerformLayout();
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            this.pnlFinancas.ResumeLayout(false);
            this.pnlFinancas.PerformLayout();
            this.pnlProgresso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlDataHora;
        private System.Windows.Forms.Panel pnlAlarmes;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlFinancas;
        private System.Windows.Forms.Panel pnlProgresso;
        private System.Windows.Forms.Label lblAlarme;
        private System.Windows.Forms.Label lblTextoAlarme;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalGanhos;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblTextoEventos;
        private System.Windows.Forms.Label lblTextoFinancas;
        private System.Windows.Forms.Label lblTextoProgresso;
        private System.Windows.Forms.ListView listView1;


    }
}