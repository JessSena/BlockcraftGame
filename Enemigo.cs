using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Enemigo
    {
        private int energia;

        public Enemigo(int energia)
        {
            this.energia = energia;
        }

        public double getEnergiaActual()
        {
            return energia;
        }

        public void recibirDaño(int daño)  
        {
            this.energia -= daño ;
        }

    }
}
