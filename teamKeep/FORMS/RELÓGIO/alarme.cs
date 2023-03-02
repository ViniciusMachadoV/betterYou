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

namespace teamKeep.FORMS.RELÓGIO
{
    public partial class alarme : Form
    {
        bool tocou = false;
        public alarme()
        {
            InitializeComponent();
            txtHora.BackColor = FORMS.main.instance.formColor;
            txtMinutos.BackColor = FORMS.main.instance.formColor;
            txtNotaAlarme.BackColor = FORMS.main.instance.formColor;
            alarmeSwitch.BotaoSwitchLigado = FORMS.main.instance.textColors;
            alarmeSwitch.FundoSwitchLigado = FORMS.main.instance.navColor;
            timerAlarme.Start();
        }

        private void timerAlarme_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            if (tocou == false && alarmeSwitch.Checked == true && currentTime.Hour == Int32.Parse(txtHora.Text) && currentTime.Minute == Int32.Parse(txtMinutos.Text))
            {
                tocou = true;
                timerAlarme.Stop();
            }
            if (tocou == true && Application.OpenForms.OfType<alertas>().Count() != 1)
            {
                alertas alerta = new alertas();
                if (txtNotaAlarme.Text != "")
                {
                    alertas.instance.tipoAlerta(txtNotaAlarme.Text, alertas.enmTipo.alarme);

                }
                else
                {
                    alertas.instance.tipoAlerta("Alarme de " + txtHora.Text + ":" + txtMinutos.Text + "!", alertas.enmTipo.alarme);
                }
                tocou = false;
                timerAlarme.Start();
            }
        }

        private void btnEditarAlarme_Click(object sender, EventArgs e)
        {
            btnSalvarAlarme.Visible = true;
            btnMaisHora.Visible = true;
            btnMenosHora.Visible = true;
            btnMaisMinuto.Visible = true;
            btnMenosMinuto.Visible = true;
            alarmeSwitch.Visible = false;
            btnEditarAlarme.Visible = false;
            txtHora.Enabled = true;
            txtMinutos.Enabled = true;
        }

        private void btnSalvarAlarme_Click(object sender, EventArgs e)
        {
            btnSalvarAlarme.Visible = false;
            btnMaisHora.Visible = false;
            btnMenosHora.Visible = false;
            btnMaisMinuto.Visible = false;
            btnMenosMinuto.Visible = false;
            alarmeSwitch.Visible = true;
            btnEditarAlarme.Visible = true;
            txtHora.Enabled = false;
            txtMinutos.Enabled = false;


            try
            {
                string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;";
                string sda = "UPDATE alarmes SET hora_alarme = '" + txtHora.Text + ":"+ txtMinutos.Text + "',nota_alarme='" + txtNotaAlarme.Text + "' WHERE id_alarme = 1;";


                MySqlConnection MyConn2 = new MySqlConnection(con);
                MySqlCommand MyCommand2 = new MySqlCommand(sda, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                //alertas alerta = new alertas();
                //alertas.instance.tipoAlerta("Alarme atualizado", alertas.enmTipo.sucesso);

                MyConn2.Close();
                txtNotaAlarme.Text = "";

            }
            catch (Exception erro)
            {
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("Erro: " + erro.GetType().ToString(), alertas.enmTipo.sucesso);
            }

        }

        private void btnMaisHora_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtHora.Text) < 23) txtHora.Text = (Int32.Parse(txtHora.Text) + 1).ToString();
            else txtHora.Text = "00";
        }

        private void btnMenosHora_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtHora.Text) > 0) txtHora.Text = (Int32.Parse(txtHora.Text) - 1).ToString();
            else txtHora.Text = "23";
        }

        private void btnMaisMinuto_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtMinutos.Text) < 59) txtMinutos.Text = (Int32.Parse(txtMinutos.Text) + 1).ToString();
            else txtMinutos.Text = "00";
        }

        private void btnMenosMinuto_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtMinutos.Text) > 0) txtMinutos.Text = (Int32.Parse(txtMinutos.Text) - 1).ToString();
            else txtMinutos.Text = "59";
        }

        private void txtHora_Enter(object sender, EventArgs e)
        {
            txtHora.Text = "";
        }
    }
}
