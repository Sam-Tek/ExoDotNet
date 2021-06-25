using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employe : Personne
    {
        public Employe() : base()
        {
        }
        public Employe(string name, string firstName, DateTime dateBirth, double salaire) : base(name, firstName, dateBirth)
        {
            Salaire = salaire;
        }

        public double Salaire { get; set; } = 1500;

        public override string Afficher()
        {
            return $"{Salaire} {base.Afficher()}";
        }

        public override string ToString()
        {
            return $"{Salaire} {base.ToString()}";
        }


    }
}
