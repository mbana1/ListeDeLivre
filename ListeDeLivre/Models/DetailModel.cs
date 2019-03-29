using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListeDeLivre.Models
{
    public class DetailModel
    {
      public Livres Livrecourant { get; private set; }

        public DetailModel(Livres livrecourant)
        {
            Livrecourant = livrecourant;
        }
    }
}