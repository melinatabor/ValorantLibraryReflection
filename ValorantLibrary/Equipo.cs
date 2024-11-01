using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLibrary
{
    public class Equipo
    {
        public string NombreDelEquipo { get; set; }
        public List<Agente> Agentes { get; set; }
        public int Puntaje { get; set; }

    }
}
