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
        public int BestelId;
        public string ItemNaam;
        public int Aantal;
        public string Opmerking;
        public DateTime Invoertijd;
        public string MedewerkerNaam;
        public int TafelNummer;
        public int Menuitem;

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
