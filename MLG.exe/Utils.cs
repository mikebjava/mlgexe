using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MLG.exe
{
    public class Utils
    {
        public static readonly Random random = new Random();

        public static Point RandomPoint(int xfrom, int yfrom)
        {
            return new Point(random.Next(xfrom), random.Next(yfrom));
        }

        public static int RandomAxis(Axis axis)
        {
            if (axis == Axis.Horizontal)
            {
                return random.Next(Screen.PrimaryScreen.Bounds.Width);
            }
            else
            {
                return random.Next(Screen.PrimaryScreen.Bounds.Height);
            }
        }

        public static int RandomAxis(Axis axis, Rectangle Bounds)
        {
            if (axis == Axis.Horizontal)
            {
                return RandomBounds(Bounds)[0];
            }
            else
            {
                return RandomBounds(Bounds)[1];
            }
        }

        public static int[] RandomBounds(Rectangle Bounds)
        {
            int[] result = { random.Next(Screen.PrimaryScreen.Bounds.Width), random.Next(Screen.PrimaryScreen.Bounds.Height) };
            if (result[0] < 0 || result[1] < 0 || result[0] > (Screen.PrimaryScreen.Bounds.Width - Bounds.Width) || result[1] > (Screen.PrimaryScreen.Bounds.Height - Bounds.Height))
            {
                return RandomBounds(Bounds);
            }
            else
            {
                return result;
            }
        }
    }

    public enum Axis
    {
        Horizontal, Vertical
    }
}
