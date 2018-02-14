using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using Newtonsoft.Json;

namespace kinectreception
{
    class Program
    {
        //const string apiUrl = @"http://esaip.westeurope.cloudapp.azure.com:83/api/Requests";// le ":83" fait planter avec une erreur d'acces interdit au serveur
        //const string apiUrl = @"http://localhost:5000/api/Requests";//acces a l'application en local
        const string apiUrl = @"http://esaip.westeurope.cloudapp.azure.com:83/";//acces a l'application initial "ok ca marche !"

        static void Main(string[] args)
        {

            Console.WriteLine("Bonjour, vellez voter pour la question suivante...");
            //récup' demande, bouclage, chaque demande = vote, renvoi en bdd

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
