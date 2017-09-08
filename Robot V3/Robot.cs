using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;
using System.Timers;

namespace Robot_V3
{
    class Robot
    {
        private Timer _wachten;
        public int Plaats;
        public int Richting;

        public Robot(int plaats, int richting)
        {
            this._wachten = new Timer(50);

            this.Plaats = plaats;
            this.Richting = richting;
        }

        public void ZetEenStap()
        {
            this.Plaats += this.Richting;
            
            //Form1.RefreshNumbers();
        }

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
                //_wachten.Elapsed += ;
                //Thread.Sleep(50);

            }
        }
    }
}
