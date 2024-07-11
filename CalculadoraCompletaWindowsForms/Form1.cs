using CalculadoraCompletaWindowsForms.Models;
namespace CalculadoraCompletaWindowsForms
{
    public partial class Calculadora : Form
    {
        private readonly CalculadoraM _calculadora;
        public Calculadora()
        {
            InitializeComponent();
            _calculadora = new CalculadoraM();
        }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao operacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao, Subtracao, Multiplicacao, Divisao
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Insira um valor antes de tentar multiplicar.");
                    return;
                }
                if (decimal.TryParse(txtResultado.Text, out decimal valor))
                {
                    operacaoSelecionada = Operacao.Multiplicacao;
                    Valor = valor;
                    txtResultado.Text = "";
                    lblOperacao.Text = "*";
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico válido.");
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O correu um erro {ex.Message}");
            }  
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Insira um valor antes de tentar dividir.");
                    return;
                }
                if (decimal.TryParse(txtResultado.Text, out decimal valor))
                {
                    operacaoSelecionada = Operacao.Divisao;
                    Valor = valor;
                    txtResultado.Text = "";
                    lblOperacao.Text = "/";
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O correu um erro {ex.Message}");
            }
        }
        

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Insira um valor antes de tentar somar.");
                    return;
                }
                if (decimal.TryParse(txtResultado.Text, out decimal valor))
                {
                    operacaoSelecionada = Operacao.Adicao;
                    Valor = valor;
                    txtResultado.Text = "";
                    lblOperacao.Text = "+";
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O correu um erro {ex.Message}");
            }
        }
        

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Insira um valor antes de tentar subtrair.");
                    return;
                }
                if (decimal.TryParse(txtResultado.Text, out decimal valor))
                {
                    operacaoSelecionada = Operacao.Subtracao;
                    Valor = valor;
                    txtResultado.Text = "";
                    lblOperacao.Text = "-";
                }
                else
                {
                    MessageBox.Show("Insira um valor numérico válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O correu um erro {ex.Message}");
            }
        }
        
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

        }


        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse((txtResultado.Text), out decimal valor))
                {

                    decimal novoValor = valor;
                    switch (operacaoSelecionada)
                    {
                        case Operacao.Adicao:
                            Resultado = _calculadora.Somar(Valor, novoValor);
                            break;
                        case Operacao.Subtracao:
                            Resultado = _calculadora.Subtrair(Valor, novoValor);
                            break;
                        case Operacao.Multiplicacao:
                            Resultado = _calculadora.Multiplicar(Valor, novoValor);
                            break;
                        case Operacao.Divisao:
                            Resultado = _calculadora.Dividir(Valor, novoValor);
                            break;

                        default:
                            return;
                    }
                    txtResultado.Text = Convert.ToString(Resultado);
                    lblOperacao.Text = "=";
                }

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero.");
                txtResultado.Text = "";
            }
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }
    }
}
