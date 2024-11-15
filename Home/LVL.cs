using System;
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
        public int statPerPoint { get; set; } = 1;
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
            if (level % 10 == 0)
            {
                pointCurr += points.per10LVL;
                if (level % 50 == 0)
                {
                    pointCurr += points.per50LVL;
                    if (level % 100 == 0)
                    {
                        pointCurr += points.per100LVL;
                        return pointCurr;
                    }
                    return pointCurr;
                }
                return pointCurr;
            }
            return pointCurr;
        }

        public static int PointCost(int points, int currPoint)
        {
            if (points > 0)
            {
                var point = new LVL().statPerPoint;
                currPoint += point;
                return currPoint;
            } else
            {
                MessageBox.Show("Не хватает поинтов для прокачки стата");
                return currPoint;
            }
        }

        public static int PointSpend(int points)
        {
            if (points > 0)
            {
                points--;
                return points;
            }
            else { return points; }
        }
    }
}
