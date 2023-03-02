using teamKeep.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamKeep
{
    public partial class alertas : Form
    {
        public static alertas instance;

        public Label lblAlerta;

        private int x, y;
        string fname;

        private alertas.enmAcao acao;
        public enum enmAcao
        {
            esperar,
            iniciar,
            fechar
        }

        public enum enmTipo
        {
            alarme,
            info,
            aviso,
            erro,
            sucesso,
            financa,
            conexao
        }

        public alertas()
        {
            InitializeComponent();
            btnFecharAlerta.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            instance = this;
            lblAlerta = lblMensagem;
            
        }
        public void tipoAlerta(string msg, enmTipo tipo)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                alertas frm = (alertas)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 25;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 20 * i;
                    this.Location = new Point(this.x -40, this.y -20);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 5;
            
            switch (tipo)
            {
                case enmTipo.alarme:
                    this.BackColor = FORMS.main.instance.navColor;
                    lblMensagem.ForeColor = FORMS.main.instance.textColors;
                    break;
                case enmTipo.info:
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmTipo.aviso:
                    this.BackColor = Color.DarkOrange;
                    break;
                case enmTipo.erro:
                    this.BackColor = Color.DarkRed;
                    break;
                case enmTipo.sucesso:
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmTipo.financa:
                    this.BackColor = Color.Purple;
                    break;
                case enmTipo.conexao:
                    this.BackColor = Color.Violet;
                    break;
            }
            this.lblMensagem.Text = msg;

            this.Show();
            if (tipo != enmTipo.alarme)
            {
                this.acao = enmAcao.iniciar;
                this.timerAlerta.Interval = 1;
                timerAlerta.Start();
            }
        }

        private void timerAlerta_Tick(object sender, EventArgs e)
        {
            switch (this.acao)
            {
                case enmAcao.esperar:
                    timerAlerta.Interval = 5000;
                    acao = enmAcao.fechar;
                    break;

                case enmAcao.iniciar:
                    timerAlerta.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            acao = enmAcao.esperar;
                        }
                    }
                    break;
                case enmAcao.fechar:
                    timerAlerta.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }

                    break;
            }
        }
        private void btnFecharAlerta_Click(object sender, EventArgs e)
        {
            timerAlerta.Interval = 1;
            acao = enmAcao.fechar;
            this.Close();
        }

    }
}
