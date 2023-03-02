using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamKeep.FORMS.RELÓGIO
{
    public partial class cronometro : Form
    {
        public cronometro()
        {
            InitializeComponent();
            inputTempo.BackColor = FORMS.main.instance.formColor;
        }

        int tempoo = 0;
        int minuto = 0;
        int segundo = 0;

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            if (segundo < 10)
            {
                txt_tempo.Text = "0" + minuto + ":" + "0" + segundo;
                timerCronometro.Enabled = true;
            }
            else
            {
                txt_tempo.Text = "0" + minuto + ":" + segundo;
                timerCronometro.Enabled = true;
            }
            if (minuto == 0 && segundo == 0)
            {
                timerCronometro.Enabled = false;
                alertas alerta = new alertas();
                alertas.instance.tipoAlerta("O temporizador terminou!", alertas.enmTipo.aviso);
            }
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            if (inputTempo.Text != "")
            {
                try
                {
                    tempoo = Convert.ToInt16(inputTempo.Text);
                    if (tempoo >= 60)
                    {
                        minuto = tempoo / 60;
                        segundo = tempoo % 60;

                    }
                    else
                    {
                        minuto = 0;
                        segundo = tempoo;
                    }
                    if (segundo < 10)
                    {
                        txt_tempo.Text = "0" + minuto + ":" + "0" + segundo;
                        timerCronometro.Enabled = true;

                    }
                    else
                    {
                        txt_tempo.Text = "0" + minuto + ":" + segundo;
                        timerCronometro.Enabled = true;
                    }
                }
                catch
                {
                    inputTempo.Text = "";
                    lblCronometro.Visible = true;

                }
            }
            else lblCronometro.Visible = true;
        }

        private void inputTempo_Enter(object sender, EventArgs e)
        {
            lblCronometro.Visible = false;

        }


    }
}
