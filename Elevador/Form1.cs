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
        public int animSimulador;

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
            //br4.Visible = false;

            subindo.Visible = false;
            descendo.Visible = false;

            imgandar1b.Visible = false;
            imgandar2b.Visible = false;
            imgandar3b.Visible = false;
            imgandar4b.Visible = false;
            imgandar6b.Visible = false;

            img1andar0b.Visible = false;
            img1andar1b.Visible = false;
            img1andar2b.Visible = false;
            img1andar3b.Visible = false;
            img1andar4b.Visible = false;
        }

        private void adicionarItem(int item)
        {
            if (elevador.andarAtual != item)
            {
                lista.Add(item);
            }
       
            int[] arrayLista = lista.ToArray();

            if (lista.Count == 1 && simulacao == false)
            {
                string textLog = "Proximo Andar: " + (arrayLista[0].ToString());

                log.Info(textLog);

                elevador.proximoAndar = arrayLista[0];
                elevador.OnElevator();
            } else if(lista.Count == 1 && simulacao == true)
            {
                string textLog = "Proximo Andar: " + (arrayLista[0].ToString());

                log.Info(textLog);

                randomSimulador(arrayLista[0]);
                simulador.proximoAndar = arrayLista[0];
                simulador.OnSimulador();
            }
       
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
            
            string item = "Proximo Andar: " + (arrayLista[0].ToString());

            log.Info(item);
            
            if (simulacao == true)
            {
                simulador.proximoAndar = arrayLista[0];
                simulador.OnSimulador();
            } else
            {
                elevador.proximoAndar = arrayLista[0];
                elevador.OnElevator();
            }
        }

        public void randomSimulador(int valor)
        {

            



            //int valor = simulador.simRand();
            //adicionarItem(valor);

            if (valor == 0)
            {
                imgandar1.Visible = false;
                imgandar1b.Visible = true;
            } else if(valor == 1)
            {
                imgandar2.Visible = false;
                imgandar2b.Visible = true;
            } else if (valor == 2)
            {
                imgandar3.Visible = false;
                imgandar3b.Visible = true;
            } else if (valor == 3)
            {
                imgandar4.Visible = false;
                imgandar4b.Visible = true;
            } else if (valor == 4)
            {
                imgandar6.Visible = false;
                imgandar6b.Visible = true;
            }
        }

        public async void MudarAndar(object sender, EventArgs e)
        {
            await Transicao(2);
            int[] arrayLista = lista.ToArray();
            auxProxAndar = arrayLista[0];

            if (simulacao == true)
            {
                randomSimulador(auxProxAndar);
                auxAndar = simulador.andarAtual;
            }
            else
            {
                auxAndar = elevador.andarAtual;
            }

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
                        await Transicao(1);
                    }
                    subindo.Visible = false;
                    
                    
                }
                else if (auxAndar > auxProxAndar)
                {
                    subindo.Visible = false;
                    descendo.Visible = true;
                    for (i = auxAndar; i >= auxProxAndar; i--)
                    {
                        if (i == 0)
                        {
                            label3.Text = "T";
                        }
                        else
                        {
                            label3.Text = (i).ToString();
                        }
                        await Transicao(1);
                    }
                    
                    descendo.Visible = false;
                }
            }

            if (simulacao == false)
            {
                simulador.andarAtual = elevador.proximoAndar;
                elevador.andarAtual = elevador.proximoAndar;
            } else
            {
                simulador.andarAtual = simulador.proximoAndar;
                elevador.andarAtual = simulador.proximoAndar;
            }

            if (auxProxAndar == 0)
            {
                imgandar1.Visible = true;
                imgandar1b.Visible = false;
                img1andar0.Visible = true;
                img1andar0b.Visible = false;
            }
            else if (auxProxAndar == 1)
            {
                imgandar2.Visible = true;
                imgandar2b.Visible = false;
                img1andar1.Visible = true;
                img1andar1b.Visible = false;
            }
            else if (auxProxAndar == 2)
            {
                imgandar3.Visible = true;
                imgandar3b.Visible = false;
                img1andar2.Visible = true;
                img1andar2b.Visible = false;
            }
            else if (auxProxAndar == 3)
            {
                imgandar4.Visible = true;
                imgandar4b.Visible = false;
                img1andar3.Visible = true;
                img1andar3b.Visible = false;
            }
            else if (auxProxAndar == 4)
            {
                imgandar6.Visible = true;
                imgandar6b.Visible = false;
                img1andar4.Visible = true;
                img1andar4b.Visible = false;
            }
            await Transicao(2);

            log.Info("Evento concluido!");

            if (simulacao == true)
            {
                adicionarItem(simulador.simRand());
            }

            await Transicao(2);

            removeItem();

            int cont = lista.Count;
            if (cont > 0)
            {
                sequenciaLista();
            }
        }

        async Task Transicao(int item)
        {
            if (item == 1)
            {
                await Task.Delay(2000);
            }
            else if (item == 2)
            {
                await Task.Delay(4000);
            }

        }

        //Controle de Botões Painel Interno

        private void terreo_Click(object sender, EventArgs e)
        {
            imgandar1.Visible = false;
            imgandar1b.Visible = true;

            if (simulacao == false) {
                adicionarItem(0);
            }
        }

        private void andar1_Click(object sender, EventArgs e)
        {
            imgandar2.Visible = false;
            imgandar2b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(1);
            }
        }

        private void andar2_Click(object sender, EventArgs e)
        {
            imgandar3.Visible = false;
            imgandar3b.Visible = true;
            if (simulacao == false)
            {
                adicionarItem(2);
            }
        }

        private void andar3_Click(object sender, EventArgs e)
        {
            imgandar4.Visible = false;
            imgandar4b.Visible = true;
            if (simulacao == false)
            {
                adicionarItem(3);
            }
        }

        private void andar4_Click(object sender, EventArgs e)
        {
            imgandar6.Visible = false;
            imgandar6b.Visible = true;
            if (simulacao == false)
            {
                adicionarItem(4);
            }
        }

        //Controle de Botões Painel Externo

        private void Subir_Click(object sender, EventArgs e)
        {
            img1andar0.Visible = false;
            img1andar0b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(0);
            }
        }

        private void SD1_Click(object sender, EventArgs e)
        {
            img1andar1.Visible = false;
            img1andar1b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(1);
            }
        }

        private void SD2_Click(object sender, EventArgs e)
        {
            img1andar2.Visible = false;
            img1andar2b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(2);
            }
        }

        private void SD3_Click(object sender, EventArgs e)
        {
            img1andar3.Visible = false;
            img1andar3b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(3);
            }
        }

        private void Descer_Click(object sender, EventArgs e)
        {
            img1andar4.Visible = false;
            img1andar4b.Visible = true;

            if (simulacao == false)
            {
                adicionarItem(4);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                simulacao = true;
                int valor = simulador.simRand();
                adicionarItem(valor);
            } else
            {
                simulacao = false;
            }
        }
    }
}