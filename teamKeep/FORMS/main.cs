using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace teamKeep.FORMS

{
    public partial class main : Form
    {
        public static main instance;
        public Panel pnlMain;
        public Panel barraMenu;
        public Panel barraSelecionado;
        public Button botaoResumo;
        public Label tituloPrincipal;
        public Button btnLogin;

        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        private bool mover = false;
        private Point pontoInicial = new Point(0,0);

        bool barraAumentada;

        public Color formColor = ControlPaint.Light(Color.FromArgb(25, 53, 73), .046f);
        public Color lighterForm = ControlPaint.Light(Color.FromArgb(25, 53, 73), .1f);
        public Color textColors = ControlPaint.Light(Color.FromArgb(158, 255, 255), .08f);
        public Color navColor = ControlPaint.Light(Color.FromArgb(21, 35, 45), .031f);
        public Color mainColor = ControlPaint.Light(Color.FromArgb(22, 47, 66), .041f);
        public Color greenText = ControlPaint.Light(Color.FromArgb(119, 247, 94), .09f);
        public Color redText = ControlPaint.Light(Color.FromArgb(224, 1, 1), .08f);

        Process xamppStart = new Process();
        Process xamppStop = new Process();

        public main()
        {
            try
            {
                using (xamppStart)
                {
                    string inicializadorXampp;
                    if (File.Exists(@"D:\xampp\xampp_start.exe")) inicializadorXampp = @"D:\xampp\xampp_start.exe";
                    //VERIFICA SE xamppStart ESTÁ NO DISCO 'D:' OU 'C:' MANUALMENTE, NÃO É IDEAL MAS OUTRAS SOLUÇÕES COMO:
                    //string @path = Path.GetFullPath(@"\xampp\xampp_start.bat");
                    //APRESENTARAM INCONSISTÊNCIAS DE FUNCIONAMENTO E OPTAMOS POR ESSE MÉTODO PARA FINS DE APRESENTAÇÃO.
                    else inicializadorXampp = @"C:\xampp\xampp_start.exe";
                    xamppStart.StartInfo.UseShellExecute = false;
                    xamppStart.StartInfo.FileName = inicializadorXampp;
                    xamppStart.StartInfo.CreateNoWindow = true;
                    xamppStart.Start();
                }
            }
            catch (Win32Exception)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("O diretório do XAMPP não foi localizado", alertas.enmTipo.erro);

                alertas alerta2 = new alertas();
                alertas.instance.tipoAlerta("Inicie / Instale os serviços XAMPP para continuar", alertas.enmTipo.info);
            }
            catch (Exception ex)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: " + ex.GetType().ToString(), alertas.enmTipo.erro);
            }
            InitializeComponent();

            miniMenu.BackColor = textColors;
            miniMenuAjustarAlarme.ForeColor = navColor;
            miniMenuCriarNota.ForeColor = navColor;
            miniMenuMinimizar.ForeColor = navColor;
            miniMenuFechar.ForeColor = navColor;

            if (iconNotif == null) iconNotif.Dispose();
            instance = this;


            pnlMain = pnlCarregador;
            barraMenu = pnlNav;
            barraSelecionado = pnlSelecionado;
            botaoResumo = btnResumo;
            tituloPrincipal = lblTitulo;
            btnLogin = btnConectar;

            conexoesDB.criar();

            this.iconNotif = new System.Windows.Forms.NotifyIcon(this.components);

            btnResumo.ForeColor = textColors;
            btnCalendario.ForeColor = textColors;
            btnProgresso.ForeColor = textColors;
            btnFinancas.ForeColor = textColors;
            btnRelogio.ForeColor = textColors;
            btnNotas.ForeColor = textColors;
            btnResumo.ForeColor = textColors;
            btnConfiguracoes.ForeColor = textColors;
            pnlSelecionado.BackColor = textColors;
            lblTitulo.ForeColor = textColors;
            pnlNav.BackColor = navColor;
            this.BackColor = mainColor;
            pnlMover.BackColor = Color.FromArgb(0, Color.Black);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));

            lblTitulo.Text = "RESUMO";
            this.pnlCarregador.Controls.Clear();
            home home_Vrb = new home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            home_Vrb.FormBorderStyle = FormBorderStyle.None;
            home_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(home_Vrb);
            home_Vrb.Show();
        }
        private void moverBarra_Tick(object sender, EventArgs e)
        {
            if (barraAumentada)
            {
                pnlNav.Width -= 10;
                if (pnlNav.Width == pnlNav.MinimumSize.Width)
                {
                    barraAumentada = false;
                    moverBarra.Stop();
                }
            }
            else
            {
                pnlNav.Width += 10;
                if (pnlNav.Width == pnlNav.MaximumSize.Width)
                {
                    barraAumentada = true;
                    moverBarra.Stop();
                }
            }
        }
        private void btnMoverBarra_Click(object sender, EventArgs e)
        {
            moverBarra.Start();
        }
        private void btnResumo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnResumo.Height;
            pnlNav.Top = btnResumo.Top;
            pnlNav.Left = btnResumo.Left;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 90);

            lblTitulo.Text = "RESUMO";
            this.pnlCarregador.Controls.Clear();
            home home_Vrb = new home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            home_Vrb.FormBorderStyle = FormBorderStyle.None;
            home_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(home_Vrb);
            home_Vrb.Show();
        }
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendario.Height;
            pnlNav.Top = btnCalendario.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 130);

            lblTitulo.Text = "CALENDÁRIO";
            this.pnlCarregador.Controls.Clear();
            calendario calendario_Vrb = new calendario()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            calendario_Vrb.FormBorderStyle = FormBorderStyle.None;
            calendario_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(calendario_Vrb);
            calendario_Vrb.Show();
        }
        private void btnProgresso_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProgresso.Height;
            pnlNav.Top = btnProgresso.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location =  new Point(0,170);

            lblTitulo.Text = "PROGRESSO";
            this.pnlCarregador.Controls.Clear();
            progresso progresso_Vrb = new progresso()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            progresso_Vrb.FormBorderStyle = FormBorderStyle.None;
            progresso_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(progresso_Vrb);
            progresso_Vrb.Show();
        }
        private void btnFinancas_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFinancas.Height;
            pnlNav.Top = btnFinancas.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 210);

            lblTitulo.Text = "FINANÇAS";
            this.pnlCarregador.Controls.Clear();
            FORMS.FINANÇAS.financas financas_Vrb = new FORMS.FINANÇAS.financas()
             {
                 Dock = DockStyle.Fill,
                 TopLevel = false,
                 TopMost = true
             };
            financas_Vrb.FormBorderStyle = FormBorderStyle.None;
            financas_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(financas_Vrb);
            financas_Vrb.Show();
        }
        private void btnRelogio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRelogio.Height;
            pnlNav.Top = btnRelogio.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 250);

            lblTitulo.Text = "RELÓGIO";
            this.pnlCarregador.Controls.Clear();
            FORMS.RELÓGIO.relogio relogio_Vrb = new FORMS.RELÓGIO.relogio()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            relogio_Vrb.FormBorderStyle = FormBorderStyle.None;
            relogio_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(relogio_Vrb);
            relogio_Vrb.Show();
        }
        private void btnNotas_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNotas.Height;
            pnlNav.Top = btnNotas.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 290);

            lblTitulo.Text = "NOTAS";
            this.pnlCarregador.Controls.Clear();
            notas notas_Vrb = new notas()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            notas_Vrb.FormBorderStyle = FormBorderStyle.None;
            notas_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(notas_Vrb);
            notas_Vrb.Show();
        }
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfiguracoes.Height;
            pnlNav.Top = btnConfiguracoes.Top;
            pnlSelecionado.Visible = true;
            pnlSelecionado.Location = new Point(0, 560);

            lblTitulo.Text = "CONFIGURAÇÕES";
            this.pnlCarregador.Controls.Clear();
            configuracoes configuracoes_Vrb = new configuracoes()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            configuracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            configuracoes_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(configuracoes_Vrb);
            configuracoes_Vrb.Show();
        }
        private void btnResumo_Leave(object sender, EventArgs e)
        {
            btnResumo.BackColor = navColor;
        }
        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            btnCalendario.BackColor = navColor;
        }
        private void btnProgresso_Leave(object sender, EventArgs e)
        {
            btnProgresso.BackColor = navColor;
        }
        private void btnFinancas_Leave(object sender, EventArgs e)
        {
            btnFinancas.BackColor = navColor;
        }
        private void btnRelogio_Leave(object sender, EventArgs e)
        {
            btnRelogio.BackColor = navColor;
        }
        private void btnNotas_Leave(object sender, EventArgs e)
        {
            btnNotas.BackColor = navColor;
        }
        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            btnConfiguracoes.BackColor = navColor;
        }
        // MOVIMENTAR JANELA DO PROGRAMA COM pnlMover e pnlMover2
        private void pnlMover_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            pontoInicial = new Point(e.X, e.Y);
        }
        private void pnlMover_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void pnlMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point ponto = PointToScreen(e.Location);
                Location = new Point(ponto.X - this.pontoInicial.X, ponto.Y - this.pontoInicial.Y);
            }
        }
        private void pnlMover2_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            pontoInicial = new Point(e.X, e.Y);
        }
        private void pnlMover2_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void pnlMover2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point ponto = PointToScreen(e.Location);
                Location = new Point(ponto.X - this.pontoInicial.X, ponto.Y - this.pontoInicial.Y);
            }
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            this.pnlCarregador.Controls.Clear();
            pnlSelecionado.Visible = false;
            conectar conectar_Vrb = new conectar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            conectar_Vrb.FormBorderStyle = FormBorderStyle.None;
            conectar_Vrb.BackColor = formColor;
            this.pnlCarregador.Controls.Add(conectar_Vrb);
            conectar_Vrb.Show();
        }
        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.nomeUsuario = null;
            Properties.Settings.Default.senhaUsuario = null;
            Properties.Settings.Default.Save();


            FORMS.main.instance.btnLogin.Text = "CONECTAR";
            alertas alerta = new alertas();
            alertas.instance.tipoAlerta("Até logo!", alertas.enmTipo.conexao);

        }
        // BOTÃO MAXIMIZAR
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal){
                this.WindowState = FormWindowState.Maximized;
            }
            else { 
                this.WindowState = FormWindowState.Normal; 
            }
        }
        // BOTÃO MINIMIZAR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // BOTÃO FECHAR PROGRAMA
        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(255,0,0);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                using (xamppStop)
                {
                    xamppStop.StartInfo.UseShellExecute = false;
                    string finalizarXampp;
                    if (File.Exists(@"D:\xampp\xampp_start.exe")) finalizarXampp = @"D:\xampp\xampp_stop.exe";
                    else finalizarXampp = @"C:\xampp\xampp_stop.exe";
                    xamppStop.StartInfo.FileName = finalizarXampp;
                    xamppStop.StartInfo.CreateNoWindow = true;
                    //xamppStop.Start();
                }
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("O finalizador do XAMPP não foi localizado", alertas.enmTipo.erro);
            }
            catch (Exception ex)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: " + ex.GetType().ToString(), alertas.enmTipo.erro);
            }
            Application.Exit();
            iconNotif.Dispose();
        }

        private void iconNotif_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void miniMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "miniMenuFechar") Application.Exit();
            else if (e.ClickedItem.Name.ToString() == "miniMenuMinimizar") this.WindowState = FormWindowState.Minimized;
            else if (e.ClickedItem.Name.ToString() == "miniMenuCriarNota")
            {
                this.WindowState = FormWindowState.Normal;
                FORMS.main.instance.pnlMain.Controls.Clear();
                criarNota criarNota_Vrb = new criarNota()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                criarNota_Vrb.FormBorderStyle = FormBorderStyle.None;
                criarNota_Vrb.BackColor = FORMS.main.instance.formColor;
                FORMS.main.instance.pnlMain.Controls.Add(criarNota_Vrb);
                criarNota_Vrb.Show();
            }
            else if (e.ClickedItem.Name.ToString() == "miniMenuAjustarAlarme")
            {
                //
            }
        }
    }
}