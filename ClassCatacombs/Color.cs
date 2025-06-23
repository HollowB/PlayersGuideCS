using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCatacombs
{
    class Color
    {
        public byte Red { get; private set;}
        public byte Green { get; private set;}
        public byte Blue { get; private set;}

        public static Color WhiteColor = new Color(255,255,255);
        public static Color BlackColor = new Color(0,0,0);
        public static Color RedColor = new Color(255,0,0);
        public static Color OrangeColor = new Color(255,165,0);
        public static Color YellowColor = new Color(255,255,0);
        public static Color GreenColor = new Color(0,128,0);
        public static Color BlueColor = new Color(0,0,255);
        public static Color PurpleColor = new Color(128,0,128);

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
