namespace ConsoleApp8
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Co chcesz policzyc?");
			string[] lista = { "Kwadrat","Prostokat","trojkat"};
			for(int i = 0; i < lista.Length; i++)
			{
				Console.WriteLine(i+1 +" "+lista[i]);
			}
			int decyzja = int.Parse(Console.ReadLine());
			if (decyzja=='1')
			{
				kwadrat kwadrat = new kwadrat();
			}else if (decyzja == 2)
			{
				prostokat prostokat = new prostokat();
			}
			else
			{
				trojkat trojkat = new trojkat();
			}
        }
	}
}
