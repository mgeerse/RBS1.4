namespace Model
{
    public class Tafel
    {
        public int Id { get; }
        public bool IsBezet { get; set; }

        public Tafel(int id, bool isBezet)
        {
            Id = id;
            IsBezet = isBezet;
        }
    }
}
