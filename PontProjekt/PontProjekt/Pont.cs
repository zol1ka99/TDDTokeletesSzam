using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontProjekt
{
    public class Pont
    {
        private int x;
        private int y;

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool origobanVanE()
        {
            if (x == 0 && y == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool yTengelyenVanE()
        {
            if (x == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool xTengelyenVanE()
        {
            if (y == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
