using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flota
{
    class VehiculoFactory
    {


        private static Dictionary<string,Vehiculo> pool = new Dictionary<string, Vehiculo>();

        public static Vehiculo vehiculo(string marca, string modelo, string color)
        {
         Vehiculo v = null;

          
            if (pool.ContainsKey(marca + " " + modelo + " " + color))
            {
                v = pool[marca + " " + modelo + " " + color];


        
            }

       
            else
            {

                v = new Auto(marca, modelo, color);
                pool.Add(marca + " " + modelo + " " + color, v);
               
            }

            return v;
        }
    }
}

