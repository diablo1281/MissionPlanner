using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MissionPlanner.Controls
{
    public class Crosshair
    {
        public string LineColor { get; set; }
        public int LineWidth { get; set; }
        public double CenterOffset { get; set; }
        public double RectSize { get; set; }

        public double Delay { get; set; }
        public double Distance { get; set; }
        public double Angle { get; set; }

        public double pointX { get; set; }
        public double pointY { get; set; }

        private double Cd = 0.45;
        private double ro = 1.2;
        private double S = 0.0085;
        private double m = 1.361;
        private double chi = -1;
        private double g = 9.8172;
        //private double g = g = 9.780318 * (1 + 0.0053024 * (sin(lat) ^ 2) - 0.0000058 * (sin(lat) ^ 2)) - (3.086 * 10 ^ -6 * alt);
        private double k;
        public Crosshair()
        {
            LineColor = "Red";
            LineWidth = 2;
            CenterOffset = 0.1;
            RectSize = 2;

            pointX = pointY = 0;

            Delay = 0;
        }

        public void Draw(HUD e)
        {
            CalculateDistance(e);

            var pen = new Pen(Color.FromName(LineColor), LineWidth);

            double offset_x = CenterOffset * e.Width * 0.5;
            double offset_y = CenterOffset * e.Height * 0.5;
            e.DrawLine(pen, pointX, 0, pointX, pointY - offset_y);
            e.DrawLine(pen, pointX, pointY + offset_y, pointX, e.Height);
            e.DrawLine(pen, 0, pointY, pointX - offset_x, pointY);
            e.DrawLine(pen, pointX + offset_x, pointY, e.Width, pointY);
            e.DrawRectangle(pen, pointX - (RectSize * offset_x), pointY - (RectSize * offset_y), 2 * RectSize * offset_x, 2 * RectSize * offset_y);
        }

        public void CalculateDistance(HUD e)
        {
            if (e.groundspeed <= 1 || e.alt == 0)
            {
                pointX = e.Width / 2;
                pointY = e.Height / 2;
                return;
            }

            k = (Cd * ro * S) / (2 * m);

            for(double t = 0; t < 20; t += 0.01)
            {
                double H = e.alt + (1 / k) * (Math.Sqrt(k * g) * t - Math.Log((Math.Exp(2 * Math.Sqrt(k * g) * t) - chi) / (1 - chi)));

                if (H <= 0.001)
                {
                    double U0x = e.airspeed - e.groundspeed;

                    if (U0x < 0)
                        Distance = ((e.airspeed - e.groundspeed) * t) + ((1 / k) * Math.Log(1 - k * U0x * t));
                    else
                        Distance = ((e.airspeed - e.groundspeed) * t) - ((1 / k) * Math.Log(1 + k * U0x * t));

                    Distance += Delay * e.groundspeed;

                    break;
                }
            }

            Angle = Math.Atan(e.alt / Distance) * (180 / Math.PI);
        }
    
    }
}
