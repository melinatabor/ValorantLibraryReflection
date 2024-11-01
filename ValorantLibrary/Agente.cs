using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLibrary
{
    public class Agente
    {
        public string Nombre { get; set; }
        public Rol Rol { get; set; }
        public int Salud { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public Arma ArmaEquipada { get; set; }

    }
}
