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
        public delegate void ElevatorDelegate(object sender, EventArgs e);
        public event ElevatorDelegate ElevatorEvent;

        public int andarAtual;
        public int proximoAndar;

        public void OnElevator()
        {
            if (andarAtual != proximoAndar)
            {
                if (ElevatorEvent != null) 
                {
                        ElevatorEvent(this, EventArgs.Empty);
                }
            }
            Thread.Sleep(5000);   
            
        }
    
    }
    
    }

