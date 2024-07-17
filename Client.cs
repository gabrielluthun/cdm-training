using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_MCD
{
    internal class ClientEntreprise
    {
        public int IDClient;
        public string NomClient;
        public string PrenomClient;
        public int NumeroAdresse;
        public string RueAdresse;
        public string VilleAdresse;
        public int NumeroDepartement;
        public string NumeroTelephone;

        public int _IDClient
        {
            get { return IDClient; }
            set { IDClient = value; }
        }

        public string _NomClient
        {
            get { return NomClient; }
            set { NomClient = value; }
        }

        public string _PrenomClient
        {
            get { return PrenomClient; }
            set { PrenomClient = value; }
        }

        public int _NumeroAdresse
        {
            get { return NumeroAdresse; }
            set { NumeroAdresse = value; }
        }

        public string _RueAdresse
        {
            get { return RueAdresse; }
            set { RueAdresse = value; }
        }

        public string _VilleAdresse
        {
            get { return VilleAdresse; }
            set { VilleAdresse = value; }
        }

        public int _NumeroDepartement
        {
            get { return NumeroDepartement; }
            set { NumeroDepartement = value; }
        }

        public string _NumeroTelephone
        {
            get { return NumeroTelephone; }
            set { NumeroTelephone = value; }
        }

        public ClientEntreprise(int idDuClient, string nomDuClient, string prenomDuClient, int numeroAdresse, string rueAdresse, string villeAdresse, int numeroDepartement, string numeroDeTelephone)
        {
            IDClient = idDuClient;
            NomClient = nomDuClient;
            PrenomClient = prenomDuClient;
            NumeroAdresse = numeroAdresse;
            RueAdresse = rueAdresse;
            VilleAdresse = villeAdresse;
            NumeroDepartement = numeroDepartement;
            NumeroTelephone = numeroDeTelephone;
        }

        public static List<ClientEntreprise> ListeClients = new List<ClientEntreprise>();
        #region Méthodes
        public static void AjouterClient()
        {
            Console.Clear();

            Console.WriteLine("Veuillez entrer l'ID du client");
            int idClient = Convert.ToInt32(Console.ReadLine());
            VerificationsID(idClient);

            Console.WriteLine("Veuillez entrer le nom du client");
            string nomClient = Console.ReadLine()!;

            Console.WriteLine("Veuillez entrer le prénom du client");
            string prenomClient = Console.ReadLine()!;
            Console.WriteLine("Veuillez entrer le numéro de l'adresse du client");
            int numeroAdresse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuillez entrer la rue de l'adresse du client");
            string rueAdresse = Console.ReadLine()!;
            Console.WriteLine("Veuillez entrer la ville de l'adresse du client");
            string villeAdresse = Console.ReadLine()!;
            Console.WriteLine("Veuillez entrer son département :");
            int numeroDepartement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le numéro de téléphone du client");
            string numeroTelephone = Console.ReadLine()!;

            ListeClients.Add(new ClientEntreprise(idClient, nomClient, prenomClient, numeroAdresse, rueAdresse, villeAdresse, numeroDepartement, numeroTelephone));
        }

        public static void SupprimerClient()
        {
            Console.WriteLine("Veuillez entrer l'ID du client à supprimer");
            int idClient = Convert.ToInt32(Console.ReadLine());
            ListeClients.RemoveAll(client => client.IDClient == idClient);

            Console.WriteLine("Client supprimé");
        }
        public static bool ConsulterListeClients()
        {
            //On met un booléen car le retour menu via la méthode MenuInteractif() ne fonctionne pas
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Liste des clients : ");
                foreach (ClientEntreprise client in ListeClients)
                {
                    Console.WriteLine($"ID : {client.IDClient} - Nom : {client.NomClient} - Prénom : {client.PrenomClient} - Adresse : {client.NumeroAdresse} {client.RueAdresse} {client.VilleAdresse} - Département : {client.NumeroDepartement} - Téléphone : {client.NumeroTelephone}");
                }

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return false;
                }
               
            }
           
        }
        #endregion

        #region Verifications Client
        public static void VerificationsID(int idClient)
        {
            if (ListeClients.Any(client => client.IDClient == idClient))
            {
                Console.WriteLine("Un client avec cet ID existe déjà");
                return;
            }
            else if (idClient < 0)
            {
                Console.WriteLine("L'ID du client doit être positif");
                return;
            }
            else if (idClient == 0)
            {
                Console.WriteLine("L'ID du client ne peut pas être nul");
                return;
            }
            else if (idClient.GetType() != typeof(int))
            {
                Console.WriteLine("L'ID du client doit être un entier");
                return;
            }
        }
        #endregion
    }
    
}
