using System.Diagnostics.Eventing.Reader;

namespace Jankenpo
{
    public partial class Form1 : Form
    {
        enum Opcoes { Pedra, Papel, Tesoura };
        enum Resultado { Jogador, CPU, Empate }
        Opcoes jogador = new Opcoes();
        Opcoes cpu = new Opcoes();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();

        public Form1()
        {
            InitializeComponent();
        }

        private void botaoPedra_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        void EscolhaJogador()
        {
            switch(jogador)
            {
                case Opcoes.Pedra:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\pedra.png");
                    break;
                case Opcoes.Papel:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\papel.png");
                    break;
                case Opcoes.Tesoura:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\tesoura.png");
                    break;
            }
        }

        void EscolhaCpu()
        {
            int numero = rdm.Next(1, 4);

            if (numero == 1)
            {
                cpu = Opcoes.Pedra;
                imgEscolhaCPU.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\pedra.png");
            }
            else if (numero == 2)
            {
                cpu = Opcoes.Papel;
                imgEscolhaCPU.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\papel.png");
            }
            else if (numero == 3)
            {
                cpu = Opcoes.Tesoura;
                imgEscolhaCPU.BackgroundImage = Image.FromFile("C:\\Users\\dell\\Documents\\imagens do jankenpo\\tesoura.png");
            }
        }

        void VerificarGanhador()
        {
            switch(jogador)
            {
                case Opcoes.Pedra:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.CPU;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.CPU;
                    break;

                case Opcoes.Tesoura:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.CPU;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }

            if(ganhador == Resultado.Jogador)
            {
                grupoPlacar.BackColor = Color.LawnGreen;
                placarJogador.Text = (int.Parse(placarJogador.Text) + 1).ToString();
            }
            else if (ganhador == Resultado.CPU)
            {
                grupoPlacar.BackColor = Color.IndianRed;
                placarCPU.Text = (int.Parse(placarCPU.Text) + 1).ToString();
            }
            else
            {
                grupoPlacar.BackColor = Color.DarkGray;
            }
        }
    }
}
