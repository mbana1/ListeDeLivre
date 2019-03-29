using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListeDeLivre.Models
{
    public class Livres
    {

        public string Titre { get; private set; }
        public string Auteur { get; private set; }
        public DateTime DateDebut { get; private set; }
        public DateTime? DateDeFin { get; private set; }
        public int id { get; private set; }

        public int? Note { get; private set; }
       
        public Livres(string titre, string auteur, DateTime dateDebut, DateTime? dateDeFin, int id, int? note)
        {
            Titre = titre;
            Auteur = auteur;
            DateDebut = dateDebut;
            DateDeFin = dateDeFin;
            this.id = id;
            Note = note;
        }
    }
}