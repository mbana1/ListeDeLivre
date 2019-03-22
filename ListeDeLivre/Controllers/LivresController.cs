using ListeDeLivre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace ListeDeLivre.Controllers
{
    public class LivresController : Controller
    {
        // GET: Livres
        public ActionResult EcranAccueil()
        {

            return View();
        }
        public ActionResult EcranDetail(int id)
        {

            return View(ListeDelivresenBDD(id));
        }
        public ActionResult ConfirmationDeLecture()
        {
            return View();
        }

        public ActionResult ConfirmationNotation()
        {
            return View();
        }
        public DetailModel ListeDelivresenBDD(int id)
        {
            const string cheminBase = @"Server=.\sqlexpress;Initial Catalog = ListeLecture; Integrated Security = True";
            SqlConnection connection = new SqlConnection(cheminBase);



            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Titre,Auteur,Note,DateDebut,DateDeFin FROM Livre where IDlivre=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = command.ExecuteReader();

            datareader.Read();

            string titre = datareader.GetString(0);

            string auteur = datareader.GetString(1);

            DateTime dateDebut = datareader.GetDateTime(3);
            DateTime? dateDeFin = datareader.IsDBNull(4)?null: (DateTime?)datareader[4]; ;
            Byte? note = datareader.IsDBNull(2) ? null : (byte?)datareader[2];
            DetailModel detail = new DetailModel(titre, auteur, dateDebut, dateDeFin, note);






            connection.Close();
            command.Parameters.Clear();
            return detail;

        }
    }


}