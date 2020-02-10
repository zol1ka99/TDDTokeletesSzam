using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesztelesVaros
{
    public class VarosTarolo
    {
        private readonly string varosnev;

        public VarosTarolo (string varosnev)
        {
            this.varosnev = varosnev;
        }

        public bool EllenorizVarosNevMegfeleloE()
        {
            if (EllenorizNagyBetuvelKezdodik())
            {
                throw new VarosNemNagyBetuvelKezdodik("Rossz a város, kezdje nagy betűvel!");
            }
            return true;
        }

        private bool EllenorizNagyBetuvelKezdodik()
        {
            return true;
        }
    }
}
