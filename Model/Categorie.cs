namespace Model
{
    public class Categorie
    {
        public int Id { get; }
        public string Naam { get; set; }
        public int BtwPercentage { get; set; }
        public Menukaart Menukaart { get; set; }
        
        public Categorie(int id, string naam, int btwPercentage, Menukaart Menukaart)
        {
            Id = id;
            Naam = naam;
            BtwPercentage = btwPercentage;
            this.Menukaart = Menukaart;
        }
    }
}
