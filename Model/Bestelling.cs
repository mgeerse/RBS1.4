namespace Model
{
    public class Bestelling
    {
        public int Id { get; }
        public Bezoek Bezoek { get; set; }

        public Bestelling(int id, Bezoek bezoek)
        {
            Id = id;
            Bezoek = bezoek;
        }
    }
}
