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

namespace teamKeep
{
    public partial class nota : Form
    {
        public static nota instance;
        public Label id_label;
        public TextBox txtTituloNot;

        public nota()
        {
            InitializeComponent();
            btnEditarNota.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnExcluirNota.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            instance = this;
            id_label = lblIdNota;
            this.BackColor = FORMS.main.instance.lighterForm;
        }
        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            FORMS.main.instance.pnlMain.Controls.Clear();
            criarNota criarNota_Vrb = new criarNota()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            criarNota_Vrb.FormBorderStyle = FormBorderStyle.None;
            criarNota_Vrb.BackColor = FORMS.main.instance.formColor;
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM notas WHERE id_nota='" + lblIdNota.Text+"'", con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                DataRow[] rows = dta.Select();
                for (int i = 0; i < rows.Length; i++)
                {
                    criarNota_Vrb.txtTituloNota.Text = rows[i][2].ToString();
                    criarNota_Vrb.txtDescricaoNota.Text = rows[i][3].ToString();
                    criarNota_Vrb.id_update.Text = rows[i][0].ToString();
                }
                FORMS.main.instance.pnlMain.Controls.Add(criarNota_Vrb);
                criarNota_Vrb.Show();
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }
        }
        private void btnExcluirNota_Click(object sender, EventArgs e)
        {
            try
            {
                conexoesDB.delete("notas", "id_nota", lblIdNota.Text);

                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Nota excluída", alertas.enmTipo.aviso);

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
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }
            catch (Exception ex)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: "+ex.GetType().ToString(), alertas.enmTipo.erro);
            }
        }

    }
}
