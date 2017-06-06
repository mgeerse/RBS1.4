using System;

namespace Model
{
    public class Rekening
    {
        public int Id { get; }
        public DateTime Tijdstip { get; set; }
        public decimal TotaalExclusief { get; set; }
        public decimal BtwBedrag { get; set; }

        public Rekening(int id, DateTime Tijdstip, decimal TotaalExclusief, decimal BtwBedrag)
        {
            Id = id;
            this.Tijdstip = Tijdstip;
            this.TotaalExclusief = TotaalExclusief;
            this.BtwBedrag = BtwBedrag;
        }
    }
}
