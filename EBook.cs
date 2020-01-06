using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1
{
    class EBook
    {
        private readonly string _Autor;
        private readonly string _Tytul;
        private readonly DateTime _DataWydania;

        private DateTime _DataOstatniegoZakupu;
        private double _CenaStandardowa;
        private int _Obnizka;
        private double _AkutalnaCena;


        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, int obnizka)
        {
            _Autor = autor;
            _Tytul = tytul;
            _DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }
        public string Autor { get => _Autor; }
        public string Tytul { get => _Tytul; }
        public DateTime DataWydania { get => _DataWydania; }
        public DateTime DataOstatniegoZakupu
        {
            get
            {
                return _DataOstatniegoZakupu;
            }
            set
            {
                if (value.Date > _DataOstatniegoZakupu)
                    _DataOstatniegoZakupu = value;
            }
        }
        public double CenaStandardowa
        {
            get
            {
                return _CenaStandardowa;
            }
            set
            {
                if (value > 0)
                    _CenaStandardowa = value;
                else
                    Console.WriteLine("Cena standardowa nie moze być ujemna.");
            }
        }
        public int Obnizka
        {
            get
            {
                return _Obnizka;
            }
            set
            {
                if (value > 0)
                    _Obnizka = value;
                else
                    Console.WriteLine("Obnizka nie może dać ceny niższej niż 0.00 zł.");
            }
        }

        public double AktualnaCena
        {
            get
            {
                return _AkutalnaCena = CenaStandardowa * ((100 - Obnizka) / 100);
            }
            
        }
    }
}
