using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InvalidNoteException : Exception
    {
        public InvalidNoteException(string message) : base(message)
        {

        }
    }
}
