using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Lista
    {
        public int proxValor;
        List<int> lista = new List<int>();
        public void adicionarItem(int valor)
        {
            lista.Add(valor);
        }
        public void organizarLista()
        {
            lista.RemoveAt(1);
            int[] arrayLista = lista.ToArray();

            arrayLista[0] = arrayLista[1];
            arrayLista[1] = arrayLista[2];
            arrayLista[2] = arrayLista[3];
            arrayLista[3] = arrayLista[4];
            arrayLista[4] = arrayLista[5];
            arrayLista[5] = 0;
            proxValor = arrayLista[0];
        }






        }
    }


