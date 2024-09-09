using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha_c_sharp_murilo_nata_nogueira
{
    public partial class Form1 : Form
    {
        private bool isPlayer1 = true, fimJogo = false;
        private List<String> tabuleiro = new List<string> { "", "", "",
                                                            "", "", "",
                                                            "", "", ""};
        private String suporte;
        private int contador = 0, pontoX = 0, pontoO = 0, empates = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void campo1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // faz com que os botões sejam manipulados de forma geral
            int buttonIndex = button.TabIndex;

            if (button.Text.Equals("") && fimJogo == false)
            {
                if (isPlayer1) //Caso de jogador (se for o jogador 1, vai ser o X, se não vai ser o O
                {
                    button.Text = "X";
                    figuraAtual.Text = "O";
                    isPlayer1 = false;
                    defineSuporte(1);

                }
                else
                {
                    button.Text = "O";
                    figuraAtual.Text = "X";
                    isPlayer1 = true;
                    defineSuporte(2);
                }
                tabuleiro[buttonIndex] = button.Text;
                contador++;
                logicaJogo();
            }

        }



        private void defineSuporte(int check) //Suporte para poder fazer a lógica de condições de vencimento do jogo
        {

            if (check == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }
        }

        private bool verificaHorizontais()
        {
            for (int i = 0; i < tabuleiro.Count; i += 3)
            {

                if (tabuleiro[i].Equals(suporte) && tabuleiro[i + 1].Equals(suporte) && tabuleiro[i + 2].Equals(suporte))
                {
                    return true;
                }

            }
            return false;
        }
        private bool verificaVerticais()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i].Equals(suporte) && tabuleiro[i + 3].Equals(suporte) && tabuleiro[i + 6].Equals(suporte))
                {
                    return true;
                }
            }
            return false;
        }
        private bool verificaDiagonais()
        {
            if (tabuleiro[0].Equals(tabuleiro[4]) && tabuleiro[0].Equals(tabuleiro[8]) && tabuleiro[0].Equals(suporte)) //Diagonal principal
            {
                return true;
            }

            if (tabuleiro[2].Equals(tabuleiro[4]) && tabuleiro[2].Equals(tabuleiro[6]) && tabuleiro[2].Equals(suporte))
            {
                return true;
            }
            return false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabuleiro.Count; i++)
            {
                tabuleiro[i] = "";
            }
            contador = 0;
            fimJogo = false;
            campo1.Text = String.Empty;
            campo2.Text = String.Empty;
            campo3.Text = String.Empty;
            campo4.Text = String.Empty;
            campo5.Text = String.Empty;
            campo6.Text = String.Empty;
            campo7.Text = String.Empty;
            campo8.Text = String.Empty;
            campo9.Text = String.Empty;
            isPlayer1 = true;
            figuraAtual.Text = "X";

        }

        private void logicaJogo()
        {
            if (verificaHorizontais() || verificaVerticais() || verificaDiagonais())
            {
                if (!isPlayer1)
                {
                    MessageBox.Show("Jogador 1 Ganhou");
                    pontoX++;
                    textPontoX.Text = pontoX.ToString();
                }
                else
                {
                    MessageBox.Show("Jogador 2 ganhou");
                    pontoO++;
                    textPontoO.Text = pontoO.ToString();
                }
                fimJogo = true;
            }
            else if (contador == 9)
            {
                fimJogo = true;
                empates++;
                MessageBox.Show("Empate!");
                textEmpates.Text = empates.ToString();
            }
        }
    }
}


