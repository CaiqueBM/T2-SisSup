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
        private Simulador simulador;
        private int auxAndar;
        private int auxProxAndar;
        public int i = 0;
        public int tarefa = 0;
        public bool simulacao = false;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        List<int> lista = new List<int>();
        
        public Form1()
        {
            InitializeComponent();

            elevador = new Elevator();
            elevador.ElevatorEvent += MudarAndar;

            simulador = new Simulador();
            simulador.EventSim += MudarAndar;


            log.Info("Sistema Iniciado");
            br4.Visible = false;

            subindo.Visible = false;
            descendo.Visible = false;
        }

        private void adicionarItem(int item)
        {

            if (elevador.andarAtual != item)
            {
                lista.Add(item);
            }

           
       
            int[] arrayLista = lista.ToArray();

            if (lista.Count == 1)
            {
                elevador.proximoAndar = arrayLista[0];
                elevador.OnElevator();
            }

            int cont = lista.Count;
            
        }

        private void removeItem()
        {
            
            lista.RemoveAt(0);

            int[] arrayLista = lista.ToArray();

            int cont = lista.Count;

            

            
        }

        private void sequenciaLista()
        {
            int[] arrayLista = lista.ToArray();
            elevador.proximoAndar = arrayLista[0];

            string item = "Proximo Andar: " + (arrayLista[0].ToString());

            log.Info(item);
            //log.Info((arrayLista[0]).ToString());

            


            elevador.OnElevator();
        }

        public async void MudarAndar(object sender, EventArgs e)
        {
            int[] arrayLista = lista.ToArray();
            auxProxAndar = arrayLista[0];
            auxAndar = elevador.andarAtual;

            if (auxAndar != auxProxAndar)
            {
                if (auxAndar < auxProxAndar)
                {
                    subindo.Visible = true;
                    descendo.Visible = false;
                    for (i = auxAndar; i <= auxProxAndar; i++)
                    {
                        if(i == 0)
                        {
                            label3.Text = "T";
                        } else
                        {
                            label3.Text = (i).ToString();
                        }
                       

                     
                        
                        await Transicao();
                    }
                    elevador.andarAtual = elevador.proximoAndar;
                  
                    await Transicao();
                }
                else if (auxAndar > auxProxAndar)
                {
                    subindo.Visible = false;
                    descendo.Visible = true;
                    for (i = auxAndar; i >= auxProxAndar; i--)
                    {
                      
                        
                        
                        await Transicao();
                    }
                    elevador.andarAtual = elevador.proximoAndar;
                   
                    await Transicao();
                }

            }

            log.Info("Evento concluido!");

            if (simulacao == true)
            {
                adicionarItem(simulador.simRand());
                await Transicao();
                await Transicao();
            }

            
            removeItem();
            int cont = lista.Count;
            if (cont > 0)
            {
                sequenciaLista();
            }

        }

        async Task Transicao()
        {
            await Task.Delay(2000);
        }
        
        //Controle de Botões Painel Interno

        private void terreo_Click(object sender, EventArgs e)
        {
            
            if (simulacao == false) {
                adicionarItem(0);
            }
        }

        private void andar1_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(1);
            }
        }

        private void andar2_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(2);
            }
        }

        private void andar3_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(3);
            }
        }

        private void andar4_Click(object sender, EventArgs e)
        {
            br4.Visible = true;
            andar4.Visible = false;
            if (simulacao == false)
            {
                adicionarItem(4);
            }
        }


        //Controle de Botões Painel Externo

        private void Subir_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(0);
            }
        }

        private void SD1_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(1);
            }
        }

        private void SD2_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(2);
            }
        }

        private void SD3_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(3);
            }
        }

        private void Descer_Click(object sender, EventArgs e)
        {
            if (simulacao == false)
            {
                adicionarItem(4);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            simulacao = true;
            adicionarItem(simulador.simRand());
        }
    }
}