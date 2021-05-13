using System;
using System.Collections.Generic;

namespace LogikaGry
{
    public class Gra
    {
        // dane
        private readonly int wylosowanaLiczba;
        public int MinZakres { get; }
        public int MaxZakres { get; }

        public int? WylosowanaLiczba
        {
            get
            {
                if( StatusGry != Status.Trwa )
                    return wylosowanaLiczba;

                return null;
            }
        }

        public enum Status { Trwa, Poddana, Zakonczona }
        public Status StatusGry { get; private set; }


        // historia gry - lista ruchów
        private List<Ruch> historiaGry;
        public IReadOnlyList<Ruch> HistoriaGry => historiaGry;


        // konstruktory
        //public Gra() : this(1, 100)
        //{
        //}

        public Gra( int min = 1, int max = 100 )
        {
            if (min >= max)
                throw new ArgumentException("min musi bć mniejszy od max");

            wylosowanaLiczba = (new Random()).Next(min, max+1);
            MinZakres = min;
            MaxZakres = max;
            historiaGry = new List<Ruch>();
            StatusGry = Status.Trwa;
        }

        // inne metody

        public Odpowiedz Ocena(int propozycja)
        {
            if (propozycja < wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaMalo, StatusGry));
                return Odpowiedz.ZaMalo;
            }
            else if (propozycja > wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo, StatusGry));
                return Odpowiedz.ZaDuzo;
            }
            else
            {
                StatusGry = Status.Zakonczona;
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.Trafiony, StatusGry));
                return Odpowiedz.Trafiony;
            }
        }

        public enum Odpowiedz { ZaMalo=-1, Trafiony=0, ZaDuzo=1 };


        public void Poddaj()
        {
            StatusGry = Status.Poddana;
            historiaGry.Add(new Ruch(null, null, StatusGry));
        }
    }
}
