using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ListeDeLivre.Models
{
    public class DataAcces
    {
        public static Confirmationlecture ChargerConfirmationLectureDepuisBDD(int id)
        {
            const string cheminBase = @"Server=.\sqlexpress;Initial Catalog = ListeLecture; Integrated Security = True";
            SqlConnection connection = new SqlConnection(cheminBase);



            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Titre,DateDeFin FROM Livre where IDlivre = @id", connection);

            command.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = command.ExecuteReader();

            datareader.Read();

            string titre = datareader.GetString(0);



            DateTime dateDeFin = datareader.GetDateTime(1);

            Confirmationlecture confirmationlecture = new Confirmationlecture(titre, dateDeFin);
            
            connection.Close();
            command.Parameters.Clear();
            return confirmationlecture;

        }



        public static DetailModel ListeDelivresenBDD(int id)
        {
            const string cheminBase = @"Server=.\sqlexpress;Initial Catalog = ListeLecture; Integrated Security = True";
            SqlConnection connection = new SqlConnection(cheminBase);



            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Titre, Auteur, Note, DateDebut, DateDeFin FROM Livre where IDlivre = @id", connection);
           
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader datareader = command.ExecuteReader();

            datareader.Read();

            string titre = datareader.GetString(0);

            string auteur = datareader.GetString(1);


            DateTime dateDebut = datareader.GetDateTime(3);
            DateTime? dateDeFin = datareader.IsDBNull(4) ? null : (DateTime?)datareader[4]; ;
            Byte? note = datareader.IsDBNull(2) ? null : (byte?)datareader[2];
            Livres livreCourant = new Livres(titre, auteur, dateDebut, dateDeFin,id, note);
            DetailModel detail = new DetailModel(livreCourant);

            connection.Close();
            command.Parameters.Clear();
            return detail;

        }



        public static void InsererLesLivresDansLaBDD(string Titre, string Auteur)
        {
            const string cheminBase = @"Server=.\sqlexpress;Initial Catalog = ListeLecture; Integrated Security = True";
            SqlConnection connection = new SqlConnection(cheminBase);
         


            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Livre(Titre, Auteur, DateDebut) VALUES (@Titre, @Auteur,getdate())", connection);

            command.Parameters.AddWithValue("@Titre", Titre);
            command.Parameters.AddWithValue("@Auteur", Auteur);
           command.ExecuteReader();

            connection.Close();
            command.Parameters.Clear();
            

        }
    }

}
