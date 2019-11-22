using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1
{
    class EBook
    {
        private double _CenaStandardowa;
        
        public string Autor { get; private set; }
        public string Tytul { get; private set; }
        public DateTime DataWydania    
        {
            get
            {
                return DataWydania;
            }
            private set
            {
                DataWydania = value;
            }
        }
        public DateTime DataOstatniegoZakupu { get; set; }
        public double CenaStandardowa
        {
            get
            {
                return _CenaStandardowa;
            }
            set
            {
                _CenaStandardowa = value;
                if (_CenaStandardowa < 0)
                {
                    _CenaStandardowa = 0;
                }
            }
        }
        public double AktualnaCena
        {
            get
            {
                return AktualnaCena;
            }
            set
            {
                AktualnaCena = _CenaStandardowa * ((100 - Obniżka) / 100);
            }
        }
        public double Obniżka { get; set; }

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obniżka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obniżka = obniżka;
        }

    }
}
