using System;

namespace Model
{
    public class Medewerker
    {
        public int Id { get; }
        public string Naam { get; set; }
        public MedewerkerType Type { get; set; }

        /* Er is hier een get body nodig, omdat een bodyloze get niet
         * mag bestaan zonder bodyloze set zoals hierboven. 
         * Daarom is ook een private field nodig. Als Logincode gewoon
         * Logincode terug zou geven, zouden we in een loop terecht komen.
         */
        private char[] _Logincode;
        public char[] Logincode
        {
            get
            {
                return _Logincode;
            }
            set
            {
                if (value.Length != 4)
                    throw new ArgumentException("Ingevoerde arrays moeten exact 4 karakters bevatten!");
                else
                    _Logincode = value;
            }
        }

        public Medewerker(int id, string naam, MedewerkerType type, char[] logincode)
        {
            Id = id;
            Naam = naam;
            Type = type;
            Logincode = logincode;
        }
    }

    public enum MedewerkerType
    {
        Administratie, // 0
        Bar, // 1
        Keuken, // 2
        Bediening, // 3
    }
}
