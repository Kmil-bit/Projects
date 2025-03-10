using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class Pies:Zwierz
	{
		public Pies()
		{
            Console.WriteLine("Wpisz Imie");
            imie = Console.ReadLine();
		}
		public int wiek;
		public int waga;
		public string imie;

		public override void DajGlos()
		{
            Console.WriteLine("NIGGER");
        }
	}
}
