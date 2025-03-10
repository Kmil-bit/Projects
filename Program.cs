namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Która figura");
            Console.WriteLine("1-kwadrat");
            Console.WriteLine("2-prostokat");
			string decyzja = Console.ReadLine();
			if( decyzja == "1")
			{
                kwadrat k1 = new kwadrat();
                Console.WriteLine("1-pole");
                Console.WriteLine("2-obow");
				string coRobimy = Console.ReadLine();
				if (coRobimy == "1")
				{
					k1.pole();
                }
				if(coRobimy == "2")
				{
                    k1.obwod();
                }
            }
			if(decyzja == "1")
			{
                prostokat k1 = new prostokat();
                Console.WriteLine("1-poole");
                Console.WriteLine("2-obwod");
				string coRobimy = Console.ReadLine();
				if(coRobimy == "1")
				{
					k1.pole();
				}
				if(coRobimy == "2")
				{
					k1.obwod();
				}
            }
        }
	}
}
