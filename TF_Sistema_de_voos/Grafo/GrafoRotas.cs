using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    class GrafoRotas:Grafo
    {
        //BH/Curitiba/1:35/980
        public GrafoRotas(string[] rotasTXT)
        {
            string[] dadosRota;
            foreach (string rota in rotasTXT)
            {
                dadosRota = rota.Split('/');
                arestas.Add(new Rota(CriaVertice(dadosRota[0]), CriaVertice(dadosRota[1]), new Horario(dadosRota[2]),int.Parse(dadosRota[3])));
            }
        }
        public Aeroporto CriaVertice(string nome)
        {
            foreach (Rota a in arestas)
            {
                if (a.aeroporto1.nome.Equals(nome) || a.aeroporto2.nome.Equals(nome))
                {
                    if (a.aeroporto1.nome.Equals(nome))
                    {
                        return a.aeroporto1;
                    }
                    else
                    {
                        return a.aeroporto2;
                    }
                }
            }
            Aeroporto verticeRetorno = new Aeroporto(nome);
            vertices.Add(verticeRetorno);
            return verticeRetorno;
        }
    }
}
