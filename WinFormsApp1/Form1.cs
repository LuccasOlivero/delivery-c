namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string result;

        public void ToastMessage(string result)
        {
            MessageBox.Show(result);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstNumber.Text);
            int second = int.Parse(secondNumber.Text);
            string previusText = "el resultado es: ";

            if (typeOfOperation.Text != "suma" || typeOfOperation.Text != "resta") return;

            if (typeOfOperation.Text == "suma")
            {
                result = previusText + (first + second);
                ToastMessage(result);
                return;
            }; 

            if (typeOfOperation.Text == "resta")
            {
                result = previusText + (first - second);
                ToastMessage(result);
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
