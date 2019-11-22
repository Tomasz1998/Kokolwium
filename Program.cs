using System;

namespace Kolokwium1
{
   
    class Program
    {
        void OpiszEbook(EBook ksiazka)
        {
            Console.WriteLine("Autor: " + ksiazka.Autor + " Tytuł: " + ksiazka.Tytul + " Data Wydania: " + ksiazka.DataWydania + " Cena ksiązki: " + ksiazka.CenaStandardowa + " Obnizka: " + ksiazka.Obniżka + " % " + " Data ostatniego zakupu: " + ksiazka.DataOstatniegoZakupu);
        }
        static void Zadanie1()
        {
            
            int n;
            double y;
            Console.WriteLine("Proszę podać liczbę");
            n = int.Parse(Console.ReadLine());
            
           
            
           
        }
        static void Zadanie3()
        {
            int[,] Tab = new int[3, 10];
            int[,] Tab1 = new int[10, 8];
            Tab[0, 0] = 12;
            Tab[2, 1] = 111;
            Tab1[3, 4] = 10;
            Tab1[2, 5] = 17;
            int sumuj;
            for (int i = 0; i < Tab.Length; i++)
            {
                for (int k = 0; k < Tab.Length; k++)
                {
                  
                    
                }
            }
            
           
        }
        

        static void Main(string[] args)
        {
            
        }
    }
}

