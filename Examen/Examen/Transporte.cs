using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Transporte: ITransporte
    {
        // Atributos.
        // "Protected" es encapsulamiento.
        protected string color = "", nombre = "";
        protected int capacidad = 0;

        // Propiedades.
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        // Metodos.
        // "Virtual" es polimorfismo.
        public virtual void Frenar()
        {
            Console.WriteLine("El " + this.nombre + " frena");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("El " + this.nombre + " acelera");
        }

        public virtual void Viajar()
        {
            Console.WriteLine("El " + this.nombre + " viaja");
        }
    }
}
