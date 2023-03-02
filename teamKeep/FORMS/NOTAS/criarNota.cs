using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Linha para usar MySql no código:
using MySql.Data.MySqlClient;

namespace teamKeep
{
    public partial class criarNota : Form
    {
        public criarNota()
        {
            InitializeComponent();
            txtTituloNota.BackColor = FORMS.main.instance.navColor;
            txtDescricaoNota.BackColor = FORMS.main.instance.navColor;
        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            if (txtDescricaoNota.Text != "")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    con.Open();
                    if (id_update.Text == "")
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter("INSERT INTO notas (titulo, descricao) VALUES ('" + txtTituloNota.Text + "','" + txtDescricaoNota.Text + "')", con);
                        DataTable dt = new DataTable(); //cria uma tabela, com os valores inseridos
                        sda.Fill(dt);

                        alertas alerta = new alertas();
                        alertas.instance.tipoAlerta("Nota criada!", alertas.enmTipo.sucesso);
                    }
                    else
                    {
                        string sda = "UPDATE notas SET titulo = '" + txtTituloNota.Text + "',descricao='" + txtDescricaoNota.Text + "' WHERE id_nota =" + id_update.Text + ";";
                        MySqlCommand MyCommand2 = new MySqlCommand(sda, con);
                        MySqlDataReader MyReader2;
                        MyReader2 = MyCommand2.ExecuteReader();

                        alertas alerta = new alertas();
                        alertas.instance.tipoAlerta("Nota atualizada!", alertas.enmTipo.aviso);
                    }
                    con.Close();
                }
                catch (MySqlException)
                {
                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
                }
                catch (Exception ex)
                {
                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Erro: " + ex, alertas.enmTipo.erro);
                }
                finally
                {
                    FORMS.main.instance.barraMenu.Height = FORMS.main.instance.botaoResumo.Height;
                    FORMS.main.instance.barraMenu.Top = FORMS.main.instance.botaoResumo.Top;
                    FORMS.main.instance.barraMenu.Left = FORMS.main.instance.botaoResumo.Left;
                    FORMS.main.instance.barraSelecionado.Visible = true;
                    FORMS.main.instance.barraSelecionado.Location = new Point(0, 290);

                    FORMS.main.instance.tituloPrincipal.Text = "NOTAS";
                    FORMS.main.instance.pnlMain.Controls.Clear();
                    notas notas_Vrb = new notas()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    notas_Vrb.FormBorderStyle = FormBorderStyle.None;
                    notas_Vrb.BackColor = FORMS.main.instance.formColor;
                    FORMS.main.instance.pnlMain.Controls.Add(notas_Vrb);
                    notas_Vrb.Show();
                }
            }
            else lblErroCriarNota.Visible = true;
        }

        private void txtDescricaoNota_Enter(object sender, EventArgs e)
        {
           lblErroCriarNota.Visible = false;
        }

        private void btnCancelarCriarNota_Click(object sender, EventArgs e)
        {
            FORMS.main.instance.barraMenu.Height = FORMS.main.instance.botaoResumo.Height;
            FORMS.main.instance.barraMenu.Top = FORMS.main.instance.botaoResumo.Top;
            FORMS.main.instance.barraMenu.Left = FORMS.main.instance.botaoResumo.Left;
            FORMS.main.instance.barraSelecionado.Visible = true;
            FORMS.main.instance.barraSelecionado.Location = new Point(0, 290);

            FORMS.main.instance.tituloPrincipal.Text = "NOTAS";
            FORMS.main.instance.pnlMain.Controls.Clear();
            notas notas_Vrb = new notas()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            notas_Vrb.FormBorderStyle = FormBorderStyle.None;
            notas_Vrb.BackColor = FORMS.main.instance.formColor;
            FORMS.main.instance.pnlMain.Controls.Add(notas_Vrb);
            notas_Vrb.Show();
        }
    }
}
