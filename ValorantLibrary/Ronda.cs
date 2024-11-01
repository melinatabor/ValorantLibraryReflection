using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLibrary
{
    public class Ronda
    {
        public int Número { get; set; }
        public Equipo EquipoAtacante { get; set; }
        public Equipo EquipoDefensor { get; set; }
        public bool EstaSpikePlantada { get; set; }
        public Equipo EquipoGanador { get; set; }
    }
}
