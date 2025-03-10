using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	abstract class Zwierz
	{
		int waga;
		int wiek;

		public string imie;
		public void przedstawSie()
		{
            Console.WriteLine(imie);
        }

		public virtual void dajGlos()
		{
            Console.WriteLine("Wrrr");
        }
	}
}
