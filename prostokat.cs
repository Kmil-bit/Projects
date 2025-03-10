using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class prostokat
	{
		int a, b;

		public void podajDane()
		{
			Console.WriteLine("Podaj dl boku A");
			int a = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Podaj dl boku B");
			int b = Int32.Parse(Console.ReadLine());
		}

		public void pole()
		{
			Console.WriteLine(a * b);
		}
		public void obwod()
		{
			Console.WriteLine(2 * a + 2 * b);
		}
	}
}
