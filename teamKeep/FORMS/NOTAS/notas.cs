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
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();

            //Abrir conexão:
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
            // SQL SELECT no banco:
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM notas", con);
            //Criar tabela:
            DataTable dt = new DataTable();
            //Preencher tabela com o SELECT feito:
            sda.Fill(dt);
            //Receber número de linhas preenchidas:
            DataRow[] rows = dt.Select();
            try
            {
                if (rows.Length != 0)
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        nota notas = new nota()
                        {
                            TopLevel = false,
                            TopMost = true,
                            Visible = true
                        };
                        notas.lblTituloNota.Text = rows[i][2].ToString();
                        notas.lblDescricaoNota.Text = rows[i][3].ToString();
                        notas.lblIdNota.Text = rows[i][0].ToString();
                        notas.FormBorderStyle = FormBorderStyle.None;
                        tblNotas.Controls.Add(notas);
                    }
                }
                else lblSemNotas.Visible = true;
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

        private void btnCriarNota_Click(object sender, EventArgs e)
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
            FORMS.main.instance.pnlMain.Controls.Add(criarNota_Vrb);
            criarNota_Vrb.Show();
        }
    }
}
