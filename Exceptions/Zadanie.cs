using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Galerie
{
    internal class Zadanie
    {
        int number;

        public Zadanie(int number)
        {
            this.number = number;
        }

        public void wykonaj()
        {
            Console.WriteLine("ruszylo zadanie " + number);
            for(int i =0;i< 10; i++)
            {
                Console.WriteLine("Jestem watkiem: "+ number);
                Thread.Sleep(500);
            }
            Console.WriteLine("zadanie sie zakonczylo " + number);
        }


    }
}
