using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class kwadrat
	{
		public kwadrat() 
		{
            Console.WriteLine("Co chcesz policzyć?");
            Console.WriteLine("Pole - 1");
            Console.WriteLine("Obwod - 2");
			int decyzja = int.Parse(Console.ReadLine());
			if (decyzja == 1)
			{
				Obwod();
			}else if(decyzja == 2)
			{
				Pole();
			}
        }
		public void Obwod()
		{
            Console.WriteLine("Podaj bok");
			int bok = int.Parse(Console.ReadLine());
            Console.WriteLine(bok*4);
        }
		public void Pole()
		{
			Console.WriteLine("Podaj bok");
			int bok = int.Parse(Console.ReadLine());
			Console.WriteLine(bok * bok);
		}
	}
}
