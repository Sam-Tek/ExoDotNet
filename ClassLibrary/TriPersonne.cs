using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TriPersonne : IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            int comparisonResult = x.CompareTo(y);
            if (comparisonResult == 0)
                return x.FirstName.CompareTo(y.FirstName);
            else
                return comparisonResult;
        }
    }
}
