using System;
using System.Collections.Generic;
using System.Drawing;

namespace BL
{
    public class SinusBL
    {
        List<PointF> sinePoints = new List<PointF>();
        Dictionary<int, float> coordinate = new Dictionary<int, float>();
        public double GetSin(int angle)
        {
            double radians = ConvertToRadians(angle);
            return Math.Sin(radians);
        }
        private double ConvertToRadians(int angle)
        {
            return (Math.PI * angle) / 180;
        }
        public Dictionary<int, float> CalculatePoints(int range)
        {
            for (int i = 0; i < range; i++)
            {
                float sineY = (float)GetSin(i) * (-1);
                coordinate.Add(i, sineY);
                //sinePoints.Add(new PointF(i, sineY));
            }
            return coordinate;
        }
    }
}
