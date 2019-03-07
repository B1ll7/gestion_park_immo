using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudedeCas
{
    class Program
    {
        static List<Realty> Realties = new List<Realty>();
        static void Main(string[] args)
        {
            // declaration de classe et initialisation du terminal.
            string userchoice;
            string terminalprint = "Menu de l'application" + "\n" + "\n" +
                "1 : Afficher la liste des biens " + "\n" +
                "2 : Ajouter un appartement " + "\n" +
                "3 : Ajouter une maison " + "\n" +
                "4 : Ajouter un parking " + "\n" +
                "5 : Supprimer un bien " + "\n" +
                "6 : Quitter l'application ";
            // Creation de l'etiquetage user qui permet le retour grace à la fonction goto
            user:
            int biens = Realties.Count;
            Console.WriteLine("Gestion du parc immobilier de l'agence \nLe stock immobilier de l'agence est, actuellement, de : " + biens);
            Console.WriteLine(terminalprint);
            // on enregistre le choix du user dans userchoise
            Console.WriteLine("Que souhaitez-vous faire ? : "); 
            userchoice = Console.ReadLine();
            if(userchoice != null)
            {
                while (userchoice != null)
                {
                    switch (userchoice)
                    {
                        case "1":
                            Console.Clear();
                            ToList();
                            goto user;
                        case "2":
                            Console.Clear();
                            ToAddFlat();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[SYSTEM] ");
                            Console.ResetColor();
                            Console.WriteLine("Le bien a été ajouter correctement");
                            goto user;
                        case "3":
                            Console.Clear();
                            ToAddHome();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[SYSTEM] ");
                            Console.ResetColor();
                            Console.WriteLine("Le bien a été ajouter correctement");
                            Console.Clear();
                            goto user;
                        case "4":
                            Console.Clear();
                            ToAddParking();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[SYSTEM] ");
                            Console.ResetColor();
                            Console.WriteLine("Le bien a été ajouter correctement");
                            goto user;
                        case "5":
                            Console.Clear();
                            ToDelete();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[SYSTEM] ");
                            Console.ResetColor();
                            Console.WriteLine("Le bien a été supprimer correctement");
                            goto user;
                        case "6":
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[SYSTEM] ");
                            Console.ResetColor();
                            Console.WriteLine("Valeur innattendue, veuillez rééssayez s'il vous plait !");
                            goto user;
                    }
                }
            }
            else
            {
                Console.WriteLine("Veuillez entrer une valeur s'il vous plait");
            }
            
        }
        // Declaration de la methode d'ajout d'appartement
        public static void ToAddFlat()
        {
            // initialisation des variables.
            int registerNumber;
            string location;
            int area;
            double rent;
            int rooms;
            int floor;
            // enregistrement des valeurs demandez au user.
            Console.WriteLine("RegisterNumber ?");
            registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("location");
            location = Console.ReadLine();
            Console.WriteLine("area");
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("rent");
            rent = double.Parse(Console.ReadLine());
            Console.WriteLine("rooms");
            rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("floor");
            floor = int.Parse(Console.ReadLine());

            Flat flat = new Flat(registerNumber, location, area, rent, rooms, floor);
            Realties.Add(flat);
        }
        // Declaration de la methode d'ajout de maison
        public static void ToAddHome()
        {
            // initialisation des variables.
            int registerNumber;
            string location;
            int area;
            double rent;
            int rooms;

            Console.WriteLine("RegisterNumber ?");
            registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("location");
            location = Console.ReadLine();
            Console.WriteLine("area");
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("rent");
            rent = double.Parse(Console.ReadLine());
            Console.WriteLine("rooms");
            rooms = int.Parse(Console.ReadLine());
            Home home = new Home(registerNumber, location, area, rent, rooms);
            Realties.Add(home);
        }
        // Declaration de la methode d'ajout de parking
        public static void ToAddParking()
        {
            // initialisation des variables.
            int registerNumber;
            string location;
            int area;
            double rent;
            // Question posé au client. 
            Console.WriteLine("RegisterNumber ?");
            registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("location");
            location = Console.ReadLine();
            Console.WriteLine("area");
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("rent");
            rent = double.Parse(Console.ReadLine());
            Parking parking = new Parking(registerNumber, location, area, rent);
            Realties.Add(parking);

        }
        // Declaration de la methode pour afficher la liste des Realties.
        public static void ToList()
        {
            if (Realties.ToArray().Length <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[SYSTEM] ");
                Console.ResetColor();
                Console.Write("Aucune données trouvée dans la liste.\n");
                Console.WriteLine();
            }
            else
            {
                foreach (Realty realty in Realties.ToArray())
                {
                    Console.WriteLine(realty + "\n\n");
                }
            }
         }
        // Declaration de la methode pour supprimer un Realty.
        public static void ToDelete()
        {
            // On enregistre le numero du bien à supprimer
            Console.WriteLine("numero du bien a supprimer ?");
            int idReal = int.Parse(Console.ReadLine());
            // on compare chacun des biens avec le numero enregistrer
            foreach (Realty element in Realties)
            {
                //si bien trouver on le supprime
                if (idReal == element.getRegisterNumber)
                {
                    Realties.Remove(element);
                }
                // sinon on affiche le message du bien introuvale
                else if (idReal != element.getRegisterNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[SYSTEM] ");
                    Console.ResetColor();
                    Console.WriteLine("Le bien est introuvable");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[SYSTEM] ");
                    Console.ResetColor();
                    Console.WriteLine("il y'a un soucis dans le code");
                }
            }
        }
    }
}
