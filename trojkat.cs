using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class trojkat
	{
		public trojkat()
		{
			Console.WriteLine("Co chcesz policzyć?");
			Console.WriteLine("Pole - 1");
			Console.WriteLine("Obwod - 2");
			int decyzja = int.Parse(Console.ReadLine());
			if (decyzja == 1)
			{
				Obwod();
			}
			else if (decyzja == 2)
			{
				Pole();
			}
		}
		public void Obwod()
		{
			Console.WriteLine("Podaj pierwszy bok");
			int bok1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj drugi bok");
			int bok2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj trzeci bok");
			int bok3 = int.Parse(Console.ReadLine());
			Console.WriteLine(bok1 + bok2 + bok3);

		}
		public void Pole()
		{
			Console.WriteLine("Podaj pierwszy bok");
			int bok1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Podaj wysokosc");
			int wys = int.Parse(Console.ReadLine());
            Console.WriteLine(bok1*wys/2);

        }
	}
}
