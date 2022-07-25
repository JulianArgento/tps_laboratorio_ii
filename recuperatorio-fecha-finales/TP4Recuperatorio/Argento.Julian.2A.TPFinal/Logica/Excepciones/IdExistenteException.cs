using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Excepciones
{
    [Serializable]
    public class IdExistenteException : Exception 
    {
        public IdExistenteException() { }

        public IdExistenteException(string message):base(message) 
        { }

        public IdExistenteException(string message, Exception inner)
            : base(message, inner) { }

    }
}
