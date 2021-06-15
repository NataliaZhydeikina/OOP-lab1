using System;

namespace GeometryLib
{
    public class Line
    {
        public float x1 { get; set; }
        public float y1 { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }

        public Line(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public float[] getCoordinates() {
            return new float[] {x1,y1,x2,y2};
        }

        private double getWidth() { 
            return x2 - x1; ;
        }
        private double getHeight()
        {
            return y2 - y1;
        }
        public double length() {
            double w = getWidth(); 
            double h = getHeight();
            double len = Math.Sqrt(Math.Pow(w, 2) + Math.Pow(h, 2));
            return Math.Round(len, 2);
        }

        public double getAngleOX() {
            double w = getWidth();
            double angle = Math.Acos(w / length()) * (180 / Math.PI);
            return  Math.Round(angle, 2);
        }

        public double getAngleOY()
        {
            double h = getHeight();
            double angle = Math.Acos(h / length()) * (180 / Math.PI);
            return Math.Round(angle, 2);
        }
    }
}
