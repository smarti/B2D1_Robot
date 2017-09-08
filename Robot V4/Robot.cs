using System;
using System.Timers;

namespace Robot_V4
{
    internal class Robot
    {
        private readonly Timer DelayTimer;
        private int Location;
        private int Direction;
        private readonly Action OnUpdate;
        private int Destination;

        public Robot(int location, int direction, Action update)
        {
            this.DelayTimer = new Timer(200);
            this.DelayTimer.Elapsed += this.MoveOne;

            this.Location = location;
            this.Direction = direction;
            this.OnUpdate = update;
        }

        public void SetDirection(int direction)
        {
            this.Direction = direction;
        }

        public int GetLocation()
        {
            return this.Location;
        }

        /// <summary>
        ///     Move the robot one step.
        /// </summary>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        public void MoveOne()
        {
            this.Location = this.Location + this.Direction;
            this.OnUpdate();
        }

        private void MoveOne(object source, ElapsedEventArgs e)
        {
            if (this.Location == this.Destination)
                this.DelayTimer.Stop();
            else
            {
                //this.MoveOne();
                this.Location = this.Location + this.Direction;
                this.OnUpdate();
            }
        }

        /// <exception cref="ArgumentOutOfRangeException">The <see cref="T:System.Timers.Timer" /> is created with an interval equal to or greater than <see cref="F:System.Int32.MaxValue" /> + 1, or set to an interval less than zero.</exception>
        public void GoTo(int destination)
        {
            this.Destination = destination;

            if (destination > this.Location) { this.Direction = 1; }
            if (destination < this.Location) { this.Direction = -1; }

            this.DelayTimer.Start();
        }
    }
}
