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

        public void doElevator()
        {
            if (ElevatorEvent != null)
            {
                ElevatorEvent(this, EventArgs.Empty);
            }
            Thread.Sleep(3000);
        }
    }
}
