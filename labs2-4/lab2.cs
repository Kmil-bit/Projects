using System.Collections;

namespace ConsoleApp3
{
	internal class Program
	{
		/*	static bool spalindrom(string palindrom)
			{
				if (palindrom=palindrom.Reverse)
				{
					return true;
				}else
				return false;
			}*/
		/*static bool isPalindrom(string txt)
			{
				for (int i = 0; i < txt.Length; i++)
				{
					if (txt[i] != txt[txt.Length - 1 - i])
					{
						return false;
					}
				}
				return true;
			}*/
		static ArrayList czynnikiPierwsze(int liczba)
			{
				ArrayList lista = new ArrayList();
				int dzielnik = 2;
				while (liczba != 1)
				{
					if (liczba % dzielnik == 0)
					{
						liczba = liczba / dzielnik;
						lista.Add(dzielnik);
					}
					else
					{
						dzielnik++;
					}
				}
				return lista;
			}
		/*static void cochcesz()
			{
				Console.WriteLine("Podaj 1 liczbe");
				string x = Console.ReadLine();
				Console.WriteLine("Podaj 2 liczbe");
				string y = Console.ReadLine();
				Console.WriteLine("Co chcesz zrobic");
				Console.WriteLine("1 - dodaj");
				Console.WriteLine("2 - odejmij");
				string decyzja = Console.ReadLine();

				switch (decyzja)
				{
					case "1":
						int wynik = int.Parse(x) + int.Parse(y);
						Console.WriteLine("Wynik dodawania: " + wynik);
						break;
					case "2":
						int wynik2 = int.Parse(x) - int.Parse(y);
						Console.WriteLine("Wynik odejmowania: " + wynik2);
						break;
				}
			}*/
		/*static double convert(string number, int baseNumber)
			{
				double result = 0;

				for(int i = 0; i < number.Length; i++)
				{
					int liczba = int.Parse(number[i].ToString());
					int potega = number.Length - 1 - i;
					result = result + liczba * Math.Pow(baseNumber, potega);
				}
				return result;
			}*/

		static void Main(string[] args)
		{
			//		Console.WriteLine(isPalindrom("kajak"));
				ArrayList wynik = czynnikiPierwsze(22);
				foreach (int i in wynik)
				{
					Console.WriteLine(i);
				}
			/*	Console.WriteLine("Podaj 1 liczbe");
                string x = Console.ReadLine();
                Console.WriteLine("Podaj 2 liczbe");
                string y = Console.ReadLine();
                Console.WriteLine("Co chcesz zrobic");
                Console.WriteLine("1 - dodaj");
                Console.WriteLine("2 - odejmij");
                string decyzja = Console.ReadLine();

                switch (decyzja)
                {
                    case "1":
                        int wynik = int.Parse(x) + int.Parse(y);
                        Console.WriteLine("Wynik dodawania: " + wynik);
                        break;
                    case "2":
                        int wynik2 = int.Parse(x) - int.Parse(y);
                        Console.WriteLine("Wynik odejmowania: " + wynik2);
                        break;
                }
            */
			//    Console.WriteLine(convert("1111",2));
		}
	}
}