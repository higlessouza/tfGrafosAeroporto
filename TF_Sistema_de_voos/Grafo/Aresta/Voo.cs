using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
   public class Voo : Aresta
    {
       public Aeroporto origem, destino;
        public Horario partida;

        public Voo(Aeroporto origem, Aeroporto destino, Horario partida)
        {
            this.origem = origem;
            this.destino = destino;
            this.partida = partida;
        }
    }
}
