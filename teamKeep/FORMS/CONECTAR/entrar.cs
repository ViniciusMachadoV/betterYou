using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace teamKeep

{

    public partial class entrar : Form
    {
        public static entrar instance;
        public entrar()
        {
            InitializeComponent();
            instance = this;

            // CAIXAS DE TEXTO
            txtUsuarioLogin.BackColor = FORMS.main.instance.formColor;
            txtUsuarioLogin.ForeColor = Color.White;
            txtSenhaLogin.BackColor = FORMS.main.instance.formColor;
            txtSenhaLogin.ForeColor = Color.White;

            txtSenhaLogin.PasswordChar = '*';
            if (Properties.Settings.Default.nomeUsuario != string.Empty)
            {
                txtUsuarioLogin.Text = Properties.Settings.Default.nomeUsuario;
                txtSenhaLogin.Text = Properties.Settings.Default.senhaUsuario;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + (txtUsuarioLogin.Text + "' AND senha='" + txtSenhaLogin.Text + "'"), con);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                FORMS.main.instance.btnLogin.Text = txtUsuarioLogin.Text;


                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Usuário " + txtUsuarioLogin.Text + " conectado", alertas.enmTipo.conexao);

                FORMS.main.instance.barraMenu.Height = FORMS.main.instance.botaoResumo.Height;
                FORMS.main.instance.barraMenu.Top = FORMS.main.instance.botaoResumo.Top;
                FORMS.main.instance.barraMenu.Left = FORMS.main.instance.botaoResumo.Left;
                FORMS.main.instance.barraSelecionado.Visible = true;
                FORMS.main.instance.barraSelecionado.Location = new Point(0, 90);

                FORMS.main.instance.tituloPrincipal.Text = "RESUMO";
                FORMS.main.instance.pnlMain.Controls.Clear();
                home home_Vrb = new home()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                home_Vrb.FormBorderStyle = FormBorderStyle.None;
                home_Vrb.BackColor = FORMS.main.instance.formColor;
                FORMS.main.instance.pnlMain.Controls.Add(home_Vrb);
                home_Vrb.Show();

                if (checkLembrar.Checked)
                {
                    Properties.Settings.Default.nomeUsuario = txtUsuarioLogin.Text;
                    Properties.Settings.Default.senhaUsuario = txtSenhaLogin.Text;
                    Properties.Settings.Default.Save();

                }

            }
            else
            {
                lblErroEntrar.Text = "Credenciais incorretas, tente novamente.";
            }
        }

        private void btnExibirSenhaLogin_Click(object sender, EventArgs e)
        {
            if (txtSenhaLogin.PasswordChar == '\0')
            {
                btnExibirSenhaLogin.Text = "EXIBIR SENHA";
                txtSenhaLogin.PasswordChar = '*';
            }
            else {
                btnExibirSenhaLogin.Text = "OCULTAR SENHA";
                txtSenhaLogin.PasswordChar = '\0'; 
            }
        }
    }
}
