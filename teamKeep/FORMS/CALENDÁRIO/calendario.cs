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
    public partial class calendario : Form
    {
        public static calendario instance;
        public Panel tabelaLembretes;
        public calendario()
        {
            InitializeComponent();
            instance = this;
            tabelaLembretes = pnlCalendario;


            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=teamkeep;");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM calendario", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow[] rows = dt.Select();
            try
            {
                if (rows.Length != 0)
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        FORMS.CALENDÁRIO.comp compromisso = new FORMS.CALENDÁRIO.comp()
                        {
                            TopLevel = false,
                            TopMost = true,
                            Visible = true
                        };
                        compromisso.lblIdLembrete.Text = rows[i][0].ToString();
                        compromisso.Titulo_comp.Text = rows[i][2].ToString();
                        compromisso.desc_comp.Text = rows[i][3].ToString();
                        compromisso.FormBorderStyle = FormBorderStyle.None;
                        tblLembretes.Controls.Add(compromisso);
                    }
                }
                else lblSemLembretes.Visible = true;
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSemLembretes.Visible = false;
            var data = ((MonthCalendar)sender).SelectionStart.ToShortDateString();
            this.pnlCalendario.Controls.Clear();
            FORMS.CALENDÁRIO.agenda agenda_vrb = new FORMS.CALENDÁRIO.agenda()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
             agenda_vrb.FormBorderStyle = FormBorderStyle.None;
             agenda_vrb.BackColor = FORMS.main.instance.lighterForm;
             this.pnlCalendario.Controls.Add(agenda_vrb);
             agenda_vrb.txt_data.Text = data;
             agenda_vrb.Show();
        }
    } 
}
