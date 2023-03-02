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
    public partial class relogio : Form
    {
        
        public relogio()
        {
            InitializeComponent();
            this.BackColor = main.instance.formColor;
            this.pnlAlarme.Controls.Clear();
            alarme formAlarme = new alarme()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formAlarme.FormBorderStyle = FormBorderStyle.None;
            formAlarme.BackColor = main.instance.lighterForm;
            this.pnlAlarme.Controls.Add(formAlarme);
            formAlarme.Show();

            this.pnlCronometro.Controls.Clear();
            cronometro formCronometro = new cronometro()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formCronometro.FormBorderStyle = FormBorderStyle.None;
            formCronometro.BackColor = main.instance.lighterForm;
            this.pnlCronometro.Controls.Add(formCronometro);
            formCronometro.Show();

            this.pnlTemporizador.Controls.Clear();
            temporizador formTemporizador = new temporizador()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formTemporizador.FormBorderStyle = FormBorderStyle.None;
            formTemporizador.BackColor = main.instance.lighterForm;
            this.pnlTemporizador.Controls.Add(formTemporizador);
            formTemporizador.Show();
        }
    }
}
