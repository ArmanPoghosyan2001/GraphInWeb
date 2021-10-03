using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CosinusBL
    {
        Dictionary<int, float> coordinate = new Dictionary<int, float>();
        public double GetCos(int angle)
        {
            double radians = ConvertToRadians(angle);
            return Math.Cos(radians);
        }
        private double ConvertToRadians(int angle)
        {
            return (Math.PI * angle) / 180;
        }
        public Dictionary<int, float> CalculatePoints(int range)
        {
            for (int i = 0; i < range; i++)
            {
                float sineY = (float)GetCos(i) * (-1);
                coordinate.Add(i, sineY);
            }
            return coordinate;
        }
    }
}
