using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Elevador
{
    class Simulador
    {
        private Form1 form;

        public delegate void ElevatorSimDelegate(object sender, EventArgs e);
        public event ElevatorSimDelegate EventSim;

        public int andarAtual;
        public int proximoAndar;

        public int simRand()
        {
            Random randNum = new Random();
            int teste = randNum.Next(4);
            
            return teste;
        }

        public void OnSimulador()
        {
            proximoAndar = simRand();

            if (andarAtual != proximoAndar)
            {
                if (EventSim != null)
                {
                    EventSim(this, EventArgs.Empty);
                }
            }

            Thread.Sleep(4000);
        }

    }
}
