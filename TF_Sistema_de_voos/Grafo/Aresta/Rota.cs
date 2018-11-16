using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    class Rota:Aresta
    {
        public Aeroporto aeroporto1, aeroporto2;
        /// <summary>
        /// construtor da rota
        /// </summary>
        /// <param name="aeroporto1"></param>
        /// <param name="aeroporto2"></param>
        /// <param name="duracao"></param>
        /// <param name="distancia">distancia em KM</param>
        /// 
        public Rota(Aeroporto aeroporto1,Aeroporto aeroporto2, Horario duracao,int distancia)
        {
            this.aeroporto1 = aeroporto1;
            this.aeroporto2 = aeroporto2;
            this.duracao = duracao;
            this.distancia = distancia;
        }

        public override Aeroporto RetornarAeroporto1()
        {
            return aeroporto1;
        }

        public override Aeroporto RetornarAeroporto2()
        {
            return aeroporto2;
        }
    }
}
