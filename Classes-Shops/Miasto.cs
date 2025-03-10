using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Miasto
    {
        private readonly string miastoName;
        public String getName()
        {
            return miastoName;
        }

        private readonly Kraj kraj;

        private List<Galeria> galeriesList = new List<Galeria>();

      

        public Miasto(string miastoName, Kraj kraj)
        {
            this.miastoName = miastoName;
            this.kraj = kraj;
        }

        public void addGaleria(Galeria galeria)
        {
            galeriesList.Add(galeria);
        }

        public int size()
        {
            return galeriesList.Count;  
        }


    }
}
