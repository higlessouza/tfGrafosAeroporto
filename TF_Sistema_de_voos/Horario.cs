using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Sistema_de_voos
{
    public class Horario
    {
        public int hora, minuto;
        /// <summary>
        /// Recebe um horario no formato "hh:mm"
        /// </summary>
        /// <param name="horario"> formato "hh:mm" </param>
       public Horario(string horario)
        {
            string[] dadosHorario;
            dadosHorario = horario.Split(':');
            hora = int.Parse(dadosHorario[0]);
            minuto = int.Parse(dadosHorario[1]);
        }

        /// <summary>
        /// Recebe dois inteiros, sendo hora e minuto.
        /// </summary>
        /// <param name="hora"></param>
        /// <param name="minuto"></param>
        public Horario(int hora, int minuto)
        {
            this.hora = hora;
            this.minuto = minuto;
        }
    }
}
