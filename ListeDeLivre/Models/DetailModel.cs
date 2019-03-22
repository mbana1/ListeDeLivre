using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListeDeLivre.Models
{
    public class DetailModel
    {
        
        public string Titre { get; private set; }
        public string Auteur { get; private set; }
        public DateTime DateDebut { get; private set; }
        public DateTime? DateDeFin { get; private set; }
       

        public int ?Note { get; private set; }
        public DetailModel()
        {

        }
        public DetailModel(string titre, string auteur, DateTime dateDebut, DateTime? dateDeFin, int? note)
        {
            Titre = titre;
            Auteur = auteur;
            DateDebut = dateDebut;
            DateDeFin = dateDeFin;
            Note = note;
        }

    }
}