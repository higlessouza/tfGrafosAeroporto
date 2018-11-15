using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    public class Aeroporto
    {
        public string nome;
        public bool vistado;

        public Aeroporto(string nome)
        {
            this.nome = nome;
        }
        public bool Equals(Aeroporto v)
        {
            if (v.nome.Equals(nome))
            {
                return true;
            }
            return false;
        }
    }
}
