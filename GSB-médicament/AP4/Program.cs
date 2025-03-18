using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            int StockDoliprane = 0;
            int StockIbuprofene = 0;
            int StockEfferalgan = 0;
            int StockSpasfon = 0;

            // Méthode locale pour obtenir le nom du médicament en fonction du code
            string NomMedicament(char code)
            {
                if (code == 'D')
                {
                    return "Doliprane";
                }
                else if (code == 'I')
                {
                    return "Ibuprofene";
                }
                else if (code == 'E')
                {
                    return "Efferalgan";
                }
                else if (code == 'S')
                {
                    return "Spasfon";
                }
                else
                {
                    return "Inconnu";
                }
            }

            while (continuer)
            {
                Console.WriteLine("Menue Principale :");
                Console.WriteLine("1. Ajouter un médicament en stock(AV)");
                Console.WriteLine("2. Vendre un médicament(VM)");
                Console.WriteLine("3. Visualiser le stock des médicaments(VS)");
                Console.WriteLine("4. Quitter");
     

                string choix = Console.ReadLine();

                if (choix == "AV")
                {
                    Console.WriteLine("Entrer le code du médicament (D/I/E/S)  : ");
                    char code = Char.ToUpper(Console.ReadKey().KeyChar); //Lecture du code en majuscules
                    Console.WriteLine("\nEntrer la quantité à ajouter au stock");
                    int quantite;
                    if (int.TryParse(Console.ReadLine(), out quantite))

                    {
                        if (code == 'D')
                        {
                            StockDoliprane += quantite;
                        }
                        else if (code == 'I')
                        { 
                            StockIbuprofene += quantite;
                        }
                        else if (code == 'E')
                        {
                          StockEfferalgan += quantite;
                        }
                        else if (code == 'S')
                        {
                            StockSpasfon += quantite;
                        }
                        else
                        {
                            Console.WriteLine("Code de médicament invalide");
                        }

                        Console.WriteLine("Stock mis à jour");
                        Console.WriteLine($"Doliprane : {StockDoliprane}");
                        Console.WriteLine($"Ibuprofene : {StockIbuprofene}");
                        Console.WriteLine($"Efferalgan : {StockEfferalgan}");
                        Console.WriteLine($"Spasfon : {StockSpasfon}");
                    }
                    else
                    {
                        Console.WriteLine("Quantité invalide");
                    }
                }
                else if (choix == "VM")
                {
                    Console.WriteLine("Entrer le code du médicament à Vendre (D / I / E / S) :");
                    char code = Char.ToUpper (Console.ReadKey().KeyChar);
                    Console.WriteLine("Entrer la quantité à vendre");
                    int quantite;
                    if (int.TryParse(Console.ReadLine(), out quantite))
                        {

                        // Variable double utilisée pour stocker le prix unitaire du médicament
                        double prixUnitaire;
                        Console.WriteLine("Entrer le prix unitaire");


                        // Vérification si le prix unitaire est un nombre décimal (double)
                        if (double.TryParse(Console.ReadLine(), out prixUnitaire))
                            {   
                            double total = 0;


                            // Vérification du stock et traitement de la vente en fonction du code
                            if (code == 'D' && StockDoliprane >= quantite)
                            {
                                StockDoliprane -= quantite;
                                total = quantite * prixUnitaire;
                            }
                            else if (code == 'I' && StockIbuprofene >= quantite)
                            {
                                StockIbuprofene -= quantite;
                                total = quantite * prixUnitaire;
                            }
                            else if (code == 'E' && StockEfferalgan >= quantite)
                            {
                                StockEfferalgan -= quantite;
                                total = quantite * prixUnitaire;
                            }
                            else if (code == 'S' && StockSpasfon >= quantite)
                            {
                                StockSpasfon -= quantite;
                                total = quantite * prixUnitaire;
                            }
                            else
                            {
                                Console.WriteLine("Code de médicament invalide ou quantité insuffisante en stock");
                            }
                                // Affichage du total après la vente
                            if (total > 0)
                            {
                                Console.WriteLine($"Médicament : {NomMedicament(code)},Quantité: {quantite}, Prix unitaire: {prixUnitaire}, Total: {total}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Prix Unitaire invalide");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantité invalide");
                    }
                }
                else if (choix == "VS")
                {
                    // le $ permet d'afficher la variable 
                    Console.WriteLine("\nStock des médicaments :");
                    Console.WriteLine($"Doliprane : {StockDoliprane}");
                    Console.WriteLine($"Ibuprofene : {StockIbuprofene}");
                    Console.WriteLine($"Efferalgan : {StockEfferalgan}");
                    Console.WriteLine($"Spasfon : {StockSpasfon}");
                }
                else if (choix == "Quitter")
                {
                    continuer = false;
                }
                else
                {
                    Console.WriteLine("Choix Invalide");
                }

                Console.WriteLine("Voulez-vous effectuez une autre opération ? (O/N)");
                continuer = (Console.ReadLine().ToUpper() == "O");



            }

        }
        
    }
}
