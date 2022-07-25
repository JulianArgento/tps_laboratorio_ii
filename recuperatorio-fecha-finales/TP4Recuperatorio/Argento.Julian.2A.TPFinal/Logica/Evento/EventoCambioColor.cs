using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Evento
{
    public class EventoCambioColor
    {
        public delegate void ColorHandler();
        public event ColorHandler cambiarColor;

        /// <summary>
        /// Valida que el evento cambiarColor no sea null, y lo llama
        /// </summary>
        public void CambiarColor()
        {
            if (this.cambiarColor is not null)
                this.cambiarColor.Invoke();

        }
    }
}
