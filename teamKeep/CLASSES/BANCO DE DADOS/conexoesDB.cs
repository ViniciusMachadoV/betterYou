using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace teamKeep
{
    class conexoesDB
    {
        public static void message()
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }

        public static void criar()
        {
            try
            {
                MySqlConnection conexaoCriacaoBanco = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;");
                MySqlCommand criarDB = new MySqlCommand(
                    "CREATE DATABASE IF NOT EXISTS teamkeep;" +
                    "USE teamkeep;" +
                    "CREATE TABLE IF NOT EXISTS `alarmes` (" +
                      "id_alarme int(4) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                      "id_usuario int(11) NOT NULL," +
                      "hora_alarme varchar(5) NOT NULL," +
                      "dias_alarme varchar(7) NOT NULL," +
                      "nota_alarme varchar(100) DEFAULT NULL);" +

                     "CREATE TABLE IF NOT EXISTS `calendario` (" +
                      "id_lembrete int(4) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                      "`id_usuario` int(11) NOT NULL," +
                      "`dia_lembrete` varchar(12) NOT NULL," +
                      "`nota_lembrete` varchar(100) NOT NULL);" +

                    "CREATE TABLE IF NOT EXISTS financas (" +
                      "id_financa int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                      "id_usuario int(11) NOT NULL," +
                      "entrada decimal(10,0) DEFAULT '0'," +
                      "nota_entrada varchar(100) DEFAULT ''," +
                      "saida decimal(10,0) DEFAULT '0'," +
                      "nota_saida varchar(100) DEFAULT ''," +
                      "data date DEFAULT current_timestamp());" +

                    "CREATE TABLE IF NOT EXISTS notas (" +
                      "id_nota int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                      "id_usuario int(11) NOT NULL," +
                      "titulo varchar(50) NOT NULL," +
                      "descricao varchar(500) NOT NULL," +
                      "data date DEFAULT current_timestamp());" +

                    "CREATE TABLE IF NOT EXISTS `usuarios` (" +
                      "`id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                      "`usuario` varchar(30) NOT NULL," +
                      "`senha` varchar(30) NOT NULL," +
                      "`email` varchar(200) DEFAULT NULL);" +
                    "COMMIT;", conexaoCriacaoBanco);
                conexaoCriacaoBanco.Open();
                criarDB.ExecuteNonQuery();
                conexaoCriacaoBanco.Close();
            }
            catch (MySqlException)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Falha ao conectar com o banco de dados", alertas.enmTipo.erro);
            }
        }
        public static void insert()
        { }
        public static void update()
        { }
        public static void select()
        { }
        public static void delete(string tabela, string coluna, string where)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
            MySqlDataAdapter sda = new MySqlDataAdapter("DELETE FROM "+tabela+" WHERE "+ coluna +" = '" + where + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}
