using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace teamKeep

{
    public partial class progresso : Form
    {
        public progresso()
        {
            InitializeComponent();
            GerarGraficoColunas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarGraficoColunas();
        }
        private void GerarGraficoColunas() 
        {   //Titulo do grafico
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Renda mensal";
            chart1.Titles.Add(title);

            //Sub titulo
            Title title2 = new Title();
            title2.Font = new Font("Arial", 14, FontStyle.Bold);
            title2.ForeColor = Color.DarkBlue;
            title2.Text = "Fechamento do Primeiro Semestre";
            chart1.Titles.Add(title2);

            // insere legendas com base no nome das colunas 
            Legend legend = new Legend();
            chart1.Legends.Add(legend);
            chart1.Legends[0].Title = "Legenda";

            // Titulos eixo X e Y
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ano de 2023";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Valores em R$";
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //Remove grades do grafico
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            // escala do eixo y
            chart1.ChartAreas[0].AxisY.Maximum = 160;
            chart1.ChartAreas[0].AxisY.Interval = 40;




            //rendas reais

            chart1.Series.Add("Valores");
            chart1.Series["Valores"].LegendText = "Renda";
            chart1.Series["Valores"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Valores"].BorderWidth = 1;

            //adiciona valores das barras

            chart1.Series["Valores"].Points.AddXY("Janeiro", 140);
            chart1.Series["Valores"].Points.AddXY("Fevereiro", 110);
            chart1.Series["Valores"].Points.AddXY("Março", 90);
            chart1.Series["Valores"].Points.AddXY("Abril", 115);
            chart1.Series["Valores"].Points.AddXY("Maio", 123);
            chart1.Series["Valores"].Points.AddXY("Junho", 140);

            // barra segundaria para valores associados

            chart1.Series.Add("Previsao");
            chart1.Series["Previsao"].LegendText = "Pevisão de Renda";
            chart1.Series["Previsao"].BorderWidth = 4;



            //adiciona valores das barras

            chart1.Series["Previsao"].Points.AddXY("Janeiro", 130);
            chart1.Series["Previsao"].Points.AddXY("Fevereiro", 150);
            chart1.Series["Previsao"].Points.AddXY("Março", 90);
            chart1.Series["Previsao"].Points.AddXY("Abril", 115);
            chart1.Series["Previsao"].Points.AddXY("Maio", 123);
            chart1.Series["Previsao"].Points.AddXY("Junho", 40);
            



        }

        private void progresso_Load(object sender, EventArgs e)
        {

        }
    }
}
