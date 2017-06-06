namespace Model
{
    public class Bezoek
    {
        public int Id { get; }
        public Tafel Tafel { get; set; }
        public Medewerker Medewerker { get; set; }

        public Bezoek(int id, Tafel tafel, Medewerker medewerker)
        {
            Id = id;
            Tafel = tafel;
            Medewerker = medewerker;
        }
    }
}