using System;

namespace Model
{
    public class Bestelitem
    {
        public Bestelling Bestelling { get; set; }
        public Menuitem Menuitem { get; set; }
        public int Aantal { get; set; }
        public Status Status { get; set; }
        public string Opmerking { get; set; }
        public DateTime Tijdingevoerd { get; set; }

        public Bestelitem(Bestelling bestelling, Menuitem menuitem, int aantal, Status Status, string Opmerking, DateTime Tijdingevoerd)
        {
            Bestelling = bestelling;
            Menuitem = menuitem;
            Aantal = aantal;
            this.Status = Status;
            this.Opmerking = Opmerking;
            this.Tijdingevoerd = Tijdingevoerd;
        }
    }

    public enum Status
    {
        Ingevoerd, //0
        Bezig, //1
        Klaar, //2
        Teruggestuurd, //3
    }
}
