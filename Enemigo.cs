using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Enemigo
    {
        private double energiaActual;
        private double energiaTotal;

        public Enemigo(double energia)
        {
            this.energiaTotal = energia;
        }

        public double getEnergiaActual()
        {
            return energiaActual;
        }

        public void recibirDaño(double daño)  
        {
            this.energiaActual -= (daño * energiaTotal);
        }

        public bool estaVivo()
        {
            return (energiaActual > 0);
        }
    }
}
