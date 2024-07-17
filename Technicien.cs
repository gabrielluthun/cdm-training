using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_MCD
{
    internal class Technicien
    {

        public int Id_technicien;
        public string Nom;
        public string Prenom;
        public string VilleActivite;
        public int NumeroTelephone;


        public int _Id_technicien
        {
            get { return Id_technicien; }
            set { Id_technicien = value; }
        }
        public string _Nom
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string _Prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public string _VilleActivite
        {
            get { return VilleActivite; }
            set { VilleActivite = value; }
        }

        public int _NumeroTelephone
        {
            get { return NumeroTelephone; }
            set { NumeroTelephone = value; }
        }

        public Technicien(int idTechnicien, string nom, string prenom, string villeActivite, int numeroTelephone)
        {
            _Id_technicien = idTechnicien;
            Nom = nom;
            Prenom = prenom;
            VilleActivite = villeActivite;
            NumeroTelephone = numeroTelephone;
        }

        public static List<Technicien> _ListeTechnicien = new List<Technicien>();

        public static void AjouterTechnicien()
        {
            Console.WriteLine("Entrez l'ID du techicien :");
            int idTechnicien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nom du technicien : ");
            string nom = Console.ReadLine()!;
            Console.WriteLine("Entrez le prénom du technicien : ");
            string prenom = Console.ReadLine()!;
            Console.WriteLine("Entrez la ville d'activité du technicien : ");
            string villeActivite = Console.ReadLine()!;
            Console.WriteLine("Entrez le numéro de téléphone du technicien : ");
            int numeroTelephone = Convert.ToInt32(Console.ReadLine());

            _ListeTechnicien.Add(new Technicien(idTechnicien, nom, prenom, villeActivite, numeroTelephone));
        }

        public static void SupprimerTechnicien()
        {
            Console.Clear();

            Console.WriteLine("Entrez l'ID du technicien à supprimer : ");
            int idTechnicien = Convert.ToInt32(Console.ReadLine());
            _ListeTechnicien.RemoveAll(technicien => technicien.Id_technicien == idTechnicien);
            Console.WriteLine("Le technicien a bien été supprimé");
            Console.Clear();
        }

        public static bool ConsulterListeTechniciens()
        { 
            while (true) {

                Console.WriteLine("Liste des techniciens : \n");
                Console.WriteLine("ID : " + _ListeTechnicien[0].Id_technicien + "\n" +
                    "Nom : " + _ListeTechnicien[0].Nom + "\n" +
                    "Prénom : " + _ListeTechnicien[0].Prenom + "\n" +
                    "Ville d'activité : " + _ListeTechnicien[0].VilleActivite + "\n" +
                    "Numéro de téléphone : " + _ListeTechnicien[0].NumeroTelephone + "\n"
                );
                if (Console.ReadKey().Key == ConsoleKey.Escape) return false;
            }
        }
    }
}
