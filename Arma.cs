using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Arma
    {
        private string nombre;
        private double poder;

        public Arma(string nombre, double poder)
        {
            this.nombre = nombre;
            this.poder = poder;
        }

        public double getPoder ()
        {
            return this.poder;
        }
    }
}
