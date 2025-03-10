using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Galeria
    {
        private readonly Miasto miasto;

        private List<Sklep> skleps = new List<Sklep>();

        public Galeria(Miasto miasto)
        {
            this.miasto = miasto;
          
        }

        public void addSklep(Sklep sklep)
        {
            skleps.Add(sklep);          
        }

        public int count()
        {
            return skleps.Count;
        }
    }
}
