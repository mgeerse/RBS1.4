namespace Model
{
    public class Bestelling
    {
        public int Id { get; }
        public string Opmerking { get; set; }
        public Medewerker Medewerker { get; set; }
        public Tafel Tafel { get; set; }
        public Rekening Rekening { get; set; }

        public Bestelling(int id, string Opmerking, Medewerker Medewerker, Tafel Tafel, Rekening Rekening)
        {
            Id = id;
            this.Opmerking = Opmerking;
            this.Medewerker = Medewerker;
            this.Tafel = Tafel;
            this.Rekening = Rekening;
        }
    }
}
