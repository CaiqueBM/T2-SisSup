using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Lista
    {

        int auxValor;
        int auxAnterior;

        public void OrganizarLista(int valor)
        {
            List<int> organizar = new List<int>();
            if (auxValor != valor)
            {
                organizar.Add(valor);
            }

            if (organizar.Contains(auxAnterior))
            {
                organizar.Remove(auxAnterior);
            }

            
            auxAnterior = auxValor;
            auxValor = valor;


           
        }
    }
}
