using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Barco: Transporte // Herencia.
    {
        // Sobrecarga.
        public Barco()
        {

        }

        // Constructores.
        public Barco(string color, string nombre, int capacidad)
        {
            this.color = color;
            this.capacidad = capacidad;
            this.nombre = nombre;
        }

        // Polimorfismo.
        public override void Acelerar()
        {
            base.Acelerar();
            Console.WriteLine("El " + this.nombre + " acelera reciotote");
        }
    }
}
