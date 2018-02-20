using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accrologo
{
    class Angle
    {
        public int value;

        public Angle(int value)
        {
            this.value = value % 360;
        }

        public static Angle operator+ (Angle angle, int value)
        {
   
            int newValue = angle.value + (value % 360);
            if (newValue > 360)
                newValue = newValue % 360;
            return new Angle(newValue);
        }


        public static Angle operator- (Angle angle, int value)
        {
            int newValue = angle.value - (value % 360);
            if (newValue < 0)
                newValue = 360 + newValue;
            return new Angle(newValue);
        }

        public static bool operator ==(Angle angle, int value)
        {
            return (angle.value == value);
        }

        public static bool operator !=(Angle angle, int value)
        {
            return (angle.value != value);
        }

        public override string ToString()
        {
            return String.Format("{0}", this.value);
        }

    }
}
