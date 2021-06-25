using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercices\n");
            int choix = 0;
            do
            {
                choix = Exo2GetInt("Entrez un nombre pour choisir un exo (1-31 et 36-48 et 60-61 300 bonus) et -1 pour quitter");
                switch (choix)
                {
                    case 1: Exo1(); break;
                    case 2: Console.WriteLine(Exo2GetString()); break;
                    case 3: Exo3(); break;
                    case 4: Exo4(); break;
                    case 5: Exo5(); break;
                    case 6: Exo6(); break;
                    case 7: Exo7(); break;
                    case 8: Exo8(); break;
                    case 9: Exo9(); break;
                    case 10: Exo10(); break;
                    case 11: Exo11(); break;
                    case 12: Exo12(); break;
                    case 13: Exo13(); break;
                    case 14: Exo14(); break;
                    case 15: Exo15(); break;
                    case 16: Exo16(); break;
                    case 17: Exo17(); break;
                    case 18: Exo18(); break;
                    case 19: Exo19(); break;
                    case 20: Exo20(); break;
                    case 21: Exo21(); break;
                    case 22: Exo22(); break;
                    case 23: Exo23(); break;
                    case 24: Exo24(); break;
                    case 25: Exo25(); break;
                    case 26: Exo26(); break;
                    case 27: Exo27(); break;
                    case 28: Exo28(); break;
                    case 29: Exo29(); break;
                    case 30: Exo30(); break;
                    case 31: Exo31(); break;
                    case 36: Exo36(); break;
                    case 37: Exo36itra(); break;
                    case 38: Exo38(); break;
                    case 39: Exo39(); break;
                    case 40: Exo40(); break;
                    case 41: Exo41(); break;
                    case 42: Exo42(); break;
                    case 43: Exo43(); break;
                    case 44: Exo44Bonus(); break;
                    case 45: Exo45(); break;
                    case 46: Exo46(); break;
                    case 47: Exo47(); break;
                    case 48: Exo48(); break;
                    case 60: Exo60(); break; 
                    case 61: Exo61(); break;
                    case 62: testeclasse(); break;
                    case 300: Exo300(); break;
                    case -1: Console.WriteLine("À bientôt "); ; break;
                    default:
                        Console.WriteLine("Erreur !");
                        break;
                }
            } while (choix != -1);


        }

        static void Exo1()
        {
            Console.WriteLine("Hello\nWorld");
        }

        static string Exo2GetString(String Libelle = "Entrez la valeur")
        {
            Console.WriteLine(Libelle);
            string data = Console.ReadLine();
            return data;
        }

        static int Exo2GetInt(String Libelle = "Entrez un nombre")
        {

            string data = Exo2GetString(Libelle);
            int intdata;
            if (int.TryParse(data, out intdata))
                return intdata;
            else
                return -2;
        }

        static void Exo3()
        {
            Console.WriteLine("Exo3 Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie");
            string[] tabmots = new string[3];
            for (int i = 0; i <= 2; i++)
            {
                tabmots[i] = Exo2GetString();
            }
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(tabmots[i]);
            }
        }

        static void Exo4()
        {
            Console.WriteLine("Exo4 Affichez si les 2 nombres rentré par l’utilisateur sont égaux");
            int nbA, nbB;
            nbA = Exo2GetInt();
            nbB = Exo2GetInt();
            if (nbA == nbB)
                Console.WriteLine("Egaux");
            else
                Console.WriteLine("Différent");
        }

        static void Exo5()
        {
            Console.WriteLine("Exo5 Créez 2 nombres, les afficher, les intervertir et les réafficher");
            int nbA, nbB, nbstock;
            nbA = Exo2GetInt();
            nbB = Exo2GetInt();
            Console.WriteLine(nbA + " => " + nbB);
            //J ai pas bien compris la consigne, l'echange sera juste visuel avec Console.WriteLine(nbB+" => "+ nbA); donc 
            nbstock = nbA;
            nbA = nbB;
            nbB = nbstock;
            Console.WriteLine(nbA + " => " + nbB);
        }

        static void Exo6()
        {
            Console.WriteLine("Exo6 Affichez le résultat de l’ajout, la soustraction, la multiplication et la division de 2 nombres rentrés par l’utilisateur");
            int nbA, nbB;
            nbA = Exo2GetInt();
            nbB = Exo2GetInt();
            Console.WriteLine(nbA + " + " + nbB + " => " + (nbA + nbB));
            Console.WriteLine(nbA + " - " + nbB + " => " + (nbA - nbB));
            Console.WriteLine(nbA + " X " + nbB + " => " + (nbA * nbB));
            Console.WriteLine(nbA + " / " + nbB + " => " + (nbA / nbB));
        }

        static void Exo7()
        {
            Console.WriteLine("Exo7 Affichez la moyenne de 4 nombres rentrés par l’utilisateur");
            int nbA, nbB, nbC, nbD;
            nbA = Exo2GetInt();
            nbB = Exo2GetInt();
            nbC = Exo2GetInt();
            nbD = Exo2GetInt();
            double total = (double)(nbA + nbB + nbC + nbD) / 4;
            Console.WriteLine(total);

        }

        static void Exo8()
        {
            Console.WriteLine("Exo8 Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur");
            int[] nb = new int[5];
            for (int i = 0; i < 4; i++)
            {
                nb[i] = Exo2GetInt();
            }
            int max = 0;
            for (int i = 0; i < 4; i++)
            {
                if (max < nb[i])
                    max = nb[i];
            }
            Console.WriteLine(max);
        }

        static void Exo9()
        {
            Console.WriteLine("Exo9 Savoir si le nombre rentré est négatif ou positif");
            int nb;
            nb = Exo2GetInt();
            if (nb >= 0)
                Console.WriteLine("positif");
            else
                Console.WriteLine("négatif");
        }

        static void Exo10()
        {
            Console.WriteLine("Exo10 Savoir si le nombre donné est pair ou impair");
            int nb, modulo;
            nb = Exo2GetInt();
            modulo = nb % 2;
            if (modulo == 0)
                Console.WriteLine("pair");
            else
                Console.WriteLine("impair");

        }

        static void Exo11()
        {
            Console.WriteLine("Exo11 Rentrez un nombre en Celsius et le convertir en Kelvin et Fahrenheit");

            int celsius;
            double kelvin, fahrenheit;

            celsius = Exo2GetInt();
            kelvin = (double)celsius + 273.15;
            //si je fais le calcule sur une seule ligne je n'arrive pas à obtenir pour 24 cel => 75(.2) fah 
            fahrenheit = (double)(celsius * 9);
            fahrenheit = (fahrenheit / 5) + 32;

            Console.WriteLine("celsius :" + celsius);
            Console.WriteLine("kelvin : " + kelvin);
            Console.WriteLine("fahrenheit : " + fahrenheit);
        }

        static void Exo12()
        {
            Console.WriteLine("Exo12 Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte");

            int nb;

            nb = Exo2GetInt();

            switch (nb)
            {
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimanche");
                    break;
                default:
                    Console.WriteLine("Erreur !");
                    break;
            }

        }

        static void Exo13()
        {
            Console.WriteLine("Exo13 Bloquez un utilisateur après avoir rentré 3 faux password");

            String password;
            int nbincorrect = 0;

            for (int i = 0; i < 3; i++)
            {
                password = Exo2GetString("Rentrez votre mot de passe");
                if (password == "password2021")
                {
                    Console.WriteLine("connecté");
                    break;
                }
                else
                {

                    nbincorrect++;
                    Console.WriteLine("mot de passe incorrect" + nbincorrect);
                }
            }
            if (nbincorrect >= 3)
                Console.WriteLine("Compte bloqué !");
        }

        static void Exo14()
        {
            Console.WriteLine("Exo14 Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre, affichez ensuite le résultat");

            int nbA, nbB;
            String signe;

            nbA = Exo2GetInt("Rentrez nombre A");
            signe = Exo2GetString("Rentrez le signe (+,-,*,/)");
            nbB = Exo2GetInt("Rentrez nombre B");

            switch (signe)
            {
                case "+":
                    Console.WriteLine(nbA + " + " + nbB + " = " + (nbA + nbB));
                    break;
                case "-":
                    Console.WriteLine(nbA + " - " + nbB + " = " + (nbA - nbB));
                    break;
                case "*":
                    Console.WriteLine(nbA + " X " + nbB + " = " + (nbA * nbB));
                    break;
                case "/":
                    Console.WriteLine(nbA + " / " + nbB + " = " + (nbA / nbB));
                    break;
                default:
                    Console.WriteLine("Erreur !");
                    break;
            }
        }

        static void Exo15()
        {
            Console.WriteLine("Exo15 Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void Exo16()
        {
            Console.WriteLine("Exo16 Donnez la table de multiplication des 10 premiers chiffres");

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.WriteLine(new StringBuilder(i + " X " + j + " = " + i * j));
                }

            }

        }

        static void Exo17()
        {
            Console.WriteLine("Exo17 Rentrez une lettre et une taille et l’afficher sous forme de triangle");
            int nb;
            String lettre, stock;


            lettre = Exo2GetString("Rentrez une lettre");
            nb = Exo2GetInt("Rentrez un nombre");


            for (int i = 0; i < nb; i++)
            {
                stock = "";
                for (int j = 1; j <= nb - i; j++)
                {
                    stock += lettre;
                }
                Console.WriteLine(stock);
            }

        }

        static void Exo18()
        {
            Console.WriteLine("Exo18 Faire une pyramide d’une hauteur donnée");
            int nb;
            String lettre, stock;


            lettre = Exo2GetString("Rentrez une lettre");
            nb = Exo2GetInt("Rentrez un nombre");


            for (int i = 1; i <= nb; i++)
            {
                stock = "";
                for (int j = 1; j <= nb; j++)
                {
                    if (nb - i >= j)
                        stock += " ";
                    else
                    {
                        stock += lettre + " ";
                    }

                }
                Console.WriteLine(stock);
            }

        }

        static void Exo19()
        {
            Console.WriteLine("Exo19 Faire un diamant d’une hauteur donnée");
            int nb;
            String lettre, stock;

            nb = Exo2GetInt("Rentrez un nombre");
            lettre = "*";

            for (int i = 0; i <= nb; i++)
            {
                stock = "";
                for (int j = 0; j < nb + i; j++)
                {
                    if (nb - i >= j)
                        stock += " ";
                    else
                    {
                        stock += lettre;
                    }

                }
                Console.WriteLine(stock);
            }
            //construire l'autre coté
            for (int i = nb - 1; i >= 1; i--)
            {
                stock = "";
                for (int j = 0; j < nb + i; j++)
                {
                    if (nb - i >= j)
                        stock += " ";
                    else
                    {
                        stock += lettre;
                    }

                }
                Console.WriteLine(stock);
            }

        }

        static void Exo20()
        {
            Console.WriteLine("Exo20 Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année)");

            DateTime localDate = DateTime.Now;

            Console.WriteLine(localDate.ToString());
            Console.WriteLine(localDate.ToString("dd/MM/yyyy"));

        }

        static void Exo21()
        {
            Console.WriteLine("Exo21 Créer une date avec l’utilisateur qui rentre l’année, mois, jour, heure, minute et seconde et afficher le jour(Lundi, mardi...) | en français ou en anglais");
            int jour, mois, annee, heure, minute, seconde;

            jour = Exo2GetInt("Rentrez le jour");
            mois = Exo2GetInt("Rentrez le mois");
            annee = Exo2GetInt("Rentrez l'année");
            heure = Exo2GetInt("Rentrez l'heure");
            minute = Exo2GetInt("Rentrez les minutes");
            seconde = Exo2GetInt("Rentrez les secondes");

            var localDate = new DateTime(annee, mois, jour, heure, minute, seconde);

            Console.WriteLine(localDate.ToString("dddd"));

        }

        static void Exo22()
        {
            Console.WriteLine("Exo22 Affichez la différence de temps entre 2 dates");
            DateTime EndDate = DateTime.Now;
            var StartDate = new DateTime(2021, 04, 12, 14, 12, 0);

            Console.WriteLine("" + (int)(EndDate - StartDate).TotalDays);

        }

        static void Exo23()
        {
            Console.WriteLine("Exo23 Convertir une chaine de caractère en date");

            var cultureInfo = new CultureInfo("fr-FR");
            string dateString = Exo2GetString();
            var dateTime = DateTime.Parse(dateString, cultureInfo);
            Console.WriteLine(dateTime.ToString("dddd dd MMMM yyyy"));

        }

        static void Exo24()
        {
            Console.WriteLine("Exo24 Jeu du plus ou moins, entre 1 et 10");

            Random rnd = new Random();
            int randnb = rnd.Next(1, 11);
            Console.WriteLine(randnb);
            int nb = 0;
            while (nb != randnb)
            {
                nb = Exo2GetInt("Rentrez un chiffre");
                if (nb > randnb)
                    Console.WriteLine("-");
                else if (nb < randnb)
                    Console.WriteLine("+");
                else if (nb == randnb)
                    Console.WriteLine("Bravo !!!");
                else
                    Console.WriteLine("Rentrez un chiffre entre 1 et 10");
            }

        }

        static void Exo25()
        {
            Console.WriteLine("Exo25 Affichez une chaine donnée en majuscule");

            String text = Exo2GetString();
            Console.WriteLine(text.ToUpper());

        }

        static void Exo26()
        {
            Console.WriteLine("Exo26 Affichez le nombre de caractère d’une chaine sans utiliser la propriété Length");

            String text = Exo2GetString();
            int nbcaractere = 0;
            foreach (var item in text)
            {
                nbcaractere++;

            }
            Console.WriteLine(nbcaractere);
        }

        static void Exo27()
        {
            Console.WriteLine("Exo27 Affichez un espace entre toute les lettres d’une chaine de caractère donnée en inversant les lettres");

            String text = Exo2GetString();
            var newtext = new StringBuilder();
            for (int i = text.Length; i > 0; i--)
            {
                newtext.Append(text[i - 1] + " ");
            }
            Console.WriteLine(newtext);
        }

        static void Exo28()
        {
            Console.WriteLine("Exo28 Dire si une chaine est égale à une autre sans prendre en compte la casse");

            String textA = Exo2GetString("Entrez le texte A");
            String textB = Exo2GetString("Entrez le texte B");
            if (textA.Equals(textB, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("égales");
            else
                Console.WriteLine("différentes");
        }

        static void Exo29()
        {
            Console.WriteLine("Exo29 Savoir si la chaine donnée est un palindrome (mot qui se lit dans les deux sens : SOS)");

            String text = Exo2GetString();
            String newtext = "";
            for (int i = text.Length; i > 0; i--)
            {
                newtext += text[i - 1];
            }
            if (text == newtext)
                Console.WriteLine("le mot est un palindrome");
            else
                Console.WriteLine("le mot n'est un palindrome");
        }

        static void Exo30()
        {
            Console.WriteLine("Exo30 Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines conditions");

            int nbchiffre = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                else
                {
                    Console.Write(" " + i + " ");
                }
                nbchiffre++;
                if (nbchiffre == 10)
                {
                    nbchiffre = 0;
                    Console.WriteLine();
                }
            }

        }


        static void Exo300()
        {
            Console.WriteLine("Le jeu du morpion");
            string[,] map = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            int coordonneeA, coordonneeB, winner = 3;
            bool erreursaisie = false;
            Console.Clear();
            getMapMorpion(map);

            while (winner == 3)
            {

                //joueur 1*************************
                do
                {
                    coordonneeA = Exo2GetInt("joueur 1 = X : entrez les coordonnées, ligne et colonne ex: 00 ou 12");
                    erreursaisie = setMapMorpion(ref map, coordonneeA, "X");
                } while (erreursaisie == true);

                Console.Clear();
                getMapMorpion(map);
                winner = checkWinnerMorpion(map);
                if (winner != 3)
                    break;


                //joueur 2*************************
                do
                {
                    coordonneeB = Exo2GetInt("joueur 2 = O : entrez les coordonnées, ligne et colonne ex: 00 ou 12");
                    erreursaisie = setMapMorpion(ref map, coordonneeB, "O");
                } while (erreursaisie == true);

                Console.Clear();
                getMapMorpion(map);
                winner = checkWinnerMorpion(map);
                if (winner != 3)
                    break;


            }
            if (winner == 4)
                Console.WriteLine("égalité ");
            else
                Console.WriteLine("le Winner est le joueur " + winner);
        }

        static void getMapMorpion(string[,] map)
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 3; j++)
                {
                    // Console.Write("i "+i+" j "+j+" map "+map[i,j]);

                    Console.Write("|" + map[i, j]);
                }
                Console.WriteLine("|");
            }
        }

        static bool setMapMorpion(ref string[,] map, int coordonnee, string lettre)
        {
            bool erreur = false;
            switch (coordonnee)
            {
                case 00:
                    if (map[0, 0] == " ")
                        map[0, 0] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 01:
                    if (map[0, 1] == " ")
                        map[0, 1] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 02:
                    if (map[0, 2] == " ")
                        map[0, 2] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 10:
                    if (map[1, 0] == " ")
                        map[1, 0] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 11:
                    if (map[1, 1] == " ")
                        map[1, 1] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 12:
                    if (map[1, 2] == " ")
                        map[1, 2] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;
                case 20:
                    if (map[2, 0] == " ")
                        map[2, 0] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;

                case 21:
                    if (map[2, 1] == " ")
                        map[2, 1] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;
                case 22:
                    if (map[2, 2] == " ")
                        map[2, 2] = lettre;
                    else
                    {
                        erreur = true;
                        Console.WriteLine("Oups");
                    }
                    break;
                default:
                    erreur = true;
                    Console.WriteLine("Erreur ex : 00 ou 01 ou 02 ou 10 ou 11");
                    break;
            }
            return erreur;
        }

        static int checkWinnerMorpion(string[,] map)
        {
            // 1 joueur 1 winner, 2 joueur 2 winner 3 pas encore de winner 4 égalité
            int statut = 3, nbcase = 0;

            for (int i = 0; i < 3; i++)
            {
                //cette conditon est pour verifier et trouver si il y a un winner en ligne 
                if (map[i, 0] == map[i, 1] && map[i, 1] == map[i, 2])
                {
                    switch (map[i, 0])
                    {
                        case "X": statut = 1; break;
                        case "O": statut = 2; break;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    //cette conditon est pour verifier et trouver si il y a un winner en colonne 
                    if (map[0, j] == map[1, j] && map[1, j] == map[2, j])
                    {
                        switch (map[0, j])
                        {
                            case "X": statut = 1; break;
                            case "O": statut = 2; break;
                        }
                    }
                    //cette condition est pour verifier si il ya des cases vides
                    if (map[i, j] == " ")
                        nbcase++;

                }


            }
            //cette conditon est pour verifier et trouver si il y a un winner en diagonale
            if (map[0, 0] == map[1, 1] && map[2, 2] == map[1, 1])
            {
                switch (map[0, 0])
                {
                    case "X": statut = 1; break;
                    case "O": statut = 2; break;
                }
            }
            //cette conditon est pour verifier et trouver si il y a un winner en diagonale
            if (map[0, 2] == map[1, 1] && map[2, 0] == map[1, 1])
            {
                switch (map[0, 2])
                {
                    case "X": statut = 1; break;
                    case "O": statut = 2; break;
                }
            }

            //cette condition est pour verifier si il ya des cases vides et changer le statut car c est peut etre egalité
            if (statut == 3 && nbcase == 0)
                statut = 4;

            return statut;
        }

        static void Exo31()
        {
            Personne perso = new Personne();
            DateTime dateBirth;
            perso.FirstName = Exo2GetString("Entrez le Prénom");
            perso.Name = Exo2GetString("Entrez le nom");

            if (DateTime.TryParse(Exo2GetString("Entrez la date de naissance"), out dateBirth))
                perso.DateBirth = dateBirth;

            //perso.MajPrenom(); exo 32
            Console.WriteLine("perso 1***********");
            Console.WriteLine(perso);


            //exo 34
            Personne perso2 = perso;

            Console.WriteLine("perso 2***************");
            Console.WriteLine(perso2);


            perso2.MajPrenom();

            Console.WriteLine("perso 2**************");
            Console.WriteLine(perso2);


            Console.WriteLine("perso 1************");
            Console.WriteLine(perso);
            Console.WriteLine(Personne.Test);

        }

        static void Exo36()
        {
            Personne[] personnes = { new Personne(), new Personne(), new Employe(), new Employe() };

            foreach (Personne perso in personnes)
            {
                Console.WriteLine(perso.Afficher());
            }
        }
        static void Exo36itra()//37 Faire le même test avec un tableau de 4 ITravailleur.
        {
            ITravailleur[] personnes = { new Personne(), new Personne(), new Employe(), new Employe() };

            foreach (var perso in personnes)
            {
                Console.WriteLine(perso.Afficher());
            }
        }

        static void Exo38()//Créez un tableau d’entier, trier le tableau et afficher tous les nombres dans l’ordre
        {
            List<int> entier = new List<int>() { 9, 8, 7, 4, 5, 6, 1, 2, 3 };
            entier.Sort();
            foreach (var item in entier)
            {
                Console.WriteLine(item);
            }
        }

        static void Exo39()//Affichez une liste de string par ordre alphabétique
        {
            List<string> entier = new List<string>() { "zzz", "eeee", "rrr", "tttt", "yy", "uu", "iii", "ooo", "jjj" };
            entier.Sort();
            foreach (var item in entier)
            {
                Console.WriteLine(item);
            }
        }

        static void Exo40()//Afficher une liste de personne
        {
            List<Personne> entier = new List<Personne>() { new Personne(), new Personne() };
            entier.Add(new Personne("ethio", "nico", DateTime.Now));
            //entier.Sort();
            foreach (var item in entier)
            {
                Console.WriteLine(item);
            }
        }

        static void Exo41()//Afficher un dictionnaire de personne avec un entier Id en clé
        {
            Dictionary<int, Personne> entier = new Dictionary<int, Personne>() { { 1, new Personne() }, { 2, new Personne() } };
            entier.Add(3, new Personne("ethio", "nico", DateTime.Now));
            //entier.Sort();
            foreach (KeyValuePair<int, Personne> item in entier)
            {
                Console.WriteLine(item);
            }
        }

        static void Exo42()//Tester le Contains avec le Equals et IEquatable sur une liste de personnes
        {
            List<Personne> listperso = new List<Personne>() { new Personne() };
            Personne perso = new Personne();

            if (listperso.Contains(perso))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }

        static void Exo43()//Trier la liste de personne avec IComparable puis IComparer sur le nom puis le prénom
        {
            List<Personne> listperso = new List<Personne>() { new Personne() };
            listperso.Add(new Personne("AAA", "BBB", DateTime.Now));
            listperso.Add(new Personne("zzz", "yyy", DateTime.Now));
            listperso.Add(new Personne("zzz", "aaa", DateTime.Now));

            listperso.Sort(new TriPersonne());
            foreach (var item in listperso)
            {
                Console.WriteLine(item);
            }
        }

        static void Exo44Bonus()//Trier la liste de personne avec IComparable puis IComparer sur le nom puis le prénom, jai pas fini
        {
            Queue<Personne> listperso = new Queue<Personne>();
            listperso.Enqueue(new Personne("AAA", "BBB", DateTime.Now));
            listperso.Enqueue(new Personne("zzz", "yyy", DateTime.Now));
            listperso.Enqueue(new Personne("zzz", "aaa", DateTime.Now));


            for (int i = 0; i < listperso.Count + 1; i++)
            {
                Console.WriteLine(listperso.Dequeue());
            }

        }

        static void Exo45()//linq Afficher la somme
        {
            List<int> entiers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int somme = entiers.Sum();
            double moyen = entiers.Average();
            Console.WriteLine($"Question 1 et 2 \nSomme = {somme} Moyen = {moyen}");

            var entiersSup6 = entiers.Where(e => e > 6);
            Console.WriteLine($"Question 3");
            Console.WriteLine(string.Join("\n", entiersSup6));
            Console.WriteLine($"Question 4 \n nb = {entiersSup6.Count()}");
        }

        static void Exo46()//linq Sur une liste de personne 
        {
            List<Personne> personnes = SampleDatas.GetSamplePersonnes();
            var personnesOrder = personnes.OrderBy(p => p.Name).ThenBy(p => p.FirstName);
            Console.WriteLine(string.Join("\n", personnesOrder));
            Console.WriteLine("****************");

            //6. Afficher que les personnes qui ont leurs noms qui commence par D
            var personnesComD = personnes.Where(p => p.Name.StartsWith("D"));
            Console.WriteLine(string.Join("\n", personnesComD));
            Console.WriteLine("****************");

            //7. Afficher que les noms des personnes
            var personneNom = personnes.OrderBy(p => p.Name).Select(p => new { Nom = p.Name }).ToList();
            foreach (var pnom in personneNom)
            {
                Console.WriteLine(pnom.Nom);
            }
            //Console.WriteLine(string.Join("\n",personneNom[].Nomm));
            Console.WriteLine("****************");
            //8. Afficher le nom en majuscule et le prénom des personnes trié par ordre descendant sur le prénom dont leurs noms commence par D
            var personnequestion8 = personnes.Where(p => p.Name.StartsWith("D")).OrderByDescending(p => p.FirstName).Select(p => new { Nom = p.Name.ToUpper(), FirstName = p.FirstName }).ToList();
            foreach (var p in personnequestion8)
            {
                Console.WriteLine(p.Nom + " " + p.FirstName);
            }

            //9. Récupérer que les 2 première personne
            Console.WriteLine("****************");
            var personnequestion9 = personnes.Take(2).ToList();
            Console.WriteLine(string.Join("\n", personnequestion9));

            //10. Récupérer les personnes rentrées en 7ème 8ème et 9ème position
            Console.WriteLine("****************");
            var personnequestion10 = personnes.Skip(6).Take(3).ToList();
            Console.WriteLine(string.Join("\n", personnequestion10));

            //11. Récupérer la personne qui a le nom Dupont
            Console.WriteLine("****************");
            var personnequestion11 = personnes.FirstOrDefault(p => p.FirstName == "Dupont");
            Console.WriteLine(string.Join("\n", personnequestion11));

            //12. Savoir si notre liste contient une personne dont le nom commence par D
            Console.WriteLine("**************** 12");
            var personnequestion12 = personnes.Any(p => p.FirstName.StartsWith("D"));
            Console.WriteLine(string.Join("\n", personnequestion12));

            //13.Regrouper les personnes par leurs prénoms
            Console.WriteLine("**************** 13");
            var personnequestion13 = personnes.GroupBy(p => p.FirstName).ToList();
            foreach (var p in personnequestion13)
            {
                Console.WriteLine("------" + p.Key + "------");
                Console.WriteLine(string.Join("\n", p));
            }
        }

        static void Exo47()//7. Gérer la division par 0 par un try catch
        {
            int nbA = 5, nbB = 0, total = 0;
            try
            {
                if (nbB <= 0)
                    throw new Exception(nameof(nbB) + " = 0");
                total = nbA / nbB;
                Console.WriteLine(total);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

        static void Exo48()
        {
            //8.Créer une classe Élèves caractérisée par nom, âge et moyenne.
            //a.L’âge doit être entre 18 et 26 sinon l’exception InvalidAgeException est générée(elle
            //affiche le message "L’âge doit être entre 18 et 26").
            //b.La note doit être entre 0 et 20 sinon l’exception InvalidNoteException est générée
            //(elle affiche le message "La note doit être entre 0 et 20").
            //c.Définir les constructeurs de la classe et les accesseurs
            try
            {
                Eleves eleve = new Eleves("Lulu", 18, 30);
                Console.WriteLine(eleve);

            }
            catch (InvalidNoteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


        }

        static void Exo60()
        {
            //IO
            //Sérialiser et désérialiser une liste de personnes dans un fichier
            using (var stream = new FileStream("person.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var binaryFormatter = new BinaryFormatter();

                //Sérialiser
                List<Personne> listpersonnes = SampleDatas.GetSamplePersonnes();
                binaryFormatter.Serialize(stream, listpersonnes);

                //désérialiser
                stream.Position = 0; //Comme j'utilise le même stream, il faut mettre le curseur au début.
                var person = binaryFormatter.Deserialize(stream) as List<Personne>;

                Console.WriteLine(string.Join("\n", person));
            }
        }

        static void Exo61()
        {
            //Faire une méthode récursive(méthode qui s’appelle elle-même) permettant d’afficher tous les
            //dossiers et fichiers d’un dossier(C:/ par exemple) (Exo 61) :
            //• La recherche se fait sur plusieurs niveaux
            //• Un “.” doit être affiché pour chaque niveaux(1 “.” pour le 1er dossier, 2 “.” pour le sous
            //dossier, etc...)
            //• On ne doit pas voir les dossiers ou fichier cachés
            //• Ecrire les dossiers en vert et les fichiers en bleu
            //Tapez “tree c: / f” en ligne de commande pour avoir un aperçu du résultat demandé.
            //    Aidez - vous de la classe DirectoryInfo pour charger le dossier source.

            //Exo61Recursive(@"C:\Users\samyr\Desktop\teste");
            //Exo61Recursive(@"C:\Users\samyr\Desktop\Nouveau dossier");
            Exo61Recursive();

        }

        static void Exo61Recursive(string path = @"c:\", int nombreExecution = 0, int nblevelbase = 0, string caractere = "├", string teste = "")
        {
            List<DirectoryInfo> listeDossiersFiltrer;
            List<string> listeFichiersFiltrer;
            int nblevel;
            try
            {
                DirectoryInfo DirectoryInfo = new DirectoryInfo(path);
                DirectoryInfo[] listeDossiers = DirectoryInfo.GetDirectories();
                FileInfo[] listeFichiers = DirectoryInfo.GetFiles();

                //filtre, pas de fichiers et dossiers en hidden
                listeDossiersFiltrer = listeDossiers.Where(l => !l.Attributes.HasFlag(FileAttributes.Hidden)).ToList();
                listeFichiersFiltrer = listeFichiers.Where(l => !l.Attributes.HasFlag(FileAttributes.Hidden)).Select(l => l.Name).ToList();

                //je compte le nombre de / ou \ pour déterminer le nombre d'indentation
                if (nombreExecution == 0)
                {
                    Console.WriteLine(path.ToUpper());
                    nblevelbase = path.Count(p => p == '\\' || p == '/');
                    nblevel = 0;
                }
                else
                {
                    nblevel = nbSlash(path, nblevelbase);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (nblevel == 0)
                        Console.WriteLine(new StringBuilder($"{caractere}───{DirectoryInfo.Name} {nombreExecution} : {nblevelbase} : {nblevel}"));
                    else
                        Console.WriteLine(new StringBuilder($"{teste}{caractere}───{DirectoryInfo.Name} {nombreExecution} : {nblevelbase} : {nblevel}"));
                }

                //afficher les fichiers
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (string fichier in listeFichiersFiltrer)
                {
                    if (caractere == "└")
                        Console.WriteLine(new StringBuilder($"{teste}....│{fichier}"));
                    else
                        Console.WriteLine(new StringBuilder($"{teste}│...│{fichier}"));
                }

                for (int i = 0; i < listeDossiersFiltrer.Count; i++)
                {
                    if (i == listeDossiersFiltrer.Count - 1)
                    {
                        if (nbSlash(listeDossiersFiltrer[i].FullName, nblevelbase) > 1)
                        {
                            if (caractere == "├")
                                Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "└", teste + "│...");
                            else
                                Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "└", teste + "....");
                        }
                        else
                            Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "└", teste + "│...");
                    }
                    else
                    {
                        if (nbSlash(listeDossiersFiltrer[i].FullName, nblevelbase) > 0)
                            if (caractere == "└")
                                Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "├", teste + "....");
                            else
                                Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "├", teste + "│...");
                        else
                            Exo61Recursive(listeDossiersFiltrer[i].FullName, ++nombreExecution, nblevelbase, "├", teste);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //je compte le nombre de / ou \ pour déterminer le nombre d'indentation
        static int nbSlash(string path, int nbSlashbase)
        {
            int nbSlash = path.Count(p => p == '\\' || p == '/');
            int diff = nbSlash - nbSlashbase;
            return diff;
        }

        static void testeclasse()
        {
            Personne perso = new Personne();
            Personne perso2 = new Personne();
            perso.Name = "nini";
            Console.WriteLine(perso);
            Console.WriteLine(perso2);
        }
    }
}
