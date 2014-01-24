using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace imStudio.Game.EsurientSnake.Librarys
{
    public class ConfigHelper
    {
        public static int RowCount = 15;
        public static int ColCount = 15;
        public static int BoxWidth = 25;
        public static int BoxHeight = 25;

        public static int Speed = 500;
        public static Color SnakeColor = Color.Chartreuse;
        public static Color MapColor = Color.LightBlue;
        public static Color LineColor = Color.Black;
        public static Color BonusColor = Color.Red;
        public static int BonusShow = 15;
        public static int BonusHide = 10;
    }
}
