using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace teamKeep.FORMS.CALENDÁRIO
{
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();
            txt_desc.BackColor = main.instance.formColor;
            txt_data.BackColor = main.instance.formColor;
        }

        private void txt_desc_Enter(object sender, EventArgs e)
        {
            lblErroLembrete.Visible = false;
            if (txt_desc.Text == "Digite aqui a descrição do evento") {
                txt_desc.Text = "";
            }
        }

        private void txt_desc_Leave(object sender, EventArgs e)
        {
            if (txt_desc.Text == "")
            {
                txt_desc.Text = "Digite aqui a descrição do evento";
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text != "Digite aqui a descrição do evento" && txt_desc.Text != "")
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    conexao.Open();
                    if (lblIDLembrete.Text == "id_lembrete")
                    {
                        MySqlDataAdapter comando = new MySqlDataAdapter("INSERT INTO calendario (dia_lembrete, nota_lembrete) VALUES ('" + txt_data.Text + "','" + txt_desc.Text + "')", conexao);
                        DataTable dados = new DataTable();
                        comando.Fill(dados);

                        alertas alerta = new alertas();
                        alertas.instance.tipoAlerta("Lembrete criado!", alertas.enmTipo.sucesso);
                    }
                    else
                    {
                        string sda = "UPDATE calendario SET nota_lembrete = '" + txt_desc.Text + "' WHERE id_lembrete =" + lblIDLembrete.Text + ";";
                        MySqlCommand MyCommand2 = new MySqlCommand(sda, conexao);
                        MySqlDataReader MyReader2;
                        MyReader2 = MyCommand2.ExecuteReader();

                        alertas alerta = new alertas();
                        alertas.instance.tipoAlerta("Lembrete atualizado!", alertas.enmTipo.aviso);
                    }
                    this.Hide();
                    conexao.Close();
                }
                catch (MySqlException)
                {

                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
                }
                catch (Exception ex)
                {

                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Erro:" + ex.GetType().ToString(), alertas.enmTipo.erro);

                }
                finally
                {
                    FORMS.main.instance.barraMenu.Height = FORMS.main.instance.botaoResumo.Height;
                    FORMS.main.instance.barraMenu.Top = FORMS.main.instance.botaoResumo.Top;
                    FORMS.main.instance.barraMenu.Left = FORMS.main.instance.botaoResumo.Left;
                    FORMS.main.instance.barraSelecionado.Visible = true;
                    FORMS.main.instance.barraSelecionado.Location = new Point(0, 130);

                    FORMS.main.instance.pnlMain.Controls.Clear();
                    calendario formCalendario = new calendario()
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    formCalendario.FormBorderStyle = FormBorderStyle.None;
                    formCalendario.BackColor = FORMS.main.instance.formColor;
                    FORMS.main.instance.pnlMain.Controls.Add(formCalendario);
                    formCalendario.Show();
                }
            }
            else lblErroLembrete.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FORMS.main.instance.barraMenu.Height = FORMS.main.instance.botaoResumo.Height;
            FORMS.main.instance.barraMenu.Top = FORMS.main.instance.botaoResumo.Top;
            FORMS.main.instance.barraMenu.Left = FORMS.main.instance.botaoResumo.Left;
            FORMS.main.instance.barraSelecionado.Visible = true;
            FORMS.main.instance.barraSelecionado.Location = new Point(0, 130);

            FORMS.main.instance.pnlMain.Controls.Clear();
            calendario formCalendario = new calendario()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formCalendario.FormBorderStyle = FormBorderStyle.None;
            formCalendario.BackColor = FORMS.main.instance.formColor;
            FORMS.main.instance.pnlMain.Controls.Add(formCalendario);
            formCalendario.Show();
        }
    }
}
