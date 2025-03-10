using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Utils 
    {

        public static double divide(double x, double y) 
        {
            if(y ==0)
            {

                throw new DivideByZeroException();

            }
            return x / y;
        }
    }
}
