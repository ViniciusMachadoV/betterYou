
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
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();

            // CAIXAS DE TEXTO
            txtNomeCadastro.BackColor = FORMS.main.instance.formColor;
            txtEmailCadastro.BackColor = FORMS.main.instance.formColor;
            txtSenhaCadastro.BackColor = FORMS.main.instance.formColor;
            txtSenhaCadastro2.BackColor = FORMS.main.instance.formColor;

            txtSenhaCadastro.PasswordChar = '*';
            txtSenhaCadastro2.PasswordChar = '*';
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenhaCadastro.Text == txtSenhaCadastro2.Text)
            {
                
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + (txtNomeCadastro.Text + "'"), con);
                // select verifica se login + senha coincidem, lembre de trocar 'txt_logi.Text' e 'txt_senha.Text' para o nome que usou nos labels da sua tela de login
            
                DataTable dt = new DataTable(); //cria uma tabela, finalidade ainda não entendida
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {

                    MySqlConnection con2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    MySqlDataAdapter sda2 = new MySqlDataAdapter("INSERT INTO usuarios (usuario, senha, email) VALUES ('" + txtNomeCadastro.Text + "','" + txtSenhaCadastro.Text + "','" + txtEmailCadastro.Text + "')", con2);

                    DataTable dt2 = new DataTable(); //cria uma tabela, com os valores inseridos
                    sda2.Fill(dt2);
                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Bem vindo ao BetterYou!", alertas.enmTipo.conexao);

                    FORMS.main.instance.btnLogin.Text = txtNomeCadastro.Text;


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
                }
                else lblErroCadastrar.Text = "Esse nome de usuário já está sendo utilizado!";
            }
            else
            {
                lblErroCadastrar.Text = "As senhas não coincidem, digite novamente.";
            }
        }


        private void btnExibirSenhaCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenhaCadastro.PasswordChar == '\0')
            {
                btnExibirSenhaCadastro.Text = "EXIBIR SENHA";
                txtSenhaCadastro.PasswordChar = '*';
                txtSenhaCadastro2.PasswordChar = '*';
            }
            else
            {
                btnExibirSenhaCadastro.Text = "OCULTAR SENHA";
                txtSenhaCadastro.PasswordChar = '\0';
                txtSenhaCadastro2.PasswordChar = '\0';
            }
        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            if (lblErroCadastrar.Text != "")
            {
                lblErroCadastrar.Text = "";
            }
        }

        private void txtSenhaCadastro2_TextChanged(object sender, EventArgs e)
        {
            if (lblErroCadastrar.Text != "")
            {
                lblErroCadastrar.Text = "";
            }
        }

        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            lblErroCadastrar.Text = "";
        }
    }
}
