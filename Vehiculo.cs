using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flota
{
    abstract class Vehiculo
    {
        public string Marca { get; set; }
        public String Modelo{ get; set; }
        public string Color { get; set; }
      

        public Vehiculo (string marca, string modelo, string color)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }

        public virtual string MostrarCaracteristicas()

        {
           string mostrar;
           return mostrar= (Marca + " " + Modelo + " de color " + Color + "\n");

        }



    }
}
