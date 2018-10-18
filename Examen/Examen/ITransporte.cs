using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    interface ITransporte
    {
        string Color { get; set; }
        string Nombre { get; set; }
        int Capacidad { get; set; }

        void Frenar();
        void Acelerar();
        void Viajar();
    }
}
