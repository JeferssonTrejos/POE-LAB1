namespace gradosyradianes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Evento para calcular el coseno en grados cuando se hace clic en el botón "Grados"
        private void GradosButton_MouseClick(object sender, MouseEventArgs e)
        {    // Verifica que el valor sea valido
            if (double.TryParse(ValorTerabox.Text, out double anguloGrados))
            {    // Convierte los grados a radianes para el cálculo del coseno
                double anguloRadianes = anguloGrados * Math.PI / 180;
                double coseno = Math.Cos(anguloRadianes);
                coseno = Math.Round(coseno, 2);
                // Calcula el coseno y lo muestra en el cuadro de resultado con 4 decimales
                ResultadoLabel.Text = $"Coseno en grados: {coseno}";
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }
        // Evento para calcular el coseno en radianes cuando se hace clic en el botón "Radianes"
        private void RadianesButton_MouseClick(object sender, MouseEventArgs e)
        {    // Verifica que el valor ingresado sea valido
            if (double.TryParse(ValorTerabox.Text, out double anguloRadianes))
            {    // Calcula el coseno directamente en radianes
                double coseno = Math.Cos(anguloRadianes);
                coseno = Math.Round(coseno, 2);
                ResultadoLabel.Text = $"Coseno en radianes: {coseno}";
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }

    }
}
