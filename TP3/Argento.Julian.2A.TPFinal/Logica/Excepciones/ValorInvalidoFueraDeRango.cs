using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    [Serializable]
    public class ValorInvalidoFueraDeRango:Exception
    {

        public ValorInvalidoFueraDeRango() { }

        public ValorInvalidoFueraDeRango(string message) : base(message)
        { }

        public ValorInvalidoFueraDeRango(string message, Exception inner)
            : base(message, inner) { }
    }
}
