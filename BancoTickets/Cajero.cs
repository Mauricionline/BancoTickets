using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTickets
{
    class Cajero
    {
        List<int> listaAtendidos = new List<int>();

        public List<int> ListaAtendidos { get => listaAtendidos; set => listaAtendidos = value; }
    }
}
