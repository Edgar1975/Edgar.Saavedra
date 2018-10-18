using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Barco barco = new Barco("Gris", "Barco", 15000);
            Console.WriteLine("La capacidad del barco es: " + barco.Capacidad);

            Barco barco2 = new Barco();
            barco2.Nombre = "Barco" ;
            Console.WriteLine(barco2.Nombre);

            Avion avion = new Avion("Blanco", "Avion", 250);
            Console.WriteLine("La capacidad del avión es: " + avion.Capacidad);

            Avion avion2 = new Avion();
            avion2.Nombre = "Avion";
            Console.WriteLine(avion2.Nombre);

            Tren tren = new Tren("Blanco", "Tren", 550);
            Console.WriteLine("La capacidad del tren es: " + tren.Capacidad);

            Tren tren2 = new Tren();
            tren2.Nombre = "Tren";
            Console.WriteLine(tren2.Nombre);

            Carro carro = new Carro("Rojo", "Carro", 2);
            Console.WriteLine("La capacidad del carro es: " + carro.Capacidad);

            Carro carro2 = new Carro();
            carro2.Nombre = "Carro";
            Console.WriteLine(carro2.Nombre);

            Bicicleta bicicleta = new Bicicleta("Negro", "Bicicleta", 1);
            Console.WriteLine("La capacidad de la bicicleta es: " + bicicleta.Capacidad);

            Bicicleta bicicleta2 = new Bicicleta();
            bicicleta2.Nombre = "Bicicleta";
            Console.WriteLine(bicicleta2.Nombre);
        }
    }
}
