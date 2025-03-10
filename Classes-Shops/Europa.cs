using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Europa
    {
        private List<Kraj> krajList = new List<Kraj>();

        public Kraj getKraj(String kod)
        {
           foreach(Kraj kraj in krajList)
            {
                if (kraj.getKod().Equals(kod))
                {
                    return kraj;
                }
            }
            return null;
        }




        public void addKraj(Kraj kraj)
        {
            krajList.Add(kraj);
        }
            

        public void removeKraj(string idKraj)
        {

        }

        public int size()
        {
            return krajList.Count;
        }
    }
}
