using System;
using System.Globalization;
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
    public partial class home : Form
    {
        public static home instance;
        public Label labelValorGanhos;
        public Label labelValorGastos;
        public Label labelValorSaldo;
        decimal entradas, saidas, total;
        public home()
        {
            InitializeComponent();
            instance = this;
            labelValorGanhos = lblTotalGanhos;
            labelValorGastos = lblTotalGastos;
            labelValorSaldo = lblTotalSaldo;

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM alarmes", con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                DataRow[] rows = dta.Select();
                for (int i = 0; i < rows.Length; i++)
                {
                    if (rows[i][2].ToString() != "")
                    {
                        lblAlarme.Text = rows[i][2].ToString();
                    }
                    else
                    {
                        lblAlarme.Text = " Nenhum alarme definido!";
                    }
                }
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }

            try
            {
                MySqlConnection conexao3 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                conexao3.Open();
                MySqlDataAdapter comando3 = new MySqlDataAdapter("SELECT * FROM financas", conexao3);
                DataTable dt = new DataTable();
                comando3.Fill(dt);
                if (dt.Rows.Count != 0)
                {

                    MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand("SELECT SUM(entrada) FROM financas", conexao);
                    comando.CommandType = CommandType.Text;
                    MySqlDataReader leitorComando;
                    leitorComando = comando.ExecuteReader();
                    if (leitorComando != null)
                    {
                        leitorComando.Read();
                        if (leitorComando.Read() != true)
                        {
                            entradas = leitorComando.GetDecimal(0);
                        }
                    }
                    lblTotalGanhos.Text = "R$" + leitorComando.GetString(0);

                    MySqlConnection conexao2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    conexao2.Open();
                    MySqlCommand comando2 = new MySqlCommand("SELECT SUM(saida) FROM financas", conexao2);
                    comando2.CommandType = CommandType.Text;
                    MySqlDataReader leitorComando2;
                    leitorComando2 = comando2.ExecuteReader();
                    leitorComando2.Read();
                    saidas = leitorComando2.GetDecimal(0);
                    lblTotalGastos.Text = "R$" + leitorComando2.GetString(0);
                    total = entradas - saidas;
                    conexao.Close();
                    conexao2.Close();

                    lblTotalSaldo.Text = "R$" + total.ToString();
                }
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }

            //EXIBE DETALHES
            listView1.View = View.Details;

            //PERMITE AO USUARIO EDITAR O TEXTO
            listView1.LabelEdit = false;

            //REALOCAR COLUNAS
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = false;

            //ESTILIZAR
            listView1.BackColor = FORMS.main.instance.formColor;
            listView1.ForeColor = Color.White;

            //anexa subitems no listView1
            listView1.Columns.Add("DATA", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("DESCRICAO", 190, HorizontalAlignment.Left);
            

            try
            {
                string string_cnn = "datasource=localhost;port=3306;username=root;password=;database=teamkeep";
                string sql = "SELECT * FROM calendario";
                MySqlConnection cnn = new MySqlConnection(string_cnn);
                cnn.Open();

                MySqlCommand retorno_comando = new MySqlCommand(sql, cnn);
                MySqlDataReader reader = retorno_comando.ExecuteReader();
                listView1.Items.Clear();

                while (reader.Read())
                {
                    if (reader.GetString(2) == "0")
                    {
                        string[] row = {
                                       reader.GetString(2),
                                       reader.GetString(3)
                                         };
                        var listViewItem = new ListViewItem(row);


                        listView1.Items.Add(listViewItem);
                    }
                    else
                    {

                        string[] row = {
                                       reader.GetString(2),
                                       reader.GetString(3)
                                         };
                        var listViewItem = new ListViewItem(row);

                        listViewItem.ForeColor = greenText;

                        listView1.Items.Add(listViewItem);
                    };
                }
                cnn.Close();
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar no banco de dados", alertas.enmTipo.erro);
            }
            catch (Exception ex)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: " + ex.GetType().ToString(), alertas.enmTipo.erro);
                alerta.Show();
            }

            // ////////////////////////////////////
            pnlEventos.BackColor = FORMS.main.instance.formColor;
            pnlAlarmes.BackColor = FORMS.main.instance.formColor;
            pnlFinancas.BackColor = FORMS.main.instance.formColor;
            pnlProgresso.BackColor = FORMS.main.instance.formColor;
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy dddd");
        }

        public Color greenText { get; set; }
    }
}
