namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double ValorReais, Calculo;

            ValorReais = double.Parse(mstbValor.Text);

            int ConverterMoedas = cbbMoedas.SelectedIndex;

            switch (ConverterMoedas)
            {
                case 0:

                    Calculo = ValorReais * 0.17;
                    txtValorConvertido.Text = "" + Calculo.ToString("N2");
                    pcbDinheiro.Image = Properties.Resources.Euro;
                    break;

                case 1:

                    Calculo = ValorReais * 0.18;
                    txtValorConvertido.Text = "" + Calculo.ToString("N2");
                    pcbDinheiro.Image = Properties.Resources.Dolar;
                    break;

                case 2:

                    Calculo = ValorReais * 1.31;
                    txtValorConvertido.Text = "" + Calculo.ToString("N2");
                    pcbDinheiro.Image = Properties.Resources.MoedaChinesa;
                    break;

                case 3:

                    Calculo = ValorReais * 26.86;
                    txtValorConvertido.Text = "" + Calculo.ToString("N2");
                    pcbDinheiro.Image = Properties.Resources.Yen;
                    break;

                case 4:

                    Calculo = ValorReais * 0.14;
                    txtValorConvertido.Text = "" + Calculo.ToString("N2");
                    pcbDinheiro.Image = Properties.Resources.Libra;
                    break;
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}