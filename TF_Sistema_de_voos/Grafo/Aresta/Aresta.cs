using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    public abstract class Aresta
    {
        public int distancia, nParagens;
       public Horario duracao;
        public abstract Aeroporto RetornarAeroporto1();
        public abstract Aeroporto RetornarAeroporto2();

    }
}
