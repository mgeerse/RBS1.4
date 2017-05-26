namespace Model
{
    public class Bestelitem
    {
        public Bestelling Bestelling { get; set; }
        public Menuitem Menuitem { get; set; }
        public int Aantal { get; set; }

        public Bestelitem(Bestelling bestelling, Menuitem menuitem, int aantal)
        {
            Bestelling = bestelling;
            Menuitem = menuitem;
            Aantal = aantal;
        }
    }
}
