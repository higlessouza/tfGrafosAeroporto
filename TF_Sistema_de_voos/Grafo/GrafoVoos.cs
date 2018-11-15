using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    public class GrafoVoos : Grafo
    {
        //SP/Manaus/23:20
        public GrafoVoos(string[] voosTXT)
        {
            string[] dadosVoo;
            foreach (string voo in voosTXT)
            {
                dadosVoo = voo.Split('/');
                arestas.Add(new Voo(CriaVertice(dadosVoo[0]), CriaVertice(dadosVoo[1]), new Horario(dadosVoo[2])));
            }
        }
        public Aeroporto CriaVertice(string nome)
        {
            foreach (Voo a in arestas)
            {
                if (a.origem.nome.Equals(nome) || a.destino.nome.Equals(nome))
                {
                    if (a.origem.nome.Equals(nome))
                    {
                        return a.origem;
                    }
                    else
                    {
                        return a.destino;
                    }
                }
            }
            Aeroporto verticeRetorno = new Aeroporto(nome);
            vertices.Add(verticeRetorno);
            return verticeRetorno;
        }

        public void viagemMenorCusto(Aeroporto origem, Aeroporto destino)
        {
            List<Aeroporto>[] caminho = new List<Aeroporto>[this.vertices.Count];
            int[] custo = new int[this.vertices.Count];
            List<Aeroporto> caminhoPercorrido = new List<Aeroporto>();
            List<Aresta> arestasAdjacentes = new List<Aresta>();
            for (int i = 0; i < this.vertices.Count; i++)
            {
                arestasAdjacentes = ProcurarAdjacentes(origem);
               
                for (int j = 0; j < arestasAdjacentes.Count; j++)
                {
                    // caminho[i].Add(arestasAdjacentes[j].RetornarAeroporto2());

                    //só pra não fuder a lista original por causa da referencia
                    List<Aeroporto> aeroportoAux = new List<Aeroporto>();
                    List<Aeroporto> caminhoAux = new List<Aeroporto>();

                    aeroportoAux.Add(arestasAdjacentes[j].RetornarAeroporto2());

                    //cria o novo caminho, só não adc direto pq ainda não foi verificado se o novo caminho descoberto é o melhor
                    caminhoAux = caminho[i].Concat(aeroportoAux).ToList();
                    int index = 0;
                    while (vertices[index] != arestasAdjacentes[j].RetornarAeroporto2())
                    {
                        if (vertices[index] != arestasAdjacentes[j].RetornarAeroporto2())
                        {
                            if (custo[index] > custo[i] + arestasAdjacentes[j].distancia)
                            {
                                caminho[index] = caminhoAux;
                                custo[index] = custo[i] + arestasAdjacentes[j].distancia;
                            }
                        }

                    };
                }

            }
        }

    }
}
