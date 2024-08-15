namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                textLabel.Text = "Cuidado! No se permite presionar la Barra Espaciadora";
                e.Handled = true;
            }
            else
            {
                textLabel.Text = "";
            }
        }
    }
}
