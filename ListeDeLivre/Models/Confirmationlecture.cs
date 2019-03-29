using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListeDeLivre.Models
{
    public class Confirmationlecture
    {
        public string Titre { get; private set; }
        public DateTime DateFinDeLecture { get; private set; }

        public Confirmationlecture(string titre, DateTime dateFinDeLecture)
        {
            Titre = titre;
            DateFinDeLecture = dateFinDeLecture;
        }
    }

}