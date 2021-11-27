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
        private Lista lista;
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
            lista = new Lista();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxAndar.Text = (elevador.andarAtual).ToString();
        }

        public async void MudarAndar(object sender, EventArgs e)
        {

            auxProxAndar = lista.proxValor;
            auxAndar = elevador.andarAtual;
            



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
                    ;
                }
            }

            lista.organizarLista();
        }

      


       
        async Task Transicao()
        {
            await Task.Delay(2000);
        }

        //Controle de Botões

        private void terreo_Click(object sender, EventArgs e)
        {
            
            
            lista.adicionarItem(1);
            
        }

        private void andar1_Click(object sender, EventArgs e)
        {
            lista.adicionarItem(2);
        }

        private void andar2_Click(object sender, EventArgs e)
        {
            lista.adicionarItem(3);
        }

        private void andar3_Click(object sender, EventArgs e)
        {
            lista.adicionarItem(4);
        }

        private void andar4_Click(object sender, EventArgs e)
        {
            lista.adicionarItem(5);
        }


    }
}