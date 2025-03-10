using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Galerie
{
    internal class Sklep: IComparable
	{
        private Galeria galeria;
        
        private int x;

        private readonly int y;

        public Sklep(int x, int y)
        {
            if (x > 0)
            {
                this.x = x;
            }
            if (y > 0)
            {
                this.y = y;
            }
        }

        public Sklep(int x, int y , Galeria galeria)
        {
            this.galeria = galeria;

            if(x > 0)
            {
                this.x = x;
            }

            if (y > 0)
            {
                this.y = y;
            }

        }



        public int sklepSize()
        {
            return x * y;
        }





        public void setGaleria(Galeria galeria)
        {
            this.galeria = galeria;
        }


        public void setX(int x)
        {
            if(x > 0)
            {
                this.x = x;
            }
        }

        public int getX()
        {
            return x;
        }


        public bool Equals(Sklep? otherSklep)
        {
            int powierzchnia = otherSklep.sklepSize();
            if (sklepSize() == powierzchnia)
            {
                return true;
            }
            return false;

        }

        public int CompareTo(Sklep? otherSklep)
        {
            if (otherSklep == null) return 1;
            int powierzchnia = otherSklep.sklepSize();
            if(powierzchnia != null)
            {
                return this.sklepSize().CompareTo(powierzchnia);
            }
            return 0;
        }


        public int X
        {
            get { return x; }

            set
            {
                if (value > 0)
                {
                   x = value;
                }
            }
        }

       

       
    }
}
