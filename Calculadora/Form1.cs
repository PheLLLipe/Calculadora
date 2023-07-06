namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int primNum, segNum, resultado;
            primNum = Int32.Parse(primeiroNumero.Text);
            segNum = Int32.Parse(segundoNumero.Text);

            resultado = primNum + segNum;

            resultadoText.Text = resultado.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void primeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}