using System.Reflection.Metadata.Ecma335;
namespace Cw1
{
    internal class Program
{
      /*  static double dodaj(int a, int b)
        {
            return a + b;
        }
        static void printTable(int[] tab)
        {
            string text = "[";
            for (int i = 0; i < tab.Length; i++)
            {
                text += tab[i];
                if (i < tab.Length - 1)
                {
                    text += ",";
                }
            }
            text += "]";
            Console.WriteLine(text);
        }
        static int cos(int wartosc)
        {
            wartosc = wartosc * 2;
            return wartosc;
        }*/
        //liczba pierwsza vvvvvv
        /*  static bool isPrimary(int number)
          {
              for(int i = 2; i < Math.Sqrt(number) +1; i++)
              {
                  if (number % 2 == 0)
                  {
                      return false;
                  }
              }
              return true;
          }*/
        // ile razy powtarza sie liczba w tabeli (trzeba podac liczbę i table żeby działało) np. CountInTable(2, tabela) wypisze 2 czy cos to nizej vvv
        /*     static int countInTable(int number, int[] tab)
             {
                 int count = 0;
                 foreach (int value in tab)
                 {
                     if (value == number)
                         count++;
                 }
                 return count;
             }*/
        // Najwieksza liczba w tabeli vvv (giga łatwe)
        /*  static int getMax(int[] tab)
          {
              int max = tab[0];
              foreach (int value in tab)
              {
                  if (value > max)
                      max = value;
              }
              return max;
          }   */

        //Tu jest funkcja która liczy długość tabeli (sam to zrobiłem lol) vvvv
       /*  static int countInTable(int[] tab)
         {
             int liczba = 0;
             for (int i = 0; i < tab.Length; i++){
                 liczba ++;
             }
             return liczba;
         }*/
        //Podaje indexy tabeli czyli wpisz liczbe którą chcesz znaleźć w tabeli i wypisuje ci na którym miejscu jest np 5 i 13 vvvv
    /*    static int[] getIndexes(int value, int[] tab)
        {
            int count = countInTable(tab);
            int[] tableOfIndexes = new int[count];
            int j = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == value)
                {
                    tableOfIndexes[j] = i;
                    j++;
                }
            }

            return tableOfIndexes;
        }*/

        // wypisywanie całej tablicy w stylu [a,b,c,d] vvv tak mi sie wydaje
       /* static void printTable(int[] tab)
        {
            string text = "[";
            for (int i = 0; i < tab.Length; i++)
            {
                text += tab[i];
                if (i < tab.Length - 1)
                {
                    text += ",";
                }
            }
            text += "]";
            Console.WriteLine(text);
        }
       */
       static double Waluta(double imie)
        {
            imie = imie * 2.54;
            return imie;
        }

        static void Main(string[] args)
    {
     //   Console.WriteLine("Tu bedzie wynik");
            // int[] tab = { 1, 2, 312, 41, 51, 5, 215, 15,5};
            //int[] tab = { {1, 2};
            //      Console.WriteLine(countInTable(5,tab));
            //       Console.WriteLine(countInTable(tab));
            //    Console.WriteLine(getIndexes(5,tab));
            // Console.WriteLine(printTable(tab));
            Console.WriteLine(Waluta(1.3));
            Console.WriteLine("Podaj liczbe: ");
            double imie = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Waluta(imie));
        }
}
}