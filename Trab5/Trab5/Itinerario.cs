using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab5
{
    class Itinerario: IComparable<Itinerario>
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Partida { get; set; }
        public DateTime Chegada { get; set; }
        public string IdVoo { get; set; }
        public int CompareTo(Itinerario it)
        {
            if (Partida > it.Partida)
            {
                return 1;
            }
            else
            {
                if (Partida < it.Partida)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public override bool Equals(Object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Itinerario it = (Itinerario)obj;
                //regras para considerar 2 objetos Itinerario iguais
                if((IdVoo == it.IdVoo) && (Origem == it.Origem) && (Destino == it.Destino) && (Partida == it.Partida) && (Chegada == it.Chegada))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
