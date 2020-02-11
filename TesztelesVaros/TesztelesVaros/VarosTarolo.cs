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
            if (!EllenorizNagyBetuvelKezdodik())
            {
                throw new VarosNemNagyBetuvelKezdodik("Rossz a város, kezdje nagy betűvel!");
            }
            if (!EllenorizVarosNemKisbetuvelFolytatodik())
            {
                throw new VarosNemKisbetuvelFolytatodik("Nem kisbetűvel folytatódik a város neve!");
            }
            return true;
        }

        private bool EllenorizVarosNemKisbetuvelFolytatodik()
        {
            for (int i = 1; i < varosnev.Length; i++)
            {
                if (!char.IsLetter(varosnev[i]))
                {
                    return false;
                }
                else
                {
                    if (!char.IsLower(varosnev[i]))
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        private bool EllenorizNagyBetuvelKezdodik()
        {
            if (char.IsLower(varosnev[0]))
            {
                return false;
            } else
            {
                return true;

            }
        }
    }
}
