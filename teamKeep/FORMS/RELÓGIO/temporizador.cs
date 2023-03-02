using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teamKeep.FORMS.RELÓGIO
{
    public partial class temporizador : Form
    {
        public temporizador()
        {
            InitializeComponent();
        }

        Stopwatch temporizer = new Stopwatch();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "COMEÇAR" || btnIniciar.Text == "CONTINUAR")
            {
                timerTemporizador.Enabled = true;
                btnZerar.Enabled = true;
                temporizer.Start();
                btnIniciar.Text = "PAUSAR";
            }
            else
            {
                temporizer.Stop();
                btnIniciar.Text = "CONTINUAR";
                btnZerar.Enabled = true;
            }
        }

        private void timerTemporizador_Tick(object sender, EventArgs e)
        {
            lblTemporizador.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", temporizer.Elapsed.Hours, temporizer.Elapsed.Minutes, temporizer.Elapsed.Seconds, temporizer.Elapsed.Milliseconds / 10);
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            btnIniciar.Text = "COMEÇAR";
            timerTemporizador.Enabled = true;
            btnIniciar.Enabled = true;
            lblTemporizador.Text = "00:00:00:00";
            temporizer.Reset();
        }

    }
}
