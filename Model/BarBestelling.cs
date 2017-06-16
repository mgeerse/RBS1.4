using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //MG
    public class BarBestelling
    {
        // HACK Al deze items zijn te vinden als je een Bestelitem aanroept.
        /*
         * EG: Ik heb een Bestelitem met een Bestelling en een Menuitem.
         * Als ik een Menuitem heb, heb ik ook een categorie, heb ik ook een menukaart.
         * Als ik een bestelling heb, heb ik ook een tafel, een medewerker en een rekening.
         * Dus door het aanropen van een bestelitem heb ik AL deze fields.
         */

        public int BestelId; // Bestelitem.Bestelling.Id
        public string ItemNaam; // Bestelitem.Menuitem.Naam
        public int Aantal; // Bestelitem.Aantal
        public string Opmerking; // Bestelitem.Opmerking
        public DateTime Invoertijd; // Bestelitem.TijdIngevoerd
        public string MedewerkerNaam; // Bestelitem.Bestelling.Medewerker.Naam
        public int TafelNummer; // Bestelitem.Bestelling.Tafel.Id
        public int Menuitem; // Bestelitem.Menuitem.Id

        public BarBestelling()
        {

        }

        public BarBestelling(int BestelId, string ItemNaam, int Aantal, string Opmerking, DateTime Invoertijd, string MedewerkerNaam)
        {
            this.BestelId = BestelId;
            this.ItemNaam = ItemNaam;
            this.Aantal = Aantal;
            this.Opmerking = Opmerking;
            this.Invoertijd = Invoertijd;
            this.MedewerkerNaam = MedewerkerNaam;
        }
    }
}
