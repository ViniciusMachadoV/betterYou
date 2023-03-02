namespace teamKeep.FORMS.FINANÇAS
{
    partial class financas
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
            this.btnTransacao = new System.Windows.Forms.Button();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblValorGastos = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblNotaEntrada = new System.Windows.Forms.Label();
            this.txtNotaEntrada = new System.Windows.Forms.TextBox();
            this.txtNotaSaida = new System.Windows.Forms.TextBox();
            this.lblNotaSaida = new System.Windows.Forms.Label();
            this.lblValorGanhos = new System.Windows.Forms.Label();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoFinanca = new System.Windows.Forms.Label();
            this.lblDescricaoFinanca = new System.Windows.Forms.Label();
            this.lblValorFinanca = new System.Windows.Forms.Label();
            this.lblDataFinanca = new System.Windows.Forms.Label();
            this.pnlRelatorio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransacao
            // 
            this.btnTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacao.Location = new System.Drawing.Point(243, 103);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Size = new System.Drawing.Size(96, 36);
            this.btnTransacao.TabIndex = 0;
            this.btnTransacao.Text = "ENVIAR";
            this.btnTransacao.UseVisualStyleBackColor = true;
            this.btnTransacao.Click += new System.EventHandler(this.btnTransacao_Click);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(7, 37);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(64, 16);
            this.lblGastos.TabIndex = 1;
            this.lblGastos.Text = "GASTOS";
            // 
            // lblValorGastos
            // 
            this.lblValorGastos.AutoSize = true;
            this.lblValorGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGastos.ForeColor = System.Drawing.Color.Red;
            this.lblValorGastos.Location = new System.Drawing.Point(145, 37);
            this.lblValorGastos.Name = "lblValorGastos";
            this.lblValorGastos.Size = new System.Drawing.Size(49, 16);
            this.lblValorGastos.TabIndex = 2;
            this.lblValorGastos.Text = "R$0,00\r\n";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(123, 18);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(68, 20);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "GANHO";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.Location = new System.Drawing.Point(392, 18);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(65, 20);
            this.lblGasto.TabIndex = 4;
            this.lblGasto.Text = "GASTO";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(106, 41);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 5;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(376, 41);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(100, 20);
            this.txtSaida.TabIndex = 6;
            // 
            // lblNotaEntrada
            // 
            this.lblNotaEntrada.AutoSize = true;
            this.lblNotaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaEntrada.Location = new System.Drawing.Point(111, 67);
            this.lblNotaEntrada.Name = "lblNotaEntrada";
            this.lblNotaEntrada.Size = new System.Drawing.Size(84, 20);
            this.lblNotaEntrada.TabIndex = 8;
            this.lblNotaEntrada.Text = "Descrição:";
            // 
            // txtNotaEntrada
            // 
            this.txtNotaEntrada.Location = new System.Drawing.Point(106, 90);
            this.txtNotaEntrada.Name = "txtNotaEntrada";
            this.txtNotaEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtNotaEntrada.TabIndex = 10;
            // 
            // txtNotaSaida
            // 
            this.txtNotaSaida.Location = new System.Drawing.Point(376, 90);
            this.txtNotaSaida.Name = "txtNotaSaida";
            this.txtNotaSaida.Size = new System.Drawing.Size(100, 20);
            this.txtNotaSaida.TabIndex = 11;
            // 
            // lblNotaSaida
            // 
            this.lblNotaSaida.AutoSize = true;
            this.lblNotaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaSaida.Location = new System.Drawing.Point(382, 67);
            this.lblNotaSaida.Name = "lblNotaSaida";
            this.lblNotaSaida.Size = new System.Drawing.Size(84, 20);
            this.lblNotaSaida.TabIndex = 12;
            this.lblNotaSaida.Text = "Descrição:";
            // 
            // lblValorGanhos
            // 
            this.lblValorGanhos.AutoSize = true;
            this.lblValorGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGanhos.ForeColor = System.Drawing.Color.Lime;
            this.lblValorGanhos.Location = new System.Drawing.Point(145, 10);
            this.lblValorGanhos.Name = "lblValorGanhos";
            this.lblValorGanhos.Size = new System.Drawing.Size(49, 16);
            this.lblValorGanhos.TabIndex = 15;
            this.lblValorGanhos.Text = "R$0,00";
            // 
            // lblGanhos
            // 
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhos.Location = new System.Drawing.Point(7, 10);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(66, 16);
            this.lblGanhos.TabIndex = 14;
            this.lblGanhos.Text = "GANHOS";
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaldo.Location = new System.Drawing.Point(145, 66);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(49, 16);
            this.lblValorSaldo.TabIndex = 17;
            this.lblValorSaldo.Text = "R$0,00";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(7, 66);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(53, 16);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "SALDO";
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.Controls.Add(this.lblGanhos);
            this.pnlRelatorio.Controls.Add(this.lblValorSaldo);
            this.pnlRelatorio.Controls.Add(this.lblGastos);
            this.pnlRelatorio.Controls.Add(this.lblSaldo);
            this.pnlRelatorio.Controls.Add(this.lblValorGastos);
            this.pnlRelatorio.Controls.Add(this.lblValorGanhos);
            this.pnlRelatorio.Location = new System.Drawing.Point(198, 145);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(200, 100);
            this.pnlRelatorio.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 220);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(49, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 220);
            this.panel1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblTipoFinanca, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescricaoFinanca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValorFinanca, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDataFinanca, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 25);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lblTipoFinanca
            // 
            this.lblTipoFinanca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoFinanca.Location = new System.Drawing.Point(3, 0);
            this.lblTipoFinanca.Name = "lblTipoFinanca";
            this.lblTipoFinanca.Size = new System.Drawing.Size(84, 25);
            this.lblTipoFinanca.TabIndex = 0;
            this.lblTipoFinanca.Text = "TIPO";
            this.lblTipoFinanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescricaoFinanca
            // 
            this.lblDescricaoFinanca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoFinanca.Location = new System.Drawing.Point(93, 0);
            this.lblDescricaoFinanca.Name = "lblDescricaoFinanca";
            this.lblDescricaoFinanca.Size = new System.Drawing.Size(144, 25);
            this.lblDescricaoFinanca.TabIndex = 1;
            this.lblDescricaoFinanca.Text = "DESCRIÇÃO";
            this.lblDescricaoFinanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorFinanca
            // 
            this.lblValorFinanca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorFinanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinanca.Location = new System.Drawing.Point(243, 0);
            this.lblValorFinanca.Name = "lblValorFinanca";
            this.lblValorFinanca.Size = new System.Drawing.Size(84, 25);
            this.lblValorFinanca.TabIndex = 2;
            this.lblValorFinanca.Text = "VALOR";
            this.lblValorFinanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataFinanca
            // 
            this.lblDataFinanca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataFinanca.Location = new System.Drawing.Point(333, 0);
            this.lblDataFinanca.Name = "lblDataFinanca";
            this.lblDataFinanca.Size = new System.Drawing.Size(164, 25);
            this.lblDataFinanca.TabIndex = 3;
            this.lblDataFinanca.Text = "DATA";
            this.lblDataFinanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRelatorio);
            this.Controls.Add(this.lblNotaSaida);
            this.Controls.Add(this.txtNotaSaida);
            this.Controls.Add(this.txtNotaEntrada);
            this.Controls.Add(this.lblNotaEntrada);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.btnTransacao);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "financas";
            this.Text = "financas";
            this.pnlRelatorio.ResumeLayout(false);
            this.pnlRelatorio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransacao;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblValorGastos;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.Label lblNotaEntrada;
        private System.Windows.Forms.TextBox txtNotaEntrada;
        private System.Windows.Forms.TextBox txtNotaSaida;
        private System.Windows.Forms.Label lblNotaSaida;
        private System.Windows.Forms.Label lblValorGanhos;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTipoFinanca;
        private System.Windows.Forms.Label lblDescricaoFinanca;
        private System.Windows.Forms.Label lblValorFinanca;
        private System.Windows.Forms.Label lblDataFinanca;
    }
}