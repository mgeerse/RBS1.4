namespace Model
{
    public class Bestelling
    {
        public int Id { get; }
        public Rekening Rekening { get; set; }
        public string Opmerking { get; set; }
        public Medewerker Medewerker { get; set; }
        public Tafel Tafel { get; set; }

        public Bestelling(int id, Rekening Rekening, string Opmerking, Medewerker Medewerker, Tafel Tafel)
        {
            Id = id;
            this.Rekening = Rekening;
            this.Opmerking = Opmerking;
            this.Medewerker = Medewerker;
            this.Tafel = Tafel;
        }
    }
}
