using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAccueil.com.doubleedgedsword.entities
{
    abstract class Period : Entity
    {
        private int idPeriod;
        private string name;

        public int IdPeriod { get ; set ; }

        public string Name { get; set; }
    }
}
