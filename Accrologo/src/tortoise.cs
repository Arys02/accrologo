using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accrologo
{
    public class Tortoise
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
        {
           this.angle = this.angle + newAngle;
        }

        public  void turnLeft(int newAngle)
        {
            this.angle = this.angle - newAngle;
        }

        public void updateAndMove(int forward, Graphics g)
        {
            double toRad = (Math.PI / 180) * this.angle.value;
            Point newpos = new Point(Convert.ToInt32(pos.X + forward * Math.Cos(toRad)),
                            Convert.ToInt32(pos.Y + forward * Math.Sin(toRad)));
                
            g.DrawLine(new Pen(Color.Blue, 2F), this.pos.X, this.pos.Y, newpos.X, newpos.Y);
            Console.WriteLine(pos);
            Console.WriteLine(newpos);
            Console.WriteLine("move");
            this.pos = newpos;
        }
    }
}
