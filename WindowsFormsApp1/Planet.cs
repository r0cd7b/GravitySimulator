using System.Drawing;
using System.Windows;

namespace WindowsFormsApp1
{
    class Planet // 행성 클래스
    {
        double x, y, mass, diameter; // 중심 좌표, 질량, 지름
        Color color; // 색
        Vector speed; // 속도

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public Color Color
        {
            get { return color; }
        }
        public Vector Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Planet(double x, double y, double mass, double diameter, Color color, Vector speed) // 생성자
        {
            this.x = x;
            this.y = y;
            this.mass = mass;
            this.diameter = diameter;
            this.color = color;
            this.speed = speed;
        }
    }
}
