using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {

        private Elevator elevador;
        public int auxAndar;
        public int auxProxAndar;

        public Form1()
        {
            InitializeComponent();

            elevador = new Elevator();
            elevador.ElevatorEvent += mudarAndar;

        }

        public void mudarAndar(object sender, EventArgs e)
        {
            auxAndar = elevador.andarAtual;
            auxProxAndar = elevador.proximoAndar;

            if (auxAndar != auxProxAndar)
            {
                if (auxAndar < auxProxAndar)
                {

                    for (int i = auxAndar; i <= auxProxAndar; i++)
                    {
                        Console.WriteLine("Subindo Andar");
                        Task.Delay(2000); //Tempo de transicao entre andares


                    }
                    Console.WriteLine("Porta Fechando");
                    Task.Delay(2000); //Abre a porta

                }
                else if (auxAndar > auxProxAndar)
                {
                    for (int i = auxAndar;i <= auxProxAndar; i--)
                    {
                        Task.Delay(2000); //Tempo de transicao entre andares
                        Console.WriteLine("Descendo Andar");
                    }
                    Console.WriteLine("Porta Fechando");
                    Task.Delay(2000); //Abre a porta
                }
            }

            //Controle de Botões



        }

        private void button1_Click(object sender, EventArgs e)
        {
            elevador.proximoAndar = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elevador.proximoAndar = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            elevador.proximoAndar = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            elevador.proximoAndar = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elevador.proximoAndar = 4;
        }
    }
}

    
