using Exercice_MCD;

static void MenuInteractif()
{
    Console.WriteLine("------- LOCATION DE PHOTOCOPIEURS -------");
    Console.WriteLine("1 : Ajouter un client");
    Console.WriteLine("2 : Supprimer un client");
    Console.WriteLine("------");
    Console.WriteLine("3 : Ajouter un technicien");
    Console.WriteLine("4 : Supprimer un technicien");
    Console.WriteLine("------");
    Console.WriteLine("5 : Ajouter un photocopieur");
    Console.WriteLine("6 : Supprimer un photocopieur");
    Console.WriteLine("------");
    Console.WriteLine("7 : Consulter la liste des clients");
    Console.WriteLine("8 : Consulter la liste des techniciens");
    Console.WriteLine("9 : Consulter la liste des photocopieurs");
    Console.WriteLine("10 : Quitter");
    Console.WriteLine("Choisissez une option : ");
    int choix = Convert.ToInt32(Console.ReadLine());
    switch (choix) {
        case 1:
            Console.Clear();
            ClientEntreprise.AjouterClient();
            MenuInteractif();
            break;
        case 2:
            Console.Clear();
            ClientEntreprise.SupprimerClient();
            MenuInteractif();
            break;
        case 3:
            Console.Clear();
            Technicien.AjouterTechnicien();
            MenuInteractif();
            break;
        case 4:
            Console.Clear();
            Technicien.SupprimerTechnicien();
            MenuInteractif();
            break;
        case 5:
            Console.Clear();
            Photocopieur.AjouterPhotocopieur();
            MenuInteractif();
            break;
        case 6:
            Console.Clear();
            Photocopieur.SupprimerPhotocopieur();
            MenuInteractif();
            break;
        case 7:
            Console.Clear();
            ClientEntreprise.ConsulterListeClients();
            MenuInteractif();
            break;
        case 8:
            Console.Clear();
            Technicien.ConsulterListeTechniciens();
            MenuInteractif();
            break;
        case 9:
            Console.Clear();
            Photocopieur.ConsulterListePhotocopieurs();
            MenuInteractif();
            break;
        case 10:
            QuitterMenu();
            break;
        default:
            Console.WriteLine("Choix invalide");
            break;
    }

    static void QuitterMenu()
    {
       Environment.Exit(0);
    }
}

MenuInteractif();