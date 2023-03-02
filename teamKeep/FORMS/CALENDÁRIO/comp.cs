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
    public partial class comp : Form
    {
        public static comp instance;
        public comp()
        {
            InitializeComponent();
            btnEditarLembrete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnExcluirLembrete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            instance = this;
            this.BackColor = main.instance.formColor;
        }

        private void btnEditarLembrete_Click(object sender, EventArgs e)
        {

            calendario.instance.tabelaLembretes.Controls.Clear();
            agenda agenda = new agenda()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            agenda.FormBorderStyle = FormBorderStyle.None;
            agenda.BackColor = FORMS.main.instance.formColor;
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM calendario WHERE id_lembrete='" + lblIdLembrete.Text + "'", con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                DataRow[] rows = dta.Select();
                for (int i = 0; i < rows.Length; i++)
                {
                    agenda.txt_data.Text = rows[i][2].ToString();
                    agenda.txt_desc.Text = rows[i][3].ToString();
                    agenda.lblIDLembrete.Text = rows[i][0].ToString();
                }
                calendario.instance.tabelaLembretes.Controls.Add(agenda);
                agenda.Show();
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }
        }

        private void btnExcluirLembrete_Click(object sender, EventArgs e)
        {
            try
            {
                conexoesDB.delete("calendario", "id_lembrete", lblIdLembrete.Text);

                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Lembrete excluído", alertas.enmTipo.aviso);

                FORMS.main.instance.pnlMain.Controls.Clear();
                calendario calendario = new calendario()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                calendario.FormBorderStyle = FormBorderStyle.None;
                calendario.BackColor = FORMS.main.instance.formColor;
                FORMS.main.instance.pnlMain.Controls.Add(calendario);
                calendario.Show();

            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }
            catch (Exception ex)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: " + ex.GetType().ToString(), alertas.enmTipo.erro);
            }
        }

    }
}
