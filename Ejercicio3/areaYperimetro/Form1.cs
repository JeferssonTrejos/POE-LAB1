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
        // Evento para calcular el área
        private void AreaButton_Click(object sender, EventArgs e)
        {
            double valor = 0;
            // Verifica que el valor sea valido
            if (double.TryParse(ValorTextBox.Text, out valor))
            {    // Si se selecciona el cuadrado, calcula su área
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    cuadroResultado.Text = $"Área: {cuadrado.CalcularArea()}";
                }
                // Si se selecciona la circunferencia, calcula su área
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    cuadroResultado.Text = $"Área: {circunferencia.CalcularArea()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }
        // Evento para calcular el perímetro
        private void PerimetroButton_Click(object sender, EventArgs e)
        {
            double valor = 0;
            // Verifica que el valor ingresado sea un número válido
            if (double.TryParse(ValorTextBox.Text, out valor))
            {    // Si se selecciona el cuadrado, calcula su perímetro
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    perimetroResultado.Text = $"Perímetro: {cuadrado.CalcularPerimetro()}";
                }
                // Si se selecciona la circunferencia, calcula su perímetro
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    perimetroResultado.Text = $"Perímetro: {circunferencia.CalcularPerimetro()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
