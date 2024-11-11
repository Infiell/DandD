using System;
using System.Collections;
using System.Windows;

namespace DandD.Home
{
    internal class LVL
    {
        public int level { get; set; } = 1;
        public int maxLevel { get; set; } = 1000;
        public int minLevel { get; set; } = 1;
        public int per10LVL { get; set; } = 2;
        public int per50LVL { get; set; } = 10;
        public int per100LVL { get; set; } = 20;
        public int point { get; set; } = 1;
    }

    internal class PointsGet
    {
        public static int LevelChange(int Level)
        {
            var levl = new LVL();
            Level += levl.level;
            if (Level < levl.minLevel)
            {
                Level = 1;
                return Level;
            }
            else if (Level > levl.maxLevel)
            {
                Level = 1000;
                return Level;
            }
            else
            {
                return Level;
            }
        }

        public static int PointsChange(int pointCurr, int level)
        {
            var points = new LVL();
            pointCurr += points.point;
            if (level%10 == 0)
            {
                pointCurr += pointCurr * points.per10LVL;
                return pointCurr;
            }
            else if (level%50 == 0)
            {
                pointCurr += pointCurr * points.per50LVL;
                return pointCurr;
            }
            else if (level%100 == 0)
            {
                pointCurr+= pointCurr * points.per100LVL;
                return pointCurr;
            } else return pointCurr;
        }
    }
}
