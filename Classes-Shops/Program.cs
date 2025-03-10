
namespace Galerie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Europa  europa = new Europa();
            String[] lines = File.ReadAllLines("galerie.txt");
            foreach (String line in lines)
            {
                String[] tablica = line.Split();
                String kodKraju = tablica[0];

                Kraj kraj = europa.getKraj(kodKraju);
                if (kraj == null)
                {
                    kraj = new Kraj(kodKraju);
                    europa.addKraj(kraj);
                }

                String kodMiasta = tablica[1];
                Miasto miasto = kraj.getMiasto(kodMiasta);
                if(miasto == null)
                {
                    miasto = new Miasto(kodMiasta, kraj);
                    kraj.addMiasto(miasto);
                }
                Galeria galeria = new Galeria(miasto);
                miasto.addGaleria(galeria);

                for(int i = 2; i<tablica.Length-1; i = i + 2)
                {
                    int x = Int32.Parse(tablica[i]);
                    int y = Int32.Parse(tablica[i+1]);
                    Sklep sklep = new Sklep(x, y);
                    galeria.addSklep(sklep);
                }
            }

            Console.WriteLine(europa.size());

            /* porownywanie sklepow */
            Sklep sklep1 = new Sklep(2, 10);
            Sklep sklep2 = new Sklep(4, 8);
            Console.WriteLine(sklep1.CompareTo(sklep2));

        }
    }
}