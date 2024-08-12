namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AnagramChecker_Click(object sender, EventArgs e)
        {
            string firsText = firsTextBox.Text.ToLower();
            string secondText = secondTextBox.Text.ToLower();


            string firsTextOrder = string.Concat(firsText.OrderBy(c => c));
            string secondTextOrder = string.Concat(secondText.OrderBy(c => c));

            if (firsTextOrder == secondTextOrder)
            {
                resultLabel.Text = $"{firsText} \n Y \n{secondText} \n SI son un anagrama";
            }
            else
            {
                resultLabel.Text = $"{firsText} \n Y \n{secondText} \n NO son un anagrama";
            }
        }
    }
}
