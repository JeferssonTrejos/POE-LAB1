using System;
using System.Windows.Forms;
using FigurasGeometricas;

namespace areaYperimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (double.TryParse(ValorTextBox.Text, out valor))
            {
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    cuadroResultado.Text = $"�rea: {cuadrado.CalcularArea()}";
                }
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    cuadroResultado.Text = $"�rea: {circunferencia.CalcularArea()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor v�lido.");
            }
        }

        private void PerimetroButton_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (double.TryParse(ValorTextBox.Text, out valor))
            {
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    perimetroResultado.Text = $"Per�metro: {cuadrado.CalcularPerimetro()}";
                }
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    perimetroResultado.Text = $"Per�metro: {circunferencia.CalcularPerimetro()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor v�lido.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
