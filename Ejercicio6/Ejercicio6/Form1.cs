namespace Ejercicio6
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateAcceleration_Click(object sender, EventArgs e)
        {
            try
            {
                double speed = Convert.ToDouble(VelocityTextBox.Text.ToString());
                double time = Convert.ToDouble(timeTextBox.Text.ToString());

                Aceleration aceleration = new Aceleration(speed, time);

                double result = Math.Round(aceleration.calculate(), 2);
                resultLabel.Text = $"{result}m/s²";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Aceleration
    {
        public double Speed { get; set; }
        public double Time { get; set; }

        public Aceleration(double speed, double time)
        {
            Speed = speed;
            Time = time;
        }

        public double calculate()
        {
            return Speed / Time;
        }
    }
}
