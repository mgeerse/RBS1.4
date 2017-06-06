namespace Model
{
    public class Rekening
    {
        public int Id { get; }
        public Bezoek Bezoek { get; set; }

        public Rekening(int id, Bezoek bezoek)
        {
            Id = id;
            Bezoek = bezoek;
        }
    }
}
