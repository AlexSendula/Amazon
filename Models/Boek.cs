using System;
using System.Collections.Generic;

namespace Amazon.Models {
    public class Boek
    {
        public string isbn { get; set; }
        public string auteur { get; set; }
        public string titel { get; set; }
        public string genre { get; set; }
        public Boek(string isbn, string auteur, string titel, string genre)
        {
            this.isbn = isbn;
            this.auteur = auteur;
            this.titel = titel;
            this.genre = genre;
        }
        public static List<Boek> Boeken { get; set; } = new List<Boek>() { 
            new Boek("978-7-6512-7309-0", "Wade Dorota Kató", "De mega-explosie", "actie"),
            new Boek("978-7-6642-3124-7", "Josip Suse Dane", "De grote liefde", "liefde"),
            new Boek("978-5-7877-3887-2", "Genesio Nilüfer Ruzzier", "Schietende mensen", "actie"),
            new Boek("978-5-7035-4800-4", "Celestine Krista Lambert", "De bloedende brief", "horror"),
            new Boek("978-4-8534-7306-8", "Eilert Farid Holmström", "Pief paf poef", "actie"),
            new Boek("978-2-6563-0733-7", "Josip Suse Dane", "Simon Smith", "liefde"),
            new Boek("978-4-0801-2193-0", "Celestine Krista Lambert", "De nogsteeds bloedende brief", "horror"),
            new Boek("978-6-1872-7976-7", "Celestine Krista Lambert", "De uitgebloede brief", "horror"),
            new Boek("978-6-9930-6808-1", "Rokas Namrata Swampscare", "John en Emma", "liefde"),
            new Boek("978-5-0779-2126-7", "Ffraid Sylvianne Strudwick", "Het grote hart van John", "liefde"),
            new Boek("978-5-0779-2126-7", "Fred de grote", "Het grote hart van John", "liefde")
        }; 
    }
}
