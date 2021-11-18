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
        private int auxAndar;
        private int auxProxAndar;
        public int i = 0;
        public int tarefa = 0;
        int cont;
        int auxcont;

        public Form1()
        {
            InitializeComponent();

            elevador = new Elevator();
            elevador.ElevatorEvent += MudarAndar;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxAndar.Text = (elevador.andarAtual).ToString();
        }

        public async void MudarAndar(object sender, EventArgs e)
        {


            auxAndar = elevador.andarAtual;
            auxProxAndar = elevador.proximoAndar;


            if (auxAndar != auxProxAndar)
            {
                if (auxAndar < auxProxAndar)
                {

                    for (i = auxAndar; i <= auxProxAndar; i++)
                    {
                        txtboxAndar.Text = i.ToString();
                        txtboxSituacao.Text = "Cheguei aqui - Subindo";
                        await Transicao();
                    }

                    elevador.andarAtual = elevador.proximoAndar;
                    txtboxAndar.Text = (elevador.andarAtual).ToString();
                    await Transicao();
                    await Finalizar();
                }
                else if (auxAndar > auxProxAndar)
                {
                    for (i = auxAndar; i >= auxProxAndar; i--)
                    {

                        txtboxAndar.Text = i.ToString();
                        txtboxSituacao.Text = "Cheguei aqui - Descendo";
                        await Transicao();
                    }

                    elevador.andarAtual = elevador.proximoAndar;
                    txtboxAndar.Text = (elevador.andarAtual).ToString();
                    await Transicao();
                    await Finalizar()
;
                }
            }


        }

        async Task Transicao()
        {
            await Task.Delay(2000);
        }

        async Task Finalizar()
        {
            cont++;
            await Task.Run(() => Task.Delay(200));
        }

        async void Verificar(int x)
        {

            var finalizar = Finalizar();
            auxcont++;
            if (cont == auxcont)
            {
                if (tarefa == 0)
                {
                    elevador.proximoAndar = x;
                    elevador.doElevator();
                    tarefa++;
                }
                else if (tarefa == 1)
                {
                    await finalizar;
                    elevador.proximoAndar = x;
                    elevador.doElevator();
                    tarefa++;
                }
                else if (x == 2)
                {
                    await finalizar;
                    elevador.proximoAndar = x;
                    elevador.doElevator();
                    tarefa++;
                }
                else if (x == 3)
                {
                    await finalizar;
                    elevador.proximoAndar = x;
                    elevador.doElevator();
                    tarefa++;
                }
                else if (x == 4)
                {
                    await finalizar;
                    elevador.proximoAndar = x;
                    elevador.doElevator();
                    tarefa = 0;
                }

            }


        }

        //Controle de Botões

        private void terreo_Click(object sender, EventArgs e)
        {
            int aux = 0; //Andar Terreo
            Verificar(aux);
        }

        private void andar1_Click(object sender, EventArgs e)
        {
            int aux = 1; //Andar 1
            Verificar(aux);
        }

        private void andar2_Click(object sender, EventArgs e)
        {
            int aux = 2; //Andar 2
            Verificar(aux);
        }

        private void andar3_Click(object sender, EventArgs e)
        {
            int aux = 3; //Andar 3
            Verificar(aux);
        }

        private void andar4_Click(object sender, EventArgs e)
        {
            int aux = 4; //Andar 4
            Verificar(aux);
        }


    }
}