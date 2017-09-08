using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Robot_V3
{
    class Robot
    {
        public int Plaats;
        public int Richting;

        public Robot(int plaats, int richting)
        {
            this.Plaats = plaats;
            this.Richting = richting;
        }

        public void ZetEenStap() { this.Plaats += this.Richting; }

        public void GaNaar(int bestemming)
        {
            if (this.Plaats < bestemming)
            {
                this.Richting = 1;
            }
            if (this.Plaats > bestemming)
            {
                this.Richting = -1;
            }

            while (bestemming != this.Plaats)
            {
                this.ZetEenStap();
                Thread.Sleep(50);
            }
        }
    }
}
