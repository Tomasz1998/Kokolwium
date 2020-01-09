using System;
using System.Globalization;

namespace Kolokwium1
{

    class Program
    {
      
        public static double Zadanie1(int liczba)
        {
            
            int n = liczba;
            if (n == 0)
            {
                return 1.0;
            }
            else
                return (1.5 * (Zadanie1(n - 1))) - 1;
        }

        public static void Zadanie2()
        {
            int[] tablica = new int[200];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
            }

            Console.Write("Podaj liczbę przez którą dzielić:");

            int dzielnik = int.Parse(Console.ReadLine());

            if (dzielnik == 0)
                throw new DivideByZeroException();
            else
            {
                for (int i = dzielnik; i < tablica.Length; i++)
                {
                    if (tablica[i] % dzielnik == 0)
                        Console.WriteLine("Liczba: {0}", tablica[i]);
                }
            }
        }
      
        static int Zadanie4(int[,] tablica)
        {
            int min = int.MaxValue;
            foreach (var item in tablica)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        static int Zadanie4(int[][] tablica)
        {
            int min = int.MaxValue;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    if (tablica[i][j] < min)
                    {
                        min = tablica[i][j];
                    }
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            //Zadanie 1
            Console.Write("Podaj liczbe n: ");
            if (int.TryParse(Console.ReadLine(), out int liczba))
            {
                Console.WriteLine(Zadanie1(liczba));
            }

            //Zadanie 2
            try
            {
                Zadanie2();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Nie mozna dzielić przez zero");
            }
            //Zadanie 3
          
            
            int[,] jeden = new int[3, 8];
            int[,] dwa = new int[5, 5];

            int rozmiar1 = Math.Max(jeden.GetLength(0), dwa.GetLength(0));
            int rozmiar2 = Math.Max(jeden.GetLength(1), dwa.GetLength(1));

            int[,] wynik = new int[rozmiar1, rozmiar2];

            for (int i = 0; i < jeden.GetLength(0); i++)
            {
                for (int j = 0; j < jeden.GetLength(1); j++)
                {
                    jeden[i, j] = 1;
                    wynik[i, j] += jeden[i, j];
                }
            }

            for (int i = 0; i < dwa.GetLength(0); i++)
            {
                for (int j = 0; j < dwa.GetLength(1); j++)
                {
                    dwa[i, j] = 1;
                    wynik[i, j] += dwa[i, j];
                }
            }

            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    Console.Write(wynik[i, j]);
                }
                Console.WriteLine();
            }

            //Zadanie 5
            EBook ebook = new EBook("Sienkiewicz", "Potop", new DateTime(1963, 12, 09), new DateTime(2018, 3, 28), 30, 50);
            Console.WriteLine($"Autor: {ebook.Autor}   Tytuł: {ebook.Tytul}  " +
                $"Data Wydania: {ebook.DataWydania}  " + $"Data ostatniego zakupu: {ebook.DataOstatniegoZakupu}  " +
                $"Cena Standardowa: {ebook.CenaStandardowa} zł  " + $"Obniżka: {ebook.Obnizka.ToString("P", CultureInfo.InvariantCulture)}  " +
                $"Aktualna Cena: {ebook.AktualnaCena} zł");

            Console.ReadKey();
            
        }
    }
}

