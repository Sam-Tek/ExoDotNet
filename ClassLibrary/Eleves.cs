using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Eleves
    {
        private int _age = 18;
        private double _moyenne = 10;

        public Eleves()
        {

        }
        public Eleves(string nom, int age, double moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public string Nom { get; set; } = "Lupin";
        public int Age
        {
            get { return _age; }
            set 
            { 
                if (value > 17 && value < 27)
                    _age = value; 
                else
                    throw new InvalidAgeException("L’âge doit être entre 18 et 26");
            }
        }
        public double Moyenne 
        { 
            get { return _moyenne; } 
            set
            {
                if (value >= 0 && value <= 20)
                    _moyenne = value;
                else
                    throw new InvalidNoteException("La note doit être entre 0 et 20.");
            } 
        }


        public override string ToString()
        {
            return $"{Nom} {Age} {Moyenne}";
        }

    }
}
