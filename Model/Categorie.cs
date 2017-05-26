namespace Model
{
    public class Categorie
    {
        public int Id { get; }
        public string Naam { get; set; }
        public int BtwPercentage { get; set; }

        public Categorie(int id, string naam, int btwPercentage)
        {
            Id = id;
            Naam = naam;
            BtwPercentage = btwPercentage;
        }
    }
}
