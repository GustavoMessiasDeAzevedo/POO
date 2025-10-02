using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; }

        public string Descricao { get; set; }

        public Feriado(int dia, string descricao)
        {
            Dia = dia;
            Descricao = descricao;
        }

        public int CompareTo(Feriado other)
        {
            if (other == null) return 1;

            return other.Dia.CompareTo(this.Dia);
        }


    }
}
