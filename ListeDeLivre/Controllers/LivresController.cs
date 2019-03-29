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
            DetailModel model = DataAcces.ListeDelivresenBDD(id);


            return View(model);
           
        }
        public ActionResult ConfirmationDeLecture(int id)
        {

            Confirmationlecture confirmationlecture = DataAcces.ChargerConfirmationLectureDepuisBDD(id);



            return View();
        }

        public ActionResult ConfirmationNotation()
        {
            return View();
        }
        public ActionResult CreerUnLivre()
        {
            return View();
        }
        public ActionResult SubmitCreationLivre(string Titre, string Auteur)
        {
            DataAcces.InsererLesLivresDansLaBDD(Titre, Auteur);
            return RedirectToAction("ConfirmationDeCreation");

            
        }
        public ActionResult ConfirmationDeCreation()
        {
            return View();
        }
    }
}