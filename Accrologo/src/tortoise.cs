using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accrologo.src
{
    class Tortoise
    {
        private Angle angle;
        private Point pos;

        public Tortoise()
        {
            this.angle = new Angle(0);
            this.pos = new Point(0, 0);
        }

        public Tortoise(int angle, Point pos)
        {
            this.angle = new Angle(angle);
            this.pos = pos;
        }

        public void turnRight(int newAngle)
        { }

        public  void turnLeft(int newAngle)
        { }

        public void updateAndMove(int forward)
        {
            double toRad = (Math.PI / 180) * this.angle.value;
            Point Newpos = new Point(Convert.ToInt32(pos.X + forward * Math.Cos(toRad)),
                            Convert.ToInt32(pos.Y + forward * Math.Sin(toRad)));
            // move
        }
        //point
        //angle
        

        //move
        //update point
        //update angle

    }
}
