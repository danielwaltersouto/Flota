using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flota
{
    class Auto : Vehiculo
    {
        internal Auto(string marca, string modelo, string color) : base(marca, modelo, color)

        {
        }
        public override string MostrarCaracteristicas()
        {
            return base.MostrarCaracteristicas();
        }


    }
}
