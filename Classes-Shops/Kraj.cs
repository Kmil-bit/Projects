using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Kraj
    {
        private readonly string idKraj;

        public string getKod()
        {
            return idKraj;
        }

        private List<Miasto> miastoList = new List<Miasto>();

        public Miasto getMiasto(String name)
        {
            foreach (Miasto miasto in miastoList)
            {
                if (miasto.getName().Equals(name))
                {
                    return miasto;
                }
            }
            return null;
        }

       

        public Kraj(string idKraj)
        {
            this.idKraj = idKraj;
        }

        public void addMiasto(Miasto miasto)
        {
            miastoList.Add(miasto);
        }

        public String getId()
        {
            return idKraj;
        }

        public void removeMiasto(string idMiasta)
        {

        }

        public int size()
        {
            return miastoList.Count;
        }
    }
}
