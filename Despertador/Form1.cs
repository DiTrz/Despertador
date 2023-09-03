using System;
using System.Windows.Forms;

namespace DespertadorApp
{
    // Interface
    public partial class Form1 : Form
    {
        private Despertador despertador;
        private Horario horarioAtual;

        public Form1()
        {
            InitializeComponent();
        }

        private void criarDespertadorButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(horaDespTextBox.Text, out int hora) &&
                int.TryParse(minutoDespTextBox.Text, out int minuto) &&
                int.TryParse(segundoDespTextBox.Text, out int segundo))
            {
                string descricao = descricaoTextBox.Text;
                despertador = new Despertador(hora, minuto, segundo, descricao);
                despertadorLabel.Text = "Despertador: " + despertador.Print();
            }
            else
            {
                MessageBox.Show("Valores de hora, minuto ou segundo inválidos.");
            }
        }

        private void criarHorarioButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(horaTextBox.Text, out int hora) &&
                int.TryParse(minutoTextBox.Text, out int minuto) &&
                int.TryParse(segundoTextBox.Text, out int segundo))
            {
                horarioAtual = new Horario(hora, minuto, segundo);
                horarioLabel.Text = "Horário Atual: " + horarioAtual.Print();
            }
            else
            {
                MessageBox.Show("Valores de hora, minuto ou segundo inválidos.");
            }
        }


        private void verificarButton_Click(object sender, EventArgs e)
        {
            if (despertador == null || horarioAtual == null)
            {
                MessageBox.Show("Crie o despertador e o horário atual primeiro.");
                return;
            }

            int comparacao = horarioAtual.CompareTo(despertador);

            if (comparacao < 0)
            {
                MessageBox.Show("Ainda não está na hora!");
            }
            else if (comparacao == 0)
            {
                MessageBox.Show("Está na hora!");
            }
            else
            {
                MessageBox.Show("Você está atrasado!");
            }
        }


    }
    // Classe base Horario
    public class Horario
    {
        private int hora;
        private int minuto;
        private int segundo;

        // Construtor com todos os atributos
        public Horario(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        // Construtor com hora e minuto
        public Horario(int hora, int minuto)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = 0;
        }

        public Horario()
        {
            this.hora = 0;
            this.minuto = 0;
            this.segundo = 0;
        }

        // Método para converter o horário em segundos
        public int emSegundos()
        {
            return hora * 3600 + minuto * 60 + segundo;
        }

        // Método para imprimir o horário no formato hh:mm:ss
        public string Print()
        {
            return $"{hora:D2}:{minuto:D2}:{segundo:D2}";
        }

        public int CompareTo(Horario other)
        {
            if (this.hora < other.hora)
                return -1;
            else if (this.hora > other.hora)
                return 1;
            else if (this.minuto < other.minuto)
                return -1;
            else if (this.minuto > other.minuto)
                return 1;
            else if (this.segundo < other.segundo)
                return -1;
            else if (this.segundo > other.segundo)
                return 1;
            else
                return 0;
        }
    }

    // Classe Despertador que herda de Horario
    class Despertador : Horario
    {
        private string descricao;

        // Construtor com todos os atributos
        public Despertador(int hora, int minuto, int segundo, string descricao) : base(hora, minuto, segundo)
        {
            this.descricao = descricao;
        }

        // Construtor com hora, minuto e descrição
        public Despertador(int hora, int minuto, string descricao) : base(hora, minuto)
        {
            this.descricao = descricao;
        }

        // Construtor vazio
        public Despertador() : base()
        {
            this.descricao = "";
        }

        
    }

    
}
