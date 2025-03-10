using System;
using System.IO;

class Program
{
	static void Main()
	{
		string fileName = "kody 1.txt"; // Ustaw nazwę pliku na odpowiednią

		try
		{
			// Otwórz plik do odczytu
			using (StreamReader sr = new StreamReader(fileName))
			{
				string line;

				// Odczytaj każdą linię z pliku
				while ((line = sr.ReadLine()) != null)
				{
					// Sprawdź, czy cała linia składa się z cyfr parzystych
					if (IsAllDigitsEven(line))
					{
						Console.WriteLine(line);
					}
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine($"Wystąpił błąd: {e.Message}");
		}
		char lol = '5';
		Console.Write(lol % 2);
	}



	// Funkcja sprawdzająca, czy wszystkie cyfry w ciągu są parzyste
	static bool IsAllDigitsEven(string str)
	{
		foreach (char c in str)
		{
			if (!char.IsDigit(c) ||  c  % 2 != 0)
			{
				return false;
			}
		}
		return true;
	}
}