using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_MCD
{
    internal class Photocopieur
    {
        public int IDPhotocopieur;
        public string Modele;
        public string AnneeConstruction;
      
        public int _IDPhotocopieur
        {
            get { return IDPhotocopieur; }
            set { IDPhotocopieur = value; }
        }

        public string _Modele
        {
            get { return Modele; }
            set { Modele = value; }
        }

        public string _AnneeConstruction
        {
            get { return AnneeConstruction; }
            set { AnneeConstruction = value; }
        }

        public Photocopieur(int idDuPhotocopieur, string modelePhotocopieuse, string anneeConstruction)
        {
            IDPhotocopieur = idDuPhotocopieur;
            Modele = modelePhotocopieuse;
            AnneeConstruction = anneeConstruction;
        }

        public static List<Photocopieur> ListePhotocopieur = new List<Photocopieur>();

        public static void AjouterPhotocopieur()
        {
            Console.WriteLine("Entrez l'ID du photocopieur : ");
            int idDuPhotocopieur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le modèle de la photocopieuse : ");
            string modelePhotocopieuse = Console.ReadLine()!;
            Console.WriteLine("Entrez l'année de construction de la photocopieuse : ");
            string anneeConstruction = Console.ReadLine()!;
         
            ListePhotocopieur.Add(new Photocopieur(idDuPhotocopieur, modelePhotocopieuse, anneeConstruction));
        }

        public static void SupprimerPhotocopieur()
        {
            Console.WriteLine("Entrez l'ID du photocopieur à supprimer : ");
            int idDuPhotocopieur = Convert.ToInt32(Console.ReadLine());
            ListePhotocopieur.RemoveAll(photocopieur => photocopieur.IDPhotocopieur == idDuPhotocopieur);
        }

        public static bool ConsulterListePhotocopieurs()
        { while (true)
            {
                foreach (Photocopieur photocopieur in ListePhotocopieur)
                {
                    Console.WriteLine($"ID : {photocopieur.IDPhotocopieur} - Modèle : {photocopieur.Modele} - Année de construction : {photocopieur.AnneeConstruction}");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) return false;
            }
        }
    }
}
