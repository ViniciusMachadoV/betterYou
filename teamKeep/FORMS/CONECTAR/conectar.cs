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
    public partial class conectar : Form
    {
        public static conectar instance;
        public Label tituloForm;
        public conectar()
        {
            InitializeComponent();
            instance = this;
            tituloForm = lblTipoConexao;

            pnlSelecionadoConectar.BackColor = FORMS.main.instance.textColors;
            this.pnlTipoConexao.Controls.Clear();
            entrar entrar_Vrb = new entrar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            entrar_Vrb.FormBorderStyle = FormBorderStyle.None;
            entrar_Vrb.BackColor = FORMS.main.instance.lighterForm;
            this.pnlTipoConexao.Controls.Add(entrar_Vrb);
            entrar_Vrb.Show();
        }

        private void btnPanelEntrar_Click(object sender, EventArgs e)
        {

            pnlSelecionadoConectar.Location = new Point(0 , 28);
            lblTipoConexao.Text = "Insira seus dados de conexão:";
            this.pnlTipoConexao.Controls.Clear();
            entrar entrar_Vrb = new entrar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            entrar_Vrb.FormBorderStyle = FormBorderStyle.None;
            entrar_Vrb.BackColor = FORMS.main.instance.lighterForm;
            this.pnlTipoConexao.Controls.Add(entrar_Vrb);
            entrar_Vrb.Show();
        }

        private void btnPanelCadastrar_Click(object sender, EventArgs e)
        {
            pnlSelecionadoConectar.Location = new Point(200, 28);
            lblTipoConexao.Text = "Insira seus dados de cadastro:";
            this.pnlTipoConexao.Controls.Clear();
            cadastrar cadastrar_Vrb = new cadastrar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            cadastrar_Vrb.FormBorderStyle = FormBorderStyle.None;
            cadastrar_Vrb.BackColor = FORMS.main.instance.lighterForm;
            this.pnlTipoConexao.Controls.Add(cadastrar_Vrb);
            cadastrar_Vrb.Show();
        }
    }
}
