using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevador
{
    class Elevator
    {
        public delegate void ElevatorDelegate(object sender, EventArgs args);
        public event ElevatorDelegate ElevatorEvent;

        public int andarAtual;
        public int proximoAndar;
        public int v1;
        public int v2;
        public int v3;
        public int v4;
        public int v5;
        

        public void doElevator()
        {
            if (ElevatorEvent != null)
            {
                ElevatorEvent(this, EventArgs.Empty);
            }
        }
    }


}