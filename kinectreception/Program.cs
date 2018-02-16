using System;
using System.Net;

namespace kinectreception
{
    class Program
    {
        //const string apiUrl = @"http://esaip.westeurope.cloudapp.azure.com:83/api/Requests";// le ":83" fait planter avec une erreur d'acces interdit au serveur
        //const string apiUrl = @"http://localhost:5000/api/Requests";//acces a l'application en local
        const string apiUrl = @"http://esaip.westeurope.cloudapp.azure.com/";//acces a l'application initial "ok ca marche !"

        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez voter pour la question suivante : ");
            //récup' demande, bouclage, chaque demande = vote, renvoi en bdd à la base ; on est censé récupérer depuis le serveur, et afficher la question récupérée, mais la connexion est en accès refusé depuis le début des essaye...

            WebClient webClient = new WebClient();
            // Delete cach memory
            webClient.Headers["Cache-Control"] = "no-cache";
            webClient.Headers["Accept"] = "application/json";
            String result = null;
            //Request result = null;
            Request reqs = null;
            try
            {
                result = webClient.DownloadString(new Uri(apiUrl));
                Console.WriteLine(result);
                //reqs = JsonConvert.DeserializeObject<Request>(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Array listAnswers = reqs.answers.ToArray();
            //Console.WriteLine(reqs.answers.ToArray());
            //Console.WriteLine(listAnswers);
            Console.WriteLine(result);
        }
    }
}
