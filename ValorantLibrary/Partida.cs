using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLibrary
{
    public class Partida
    {
        public string NombreDelMapa { get; set; }
        public Equipo EquipoA { get; set; }
        public Equipo EquipoB { get; set; }
        public List<Ronda> Rondas { get; set; }
        public Equipo EquipoGanador { get; set; }

    }
}
