using System;

namespace LogikaGry
{
    public class Gra
    {
        // dane
        private readonly int wylosowanaLiczba;
        public int MinZakres { get; }
        public int MaxZakres { get; }

        // historia gry

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
        }

        // inne metody
    }
}
