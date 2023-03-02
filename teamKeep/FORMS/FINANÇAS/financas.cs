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

namespace teamKeep.FORMS.FINANÇAS
{
    public partial class financas : Form
    {
        public static financas instance;
        decimal entradas, saidas, total;
        public financas()
        {
            InitializeComponent();
            instance = this;

            // CAIXAS DE TEXTO
            txtNotaEntrada.BackColor = main.instance.formColor;
            txtNotaEntrada.ForeColor = Color.White;
            txtEntrada.BackColor = main.instance.formColor;
            txtEntrada.ForeColor = Color.White;

            txtNotaSaida.BackColor = main.instance.formColor;
            txtNotaSaida.ForeColor = Color.White;
            txtSaida.BackColor = main.instance.formColor;
            txtSaida.ForeColor = Color.White;

            //EXIBE DETALHES
            listView1.View = View.Details;

            //PERMITE AO USUARIO EDITAR O TEXTO
            listView1.LabelEdit = false;

            //REALOCAR COLUNAS
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = false;

            //ESTILIZAR
            listView1.BackColor = main.instance.formColor;
            listView1.ForeColor = Color.White;

            //anexa subitems no listView1
            listView1.Columns.Add("TIPO", 90, HorizontalAlignment.Center);
            listView1.Columns.Add("DESCRICAO", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("VALOR", 90, HorizontalAlignment.Center);
            listView1.Columns.Add("DATA", 140, HorizontalAlignment.Center);
            try
            {
                string string_cnn = "datasource=localhost;port=3306;username=root;password=;database=teamkeep";
                string sql = "SELECT * FROM financas";
                MySqlConnection cnn = new MySqlConnection(string_cnn);
                cnn.Open();

                MySqlCommand retorno_comando = new MySqlCommand(sql, cnn);
                MySqlDataReader reader = retorno_comando.ExecuteReader();
                listView1.Items.Clear();

                while (reader.Read())
                {
                      if (reader.GetString(2) == "0"){
                          string[] row = {
                                        "GASTO",
                                       reader.GetString(5),
                                       "R$"+ reader.GetString(4),
                                       reader.GetString(6)
                                         };
                          var listViewItem = new ListViewItem(row);


                          listView1.Items.Add(listViewItem);
                      }
                      else{

                          string[] row = {
                                        "GANHO",
                                       reader.GetString(3),
                                       "R$"+ reader.GetString(2),
                                       reader.GetString(6)
                                         };
                          var listViewItem = new ListViewItem(row);

                          listViewItem.ForeColor = main.instance.greenText;

                          listView1.Items.Add(listViewItem);
                      };
                }
            cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    
            pnlRelatorio.BackColor = main.instance.formColor;
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
                     lblValorGanhos.Text = "R$" + leitorComando.GetString(0);

                     MySqlConnection conexao2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                     conexao2.Open();
                     MySqlCommand comando2 = new MySqlCommand("SELECT SUM(saida) FROM financas", conexao2);
                     comando2.CommandType = CommandType.Text;
                     MySqlDataReader leitorComando2;
                     leitorComando2 = comando2.ExecuteReader();
                     leitorComando2.Read();
                     saidas = leitorComando2.GetDecimal(0);
                     lblValorGastos.Text = "R$" + leitorComando2.GetString(0);
                     total = entradas - saidas;
                     conexao.Close();
                     conexao2.Close();

                     lblValorSaldo.Text = "R$" + total.ToString();
                 }
             }
             catch(Exception erro)
             {
                 MessageBox.Show("ERRO" + erro);
             }

        }
        private void btnTransacao_Click(object sender, EventArgs e)
        {
            if (txtEntrada.Text != "")
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    conexao.Open();
                    MySqlDataAdapter comando = new MySqlDataAdapter("INSERT INTO financas (entrada, nota_entrada) VALUES ('" + decimal.Parse(txtEntrada.Text) + "','" + txtNotaEntrada.Text + "')", conexao);
                    DataTable dados = new DataTable(); //cria uma tabela, com os valores inseridos
                    comando.Fill(dados);
                    txtEntrada.Text = "";
                    txtNotaEntrada.Text = "";
                    conexao.Close();
                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Ganho registrado", alertas.enmTipo.financa);
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
            if (txtSaida.Text != "")
            {
                try
                {
                    MySqlConnection conexao2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                    conexao2.Open();
                    MySqlDataAdapter comando2 = new MySqlDataAdapter("INSERT INTO financas (saida, nota_saida) VALUES ('" + decimal.Parse(txtSaida.Text) + "','" + txtNotaSaida.Text + "')", conexao2);
                    DataTable dados = new DataTable(); //cria uma tabela, com os valores inseridos
                    comando2.Fill(dados);
                    txtSaida.Text = "";
                    txtNotaSaida.Text = "";
                    conexao2.Close();
                    alertas alerta = new alertas();
                    alertas.instance.tipoAlerta("Gasto registrado", alertas.enmTipo.financa);
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
             try
             {
                 MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                 conexao.Open();
                 MySqlCommand comando = new MySqlCommand("SELECT SUM(entrada) FROM financas", conexao);
                 comando.CommandType = CommandType.Text;
                 MySqlDataReader leitorComando;
                 leitorComando = comando.ExecuteReader();
                 leitorComando.Read();
                 entradas = leitorComando.GetDecimal(0);
                 lblValorGanhos.Text = "R$" + leitorComando.GetString(0);

                 MySqlConnection conexao2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
                 conexao2.Open();
                 MySqlCommand comando2 = new MySqlCommand("SELECT SUM(saida) FROM financas", conexao2);
                 comando2.CommandType = CommandType.Text;
                 MySqlDataReader leitorComando2;
                 leitorComando2 = comando2.ExecuteReader();
                 leitorComando2.Read();

                 saidas = leitorComando2.GetDecimal(0);
                 lblValorGastos.Text = "R$" + leitorComando2.GetString(0);
                 total = entradas + (saidas * -1);
                 conexao.Close();
                 conexao2.Close();

                 lblValorSaldo.Text = "R$" + total.ToString();

                 string string_cnn = "datasource=localhost;port=3306;username=root;password=;database=teamkeep";
                 string sql = "SELECT * FROM financas";
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
                                        "GASTO",
                                       reader.GetString(5),
                                       "R$"+ reader.GetString(4),
                                       reader.GetString(6)
                                         };
                         var listViewItem = new ListViewItem(row);


                         listView1.Items.Add(listViewItem);
                     }
                     else
                     {

                         string[] row = {
                                        "GANHO",
                                       reader.GetString(3),
                                       "R$"+ reader.GetString(2),
                                       reader.GetString(6)
                                         };
                         var listViewItem = new ListViewItem(row);

                         listViewItem.ForeColor = main.instance.greenText;

                         listView1.Items.Add(listViewItem);
                     };
                 }
                 cnn.Close();
             }
             catch (Exception erro)
             {
                 MessageBox.Show("ERRO" + erro);
             }
        }
    }
}
