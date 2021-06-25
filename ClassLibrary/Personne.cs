using System;

namespace ClassLibrary
{
    [Serializable]
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne>
    {
        public Personne()
        {
        }
        public Personne(string name, string  firstName, DateTime dateBirth)
        {
            Name = name;
            FirstName = firstName;
            DateBirth = dateBirth;
        }
        public string Name { get; set; } = "Samy";
        public string FirstName { get; set; } = "Ruben";
        public DateTime DateBirth { get; set; } = DateTime.Now;

        //exo 35 
        public static string Test { get; set; } = "propriété statique";

        public string MajPrenom()
        {
            FirstName = FirstName.ToUpper();
            return FirstName;
        }

        public override string ToString()
        {
            return $"{Name} {FirstName} {DateBirth.ToString("dddd dd MMMM yyyy")}";
        }

        public virtual string Afficher()
        {
            return $"{Name} {FirstName} {DateBirth.ToString("dddd dd MMMM yyyy")}";
        }

        public bool Equals(Personne other)
        {
            return other.Name == Name && other.FirstName == FirstName && other.DateBirth.ToString("ddMMyyyy") == DateBirth.ToString("ddMMyyyy");
        }

        public int CompareTo(Personne other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
