﻿namespace Model
{
    public class Menuitem
    {
        public int Id { get; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public Categorie Categorie { get; set; }
        public int Voorraad { get; set; }

        public Menuitem(int id, string naam, decimal prijs, Categorie categorie, int Voorraad)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
            Categorie = categorie;
            this.Voorraad = Voorraad;
        }
    }
}
