namespace Model
{
    public class Rekening
    {
        public int Id { get; }
        public Bezoek Bezoek { get; set; }

        public decimal nummer { get; }

        public Rekening(int id, Bezoek bezoek, decimal nummer)
        {
            Id = id;
            Bezoek = bezoek;
        }
    }
}
