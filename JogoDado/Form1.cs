using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDado
{
    public partial class frmJogoDado : Form
    {
        private int j1;
        private int j2;

        public frmJogoDado()
        {
            InitializeComponent();
        }

        private void btnJogador1_Click(object sender, EventArgs e)
        {
            String jogada = btnJogador1.Tag.ToString();
            Random rnd = new Random();
            int valor = rnd.Next(1, 7);
            selecionaDado(valor);
            switch (jogada)
            {
                case "1":
                    txtbLance1Jogador1.Text = valor.ToString();
                    btnJogador1.Tag = "2";
                    btnJogador1.Enabled = false;
                    btnJogador2.Enabled = true;
                    break;
                case "2":
                    txtbLance2Jogador1.Text = valor.ToString();
                    btnJogador1.Tag = "3";
                    btnJogador1.Enabled = false;
                    btnJogador2.Enabled = true;
                    break;
                case "3":
                    txtbLance3Jogador1.Text = valor.ToString();
                    btnJogador1.Enabled = false;
                    btnJogador2.Enabled = true;
                    break;
            }
            
        }

        private void btnJogador2_Click(object sender, EventArgs e)
        {
            String jogada = btnJogador2.Tag.ToString();
            Random rnd = new Random();
            int valor = rnd.Next(1, 7);
            selecionaDado(valor);
            switch (jogada)
            {
                case "1":
                    txtbLance1Jogador2.Text = valor.ToString();
                    btnJogador2.Tag = "2";
                    btnJogador2.Enabled = false;
                    btnJogador1.Enabled = true;
                    break;
                case "2":
                    txtbLance2Jogador2.Text = valor.ToString();
                    btnJogador2.Tag = "3";
                    btnJogador2.Enabled = false;
                    btnJogador1.Enabled = true;
                    verificaGanhador(jogada);
                    break;
                case "3":
                    txtbLance3Jogador2.Text = valor.ToString();
                    btnJogador2.Enabled = false;
                    verificaGanhador(jogada);
                    break;
            }
        }

        private void verificaGanhador(string jogada)
        {
            switch (jogada)
            {
                case "2":
                    if (Int32.Parse(txtbLance1Jogador1.Text) > Int32.Parse(txtbLance1Jogador2.Text))
                    {
                        j1 += 1;
                    }
                    else if (Int32.Parse(txtbLance1Jogador1.Text) < Int32.Parse(txtbLance1Jogador2.Text))
                    {
                        j2 += 1;
                    }

                    if (Int32.Parse(txtbLance2Jogador1.Text) > Int32.Parse(txtbLance2Jogador2.Text))
                    {
                        j1 += 1;
                    }
                    else if (Int32.Parse(txtbLance2Jogador1.Text) < Int32.Parse(txtbLance2Jogador2.Text))
                    {
                        j2 += 1;
                    }

                    if (j1 > j2 && j1 > 1)
                    {
                        MessageBox.Show("Jogador 1 é o vencedor!");
                        Application.Exit();
                    }
                    else if (j2 > j1 && j2 > 1)
                    {
                        MessageBox.Show("Jogador 2 é o vencedor!");
                        Application.Exit();
                    }
                    break;

                case "3":
                    if (Int32.Parse(txtbLance3Jogador1.Text) > Int32.Parse(txtbLance3Jogador2.Text))
                    {
                        j1 += 1;
                    }
                    else if (Int32.Parse(txtbLance3Jogador1.Text) < Int32.Parse(txtbLance3Jogador2.Text))
                    {
                        j2 += 1;
                    }


                    if (j1 > j2)
                    {
                        MessageBox.Show("Jogador 1 é o vencedor!");
                        Application.Exit();
                    }
                    else if (j2 > j1)
                    {
                        MessageBox.Show("Jogador 2 é o vencedor!");
                        Application.Exit();
                    }
                    else if (j2 == j1)
                    {
                        MessageBox.Show("Empate!");
                        Application.Exit();
                    }
                    break;
            }
        }

        private void selecionaDado(int valor)
        {
            switch (valor)
            {
                case 1:
                    imgDado.Image = JogoDado.Properties.Resources._1;
                    break;
                case 2:
                    imgDado.Image = JogoDado.Properties.Resources._2;
                    break;
                case 3:
                    imgDado.Image = JogoDado.Properties.Resources._3;
                    break;
                case 4:
                    imgDado.Image = JogoDado.Properties.Resources._4;
                    break;
                case 5:
                    imgDado.Image = JogoDado.Properties.Resources._5;
                    break;
                case 6:
                    imgDado.Image = JogoDado.Properties.Resources._6;
                    break;
            }
        }
    }
}
