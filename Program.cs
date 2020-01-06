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
        public static void Zadanie3()
        {
            Console.WriteLine("Podaj wymiary tablicy pierwszej dwuwymiarowej:");
            Console.Write("Podaj \"i\" tablicy pierwszej: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Podaj \"j\" tablicy pierwszej: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Podaj \"i\" tablicy drugiej: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Podaj \"j\" tablicy drugiej: ");
            int m2 = int.Parse(Console.ReadLine());

            int[,] tablica2D_1 = new int[n, m];
            int[,] tablica2D_2 = new int[n2, m2];

            int n3;
            int m3;



            if (n > n2)
                n3 = n;
            else
                n3 = n2;

            if (m > m2)
                m3 = m;
            else
                m3 = m2;

            int[,] tablica2D_wynikowa = new int[n3, m3];
            tablica2D_wynikowa.Initialize();

            for (int i = 0; i < tablica2D_1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2D_1.GetLength(1); j++)
                {
                    tablica2D_1[i, j] = i + j;
                }
            }

            for (int i = 0; i < tablica2D_2.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2D_2.GetLength(1); j++)
                {
                    tablica2D_2[i, j] = i * j;
                }
            }


            for (int i = 0; i < tablica2D_wynikowa.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2D_wynikowa.GetLength(1); j++)
                {
                    if (i >= tablica2D_1.GetLength(0) || i >= tablica2D_2.GetLength(0))
                        continue;
                    if (j >= tablica2D_1.GetLength(1) || j >= tablica2D_2.GetLength(1))
                        continue;
                    tablica2D_wynikowa[i, j] = tablica2D_1[i, j] + tablica2D_2[i, j];
                }
            }

            for (int i = 0; i < tablica2D_wynikowa.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2D_wynikowa.GetLength(1); j++)
                {
                    Console.Write("{0}\t", tablica2D_wynikowa[i, j]);
                }
                Console.WriteLine();
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
            Zadanie3();
            //Zadanie 4
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
            EBook ebook = new EBook("Sienkiewicz", "Potop", new DateTime(1963, 12, 09), new DateTime(2018, 3, 28), 29.99, 50);
            Console.WriteLine($"Autor: {ebook.Autor}   Tytuł: {ebook.Tytul}  " +
                $"Data Wydania: {ebook.DataWydania}  " + $"Data ostatniego zakupu: {ebook.DataOstatniegoZakupu}  " +
                $"Cena Standardowa: {ebook.CenaStandardowa} zł  " + $"Obniżka: {ebook.Obnizka.ToString("P", CultureInfo.InvariantCulture)}  " +
                $"Aktualna Cena: {ebook.AktualnaCena} zł");

            Console.ReadKey();
            
        }
    }
}

