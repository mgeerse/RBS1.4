namespace Model
{
    public class Menukaart
    {
        public string naam { get; set; }
        public int id { get; }
        
        public Menukaart(string naam, int id)
        {
            this.naam = naam;
            this.id = id;
        }
    }
}
