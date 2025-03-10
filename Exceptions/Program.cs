
using ConsoleApp10;
using System.Threading;

namespace Galerie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i=0;i<20; i++)
            //{
            //    Zadanie zadanie = new Zadanie(i);
            //    Thread watek = new Thread(new ThreadStart(zadanie.wykonaj));
            //    watek.Start();
            //}


            /*
                        for(int i =0;i< 10; i++)
                        {
                            Zadanie zadanie = new Zadanie(i);
                            Thread thread = new Thread(new ThreadStart(zadanie.wykonaj));
                            thread.Start();


                        }*/



            /* try
             {
                 Console.WriteLine(Utils.divide(25.0, 0));

             } catch (DivideByZeroException e)
             {
                 Console.WriteLine("ala ma kota");
             }*/


            //Przechowywacz<int> p1 = new Przechowywacz<int>(10, "rozmiar buta", false);

            //Przechowywacz<int> p2 = new Przechowywacz<int>(20, "temp wody", true);

            //Przechowywacz<double> p3 = new Przechowywacz<double>(38.7, "temp wody w Chorwacji", true);


            //Przechowywacz<string> p4 = new Przechowywacz<string>("Julian Tuwim", "Autor bajek", true);



            List<Przechowywacz<int>> listaPrzechowywaczy = new List<Przechowywacz<int>>();

			Przechowywacz<double> dane = new Przechowywacz<double>();
			dane.setData(6.0, "rozmiar buta");


			Console.WriteLine("dziala");




















			/* DlugaKlasa dlugaKlasa = new DlugaKlasa();

             dlugaKlasa.zadanie();

             try
             {
                 double a = Utils.divide(10, 0);
                 Console.WriteLine(a);
             }catch (Exception ex)
             {
                 Console.WriteLine("Wyjatek");
             }


             Przechowywacz<double> dane = new Przechowywacz<double>();
             dane.setData(6.0, "rozmiar buta");


             Console.WriteLine("dziala");


            */

			/*

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

            Console.WriteLine(europa.size());*/

			/* porownywanie sklepow */
			//Sklep sklep1 = new Sklep(2, 10);
			//Sklep sklep2 = new Sklep(4, 8);
			//Console.WriteLine(sklep1.Equals(sklep2));

		}
    }
}