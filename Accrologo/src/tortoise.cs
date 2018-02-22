using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Accrologo
{
    public class Tortoise
    {
        private Angle angle;
        private Point pos;
        private Point originPos;
        private bool isPenUp;
        private Color penColor;


        public Tortoise()
        {
            angle = new Angle(0);
            pos = new Point(0, 0);
            originPos = pos;
            isPenUp = false;
            penColor = Color.Black;
        }

        public Tortoise(int angle, Point pos)
        {
            this.angle = new Angle(angle);
            this.pos = pos;
            this.originPos = pos;
            this.isPenUp = false;
            this.penColor = Color.Black;
        }

        public void turnRight(int newAngle)
        {
           this.angle = this.angle + newAngle;
        }

        public  void turnLeft(int newAngle)
        {
            this.angle = this.angle - newAngle;
        }

        public void goCenter()
        {
            this.pos = this.originPos;
        }

        public void turnbackwardAndMove(int distance, Graphics g)
        {
            this.angle = angle + 180;
            updateAndMove(distance, g);
        }

        public void setPenUp()
        {
            this.isPenUp = true;
        }

        public void setPenDown()
        {
            this.isPenUp = false;
        }

        public void changeColor(int newColorId)
        {
            switch (newColorId)
            {
                case 0:
                    this.penColor = Color.Black;
                    break;
                case 1:
                    this.penColor = Color.Blue;
                    break;
                case 2:
                    this.penColor = Color.Red;
                    break;
                case 3:
                    this.penColor = Color.Green;
                    break;
                case 4:
                    this.penColor = Color.Yellow;
                    break;
                case 5:
                    this.penColor = Color.Purple;
                    break;
                case 6:
                    this.penColor = Color.Lime;
                    break;
                case 7:
                    this.penColor = Color.Silver;
                    break;
                case 8:
                    this.penColor = Color.Orange;
                    break;
                case 9:
                    this.penColor = Color.Brown;
                    break;
                case 10:
                    this.penColor = Color.Navy;
                    break;
                case 11:
                    this.penColor = Color.Maroon;
                    break;
                case 12:
                    this.penColor = Color.Aqua;
                    break;
                case 13:
                    this.penColor = Color.Fuchsia;
                    break;
                case 14:
                    this.penColor = Color.Teal;
                    break;
                case 15:
                    this.penColor = Color.White;
                    break;
                default:
                    this.penColor = Color.Black;
                    break;

            }
        }

        public void updateAndMove(int forward, Graphics g)
        {
            double toRad = (Math.PI / 180) * this.angle.value;
            Point newpos = new Point(Convert.ToInt32(pos.X + forward * Math.Cos(toRad)),
                            Convert.ToInt32(pos.Y + forward * Math.Sin(toRad)));
                

            if (!isPenUp)
                g.DrawLine(new Pen(penColor, 2F), this.pos.X, this.pos.Y, newpos.X, newpos.Y);
            Console.WriteLine(pos);
            Console.WriteLine(newpos);
            Console.WriteLine("move");
            this.pos = newpos;
        }
    }
}
