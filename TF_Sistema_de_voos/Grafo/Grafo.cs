using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    public abstract class Grafo
    {
        public List<Aresta> arestas = new List<Aresta>();
        public List<Aeroporto> vertices = new List<Aeroporto>();

        
        public List<Aresta> ProcurarAdjacentes(Aeroporto vertice)
        {
            List<Aresta> arestasAdjacentes = new List<Aresta>();
            //procura arestas adjacentes de todos os vertices que já foram visitados
            
            
                arestasAdjacentes = arestasAdjacentes.Concat(arestas.FindAll(x => x.RetornarAeroporto1().Equals(vertice) && x.RetornarAeroporto2().vistado != true/*|| x.RetornarAeroporto2().Equals(vertice)*/)).ToList();
            
            //retorna lista de adjacentes ordenada 
            //(para garantir que o primeiro valor é sempre o menor, ou seja uma fila de prioridade gambiarrada)
            return Ordenar(arestasAdjacentes);
        }

        public List<Aresta> Ordenar(List<Aresta> arestas)
        {
            return arestas.OrderBy(x => x.distancia).ToList();
        }
    }
}
