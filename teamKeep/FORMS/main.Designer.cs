namespace teamKeep.FORMS

{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlSelecionado = new System.Windows.Forms.Panel();
            this.btnMoverBarra = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnRelogio = new System.Windows.Forms.Button();
            this.btnFinancas = new System.Windows.Forms.Button();
            this.btnProgresso = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblDescricaoUsuario = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMover = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnlMover2 = new System.Windows.Forms.Panel();
            this.pnlCarregador = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.moverBarra = new System.Windows.Forms.Timer(this.components);
            this.iconNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.miniMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miniMenuMinimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuCriarNota = new System.Windows.Forms.ToolStripMenuItem();
            this.miniMenuAjustarAlarme = new System.Windows.Forms.ToolStripMenuItem();
            this.notifDesktop = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlNav.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.miniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.pnlSelecionado);
            this.pnlNav.Controls.Add(this.btnMoverBarra);
            this.pnlNav.Controls.Add(this.btnConfiguracoes);
            this.pnlNav.Controls.Add(this.btnNotas);
            this.pnlNav.Controls.Add(this.btnRelogio);
            this.pnlNav.Controls.Add(this.btnFinancas);
            this.pnlNav.Controls.Add(this.btnProgresso);
            this.pnlNav.Controls.Add(this.btnCalendario);
            this.pnlNav.Controls.Add(this.btnResumo);
            this.pnlNav.Controls.Add(this.pnlUsuario);
            this.pnlNav.Controls.Add(this.pnlMover);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.MaximumSize = new System.Drawing.Size(200, 600);
            this.pnlNav.MinimumSize = new System.Drawing.Size(40, 600);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(200, 600);
            this.pnlNav.TabIndex = 0;
            // 
            // pnlSelecionado
            // 
            this.pnlSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlSelecionado.Location = new System.Drawing.Point(0, 90);
            this.pnlSelecionado.Name = "pnlSelecionado";
            this.pnlSelecionado.Size = new System.Drawing.Size(3, 40);
            this.pnlSelecionado.TabIndex = 1;
            // 
            // btnMoverBarra
            // 
            this.btnMoverBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoverBarra.FlatAppearance.BorderSize = 0;
            this.btnMoverBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoverBarra.Image = ((System.Drawing.Image)(resources.GetObject("btnMoverBarra.Image")));
            this.btnMoverBarra.Location = new System.Drawing.Point(0, 0);
            this.btnMoverBarra.Name = "btnMoverBarra";
            this.btnMoverBarra.Size = new System.Drawing.Size(30, 30);
            this.btnMoverBarra.TabIndex = 11;
            this.btnMoverBarra.UseVisualStyleBackColor = true;
            this.btnMoverBarra.Click += new System.EventHandler(this.btnMoverBarra_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 560);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(200, 40);
            this.btnConfiguracoes.TabIndex = 6;
            this.btnConfiguracoes.Text = "    CONFIGURAÇÕES";
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            this.btnConfiguracoes.Leave += new System.EventHandler(this.btnConfiguracoes_Leave);
            // 
            // btnNotas
            // 
            this.btnNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(0, 290);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(200, 40);
            this.btnNotas.TabIndex = 10;
            this.btnNotas.Text = "    NOTAS";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            this.btnNotas.Leave += new System.EventHandler(this.btnNotas_Leave);
            // 
            // btnRelogio
            // 
            this.btnRelogio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelogio.FlatAppearance.BorderSize = 0;
            this.btnRelogio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelogio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRelogio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelogio.Image")));
            this.btnRelogio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelogio.Location = new System.Drawing.Point(0, 250);
            this.btnRelogio.Name = "btnRelogio";
            this.btnRelogio.Size = new System.Drawing.Size(200, 40);
            this.btnRelogio.TabIndex = 8;
            this.btnRelogio.Text = "    RELÓGIO";
            this.btnRelogio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelogio.UseVisualStyleBackColor = true;
            this.btnRelogio.Click += new System.EventHandler(this.btnRelogio_Click);
            this.btnRelogio.Leave += new System.EventHandler(this.btnRelogio_Leave);
            // 
            // btnFinancas
            // 
            this.btnFinancas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinancas.FlatAppearance.BorderSize = 0;
            this.btnFinancas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFinancas.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancas.Image")));
            this.btnFinancas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinancas.Location = new System.Drawing.Point(0, 210);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Size = new System.Drawing.Size(200, 40);
            this.btnFinancas.TabIndex = 9;
            this.btnFinancas.Text = "    FINANÇAS";
            this.btnFinancas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinancas.UseVisualStyleBackColor = true;
            this.btnFinancas.Click += new System.EventHandler(this.btnFinancas_Click);
            this.btnFinancas.Leave += new System.EventHandler(this.btnFinancas_Leave);
            // 
            // btnProgresso
            // 
            this.btnProgresso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgresso.FlatAppearance.BorderSize = 0;
            this.btnProgresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgresso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProgresso.Image = ((System.Drawing.Image)(resources.GetObject("btnProgresso.Image")));
            this.btnProgresso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgresso.Location = new System.Drawing.Point(0, 170);
            this.btnProgresso.Name = "btnProgresso";
            this.btnProgresso.Size = new System.Drawing.Size(200, 40);
            this.btnProgresso.TabIndex = 3;
            this.btnProgresso.Text = "    PROGRESSO";
            this.btnProgresso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgresso.UseVisualStyleBackColor = true;
            this.btnProgresso.Click += new System.EventHandler(this.btnProgresso_Click);
            this.btnProgresso.Leave += new System.EventHandler(this.btnProgresso_Leave);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(0, 130);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(200, 40);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "    CALENDÁRIO";
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendario.Leave += new System.EventHandler(this.btnCalendario_Leave);
            // 
            // btnResumo
            // 
            this.btnResumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumo.FlatAppearance.BorderSize = 0;
            this.btnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnResumo.Image = ((System.Drawing.Image)(resources.GetObject("btnResumo.Image")));
            this.btnResumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumo.Location = new System.Drawing.Point(0, 90);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(200, 40);
            this.btnResumo.TabIndex = 2;
            this.btnResumo.Text = "    RESUMO";
            this.btnResumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumo.UseVisualStyleBackColor = true;
            this.btnResumo.Click += new System.EventHandler(this.btnResumo_Click);
            this.btnResumo.Leave += new System.EventHandler(this.btnResumo_Leave);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnLogout);
            this.pnlUsuario.Controls.Add(this.fotoPerfil);
            this.pnlUsuario.Controls.Add(this.btnConectar);
            this.pnlUsuario.Controls.Add(this.lblDescricaoUsuario);
            this.pnlUsuario.Controls.Add(this.lblUser);
            this.pnlUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 30);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(200, 60);
            this.pnlUsuario.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(150, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(32, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("fotoPerfil.Image")));
            this.fotoPerfil.Location = new System.Drawing.Point(2, 14);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(32, 32);
            this.fotoPerfil.TabIndex = 4;
            this.fotoPerfil.TabStop = false;
            this.fotoPerfil.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(53, 20);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(85, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblDescricaoUsuario
            // 
            this.lblDescricaoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDescricaoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoUsuario.Location = new System.Drawing.Point(40, 155);
            this.lblDescricaoUsuario.Name = "lblDescricaoUsuario";
            this.lblDescricaoUsuario.Size = new System.Drawing.Size(120, 20);
            this.lblDescricaoUsuario.TabIndex = 2;
            this.lblDescricaoUsuario.Text = "alguma descricao";
            this.lblDescricaoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUser.Location = new System.Drawing.Point(50, 135);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMover
            // 
            this.pnlMover.BackColor = System.Drawing.Color.Transparent;
            this.pnlMover.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlMover.ForeColor = System.Drawing.Color.Transparent;
            this.pnlMover.Location = new System.Drawing.Point(36, 0);
            this.pnlMover.Name = "pnlMover";
            this.pnlMover.Size = new System.Drawing.Size(164, 30);
            this.pnlMover.TabIndex = 1;
            this.pnlMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMover_MouseDown);
            this.pnlMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMover_MouseMove);
            this.pnlMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMover_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(768, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 32);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(736, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pnlMover2
            // 
            this.pnlMover2.BackColor = System.Drawing.Color.Transparent;
            this.pnlMover2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlMover2.Location = new System.Drawing.Point(200, 0);
            this.pnlMover2.Name = "pnlMover2";
            this.pnlMover2.Size = new System.Drawing.Size(530, 30);
            this.pnlMover2.TabIndex = 5;
            this.pnlMover2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMover2_MouseDown);
            this.pnlMover2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMover2_MouseMove);
            this.pnlMover2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMover2_MouseUp);
            // 
            // pnlCarregador
            // 
            this.pnlCarregador.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarregador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCarregador.Location = new System.Drawing.Point(200, 80);
            this.pnlCarregador.MinimumSize = new System.Drawing.Size(600, 520);
            this.pnlCarregador.Name = "pnlCarregador";
            this.pnlCarregador.Size = new System.Drawing.Size(600, 520);
            this.pnlCarregador.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTitulo.Location = new System.Drawing.Point(218, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 29);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "INÍCIO";
            // 
            // moverBarra
            // 
            this.moverBarra.Enabled = true;
            this.moverBarra.Interval = 10;
            this.moverBarra.Tick += new System.EventHandler(this.moverBarra_Tick);
            // 
            // iconNotif
            // 
            this.iconNotif.ContextMenuStrip = this.miniMenu;
            this.iconNotif.Icon = ((System.Drawing.Icon)(resources.GetObject("iconNotif.Icon")));
            this.iconNotif.Text = "betterYou";
            this.iconNotif.Visible = true;
            this.iconNotif.DoubleClick += new System.EventHandler(this.iconNotif_DoubleClick);
            // 
            // miniMenu
            // 
            this.miniMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.miniMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.miniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniMenuCriarNota,
            this.miniMenuAjustarAlarme,
            this.miniMenuMinimizar,
            this.miniMenuFechar});
            this.miniMenu.Name = "miniMenu";
            this.miniMenu.ShowImageMargin = false;
            this.miniMenu.Size = new System.Drawing.Size(143, 130);
            this.miniMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.miniMenu_ItemClicked);
            // 
            // miniMenuMinimizar
            // 
            this.miniMenuMinimizar.ForeColor = System.Drawing.Color.White;
            this.miniMenuMinimizar.Name = "miniMenuMinimizar";
            this.miniMenuMinimizar.Size = new System.Drawing.Size(142, 26);
            this.miniMenuMinimizar.Text = "Minimizar";
            // 
            // miniMenuFechar
            // 
            this.miniMenuFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miniMenuFechar.ForeColor = System.Drawing.Color.Yellow;
            this.miniMenuFechar.Name = "miniMenuFechar";
            this.miniMenuFechar.Size = new System.Drawing.Size(142, 26);
            this.miniMenuFechar.Text = "Fechar";
            // 
            // miniMenuCriarNota
            // 
            this.miniMenuCriarNota.Name = "miniMenuCriarNota";
            this.miniMenuCriarNota.Size = new System.Drawing.Size(142, 26);
            this.miniMenuCriarNota.Text = "Criar nota";
            // 
            // miniMenuAjustarAlarme
            // 
            this.miniMenuAjustarAlarme.Name = "miniMenuAjustarAlarme";
            this.miniMenuAjustarAlarme.Size = new System.Drawing.Size(142, 26);
            this.miniMenuAjustarAlarme.Text = "Ligar alarme";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCarregador);
            this.Controls.Add(this.pnlMover2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlNav);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.pnlNav.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.miniMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnProgresso;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Label lblDescricaoUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSelecionado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlMover;
        private System.Windows.Forms.Panel pnlMover2;
        public System.Windows.Forms.Panel pnlCarregador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnFinancas;
        private System.Windows.Forms.Button btnRelogio;
        private System.Windows.Forms.Timer moverBarra;
        public System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.PictureBox fotoPerfil;
        private System.Windows.Forms.Button btnMoverBarra;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.NotifyIcon iconNotif;
        private System.Windows.Forms.ContextMenuStrip miniMenu;
        private System.Windows.Forms.ToolStripMenuItem miniMenuMinimizar;
        private System.Windows.Forms.ToolStripMenuItem miniMenuFechar;
        private System.Windows.Forms.NotifyIcon notifDesktop;
        private System.Windows.Forms.ToolStripMenuItem miniMenuCriarNota;
        private System.Windows.Forms.ToolStripMenuItem miniMenuAjustarAlarme;
    }
}

