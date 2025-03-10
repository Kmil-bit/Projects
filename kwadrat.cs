using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class kwadrat
	{
		int a;

		public void podajDane()
		{
            Console.WriteLine("Podaj dl boku A");
			int a = Int32.Parse(Console.ReadLine());
		}

		public void pole()
		{
			Console.WriteLine(a * a);
		}
		public void obwod()
		{
            Console.WriteLine(4*a);
        }
	}
}
