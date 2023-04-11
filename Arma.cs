using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Arma
    {
        private int poder;

        public Arma(int poder)
        {
            this.poder = poder;
        }

        public int getPoder ()
        {
            return this.poder;
        }
    }
}
