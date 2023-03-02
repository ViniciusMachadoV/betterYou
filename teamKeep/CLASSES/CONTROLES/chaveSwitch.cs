using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace teamKeep.CLASSES.CONTROLES
{
    public class chaveSwitch : CheckBox
    {
        private Color fundoSwitchLigado = Color.MediumSlateBlue;
        private Color botaoSwitchLigado = Color.WhiteSmoke;
        private Color fundoSwitchDesligado = Color.Gray;
        private Color botaoSwitchDesligado = Color.Gainsboro;
        private bool estiloSolido = true;

        public Color FundoSwitchLigado
        { get { return fundoSwitchLigado; } set { fundoSwitchLigado = value; this.Invalidate(); } }

        public Color BotaoSwitchLigado
        { get { return botaoSwitchLigado; } set { botaoSwitchLigado = value; this.Invalidate(); } }

        public Color FundoSwitchDesligado
        { get { return fundoSwitchDesligado; } set { fundoSwitchDesligado = value; this.Invalidate(); } }

        public Color BotaoSwitchDesligado
        { get { return botaoSwitchDesligado; } set { botaoSwitchDesligado = value; this.Invalidate(); } }

        [DefaultValue(true)]
        public bool EstiloSolido
        { get { return estiloSolido; } set { estiloSolido = value; this.Invalidate(); } }

        public override string Text
        { get { return base.Text; } set { } }

        public chaveSwitch()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //MÉTODOS:
        private GraphicsPath GetFigurePath()
        {
            int tamanhoArco = this.Height - 1;
            Rectangle arcoEsquerdo = new Rectangle(0, 0, tamanhoArco, tamanhoArco);
            Rectangle arcoDireiro = new Rectangle(this.Width - tamanhoArco - 2, 0, tamanhoArco, tamanhoArco);

            GraphicsPath tamanho = new GraphicsPath();
            tamanho.StartFigure();
            tamanho.AddArc(arcoEsquerdo, 90, 180);
            tamanho.AddArc(arcoDireiro, 270, 180);
            tamanho.CloseFigure();

            return tamanho;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int tamanhoSwitch = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //LIGADO
            {
                //DESENHA SUPERFÍCIE:
                if(estiloSolido)
                pevent.Graphics.FillPath(new SolidBrush(fundoSwitchLigado), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(fundoSwitchLigado, 2), GetFigurePath());
                //DESENHA BOTÃO:
                pevent.Graphics.FillEllipse(new SolidBrush(botaoSwitchLigado),
                   new Rectangle(this.Width - this.Height + 1, 2, tamanhoSwitch, tamanhoSwitch));
            }
            else //DESLIGADO
            {
                //DESENHA SUPERFÍCIE:
                if (estiloSolido)
                pevent.Graphics.FillPath(new SolidBrush(fundoSwitchDesligado), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(fundoSwitchDesligado, 2), GetFigurePath());
                //DESENHA BOTÃO:
                pevent.Graphics.FillEllipse(new SolidBrush(botaoSwitchDesligado),
                   new Rectangle(2, 2, tamanhoSwitch, tamanhoSwitch));
            }
        }
    }       
}
