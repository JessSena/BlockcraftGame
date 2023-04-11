using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Personaje
    {
        private double energia;
        Arma arma;

        public Personaje(double energia, Arma arma)
        {
            this.energia = energia;
            this.arma = arma;
        }

        public void Atacar (Enemigo enemigo)
        {
            enemigo.recibirDaño(arma.getPoder());
        }

        public void CambiarArma(Arma arma)
        {
            this.arma = arma;

        }
    }
}
