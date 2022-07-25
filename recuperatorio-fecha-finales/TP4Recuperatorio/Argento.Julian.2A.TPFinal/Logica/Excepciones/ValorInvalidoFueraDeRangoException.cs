using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    [Serializable]
    public class ValorInvalidoFueraDeRangoException:Exception
    {

        public ValorInvalidoFueraDeRangoException() { }

        public ValorInvalidoFueraDeRangoException(string message) : base(message)
        { }

        public ValorInvalidoFueraDeRangoException(string message, Exception inner)
            : base(message, inner) { }
    }
}
