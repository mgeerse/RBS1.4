using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BarBestelling
    {
        public int BestelId { get; set; }
        public string ItemNaam { get; set; }
        public int Aantal { get; set; }
        public string Opmerking { get; set; }
        public DateTime Invoertijd { get; set; }
        public string MedewerkerNaam { get; set; }


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
