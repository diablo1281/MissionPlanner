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
        public double CameraAngle { get; set; }

        public double pointX { get; set; }
        public double pointY { get; set; }

        private double angle_view_X = 54;
        private double angle_view_Y = 96;

        public double TrimX { get; set; }
        public double TrimY { get; set; }

        public double Cd = 0.45;
        public double ro = 1.2;
        public double S = 0.0085;
        public double m = 0.983;
        private double chi = -1;
        private double g = 9.8172;
        private double k;

        public Crosshair()
        {
            LineColor = "Red";
            LineWidth = 2;
            CenterOffset = 0.1;
            RectSize = 2;

            pointX = pointY = 0;
            TrimX = TrimY = 0;
            Delay = 0;
            CameraAngle = 0;
        }

        public void CalculateG(double lat, double alt)
        {
            g = 9.780318 * (1 + 0.0053024 * Math.Pow(Math.Sin(lat), 2) - 0.0000058 * Math.Pow(Math.Sin(lat), 2) - (3.086 * Math.Pow(10, -6) * alt));
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
                Angle = -666;
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

            Angle = Math.Atan(e.alt / (Distance - TrimX + (Delay * (e.airspeed - e.groundspeed)))) * (180 / Math.PI);

            pointX = (((CameraAngle - Angle) / angle_view_X) * e.Height) + (e.Height / 2);
            //pointX = e.Height / 2;
            pointY = e.Width / 2;
            //pointY = ((((Math.Atan(TrimY / e.alt) * (180 / Math.PI)) / angle_view_Y) * e.Width) * (TrimY / TrimY)) + (e.Width / 2);
        }
    
    }
}
