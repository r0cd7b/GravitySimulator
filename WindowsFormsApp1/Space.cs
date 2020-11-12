using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;

namespace WindowsFormsApp1
{
    class Space
    {
        List<Planet> planets; // 행성들을 List 자료 구조로 표현.

        public List<Planet> Planets
        {
            get { return planets; }
        }

        public Space()
        {
            planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet) // 행성 추가 메소드.
        {
            foreach (Planet p in planets)
                if (p.X == planet.X && p.Y == planet.Y)
                    return; // 이미 동일한 정보의 행성이 존재할 경우 리턴.
            planets.Add(planet); // 리스트에 행성 추가.
        }

        public void FusePlanet(Planet p1, Planet p2) // 행성 충돌 처리 메소드. (p1이 p2보다 큰 부피의 행성.)
        {
            double m1 = p1.Mass, m2 = p2.Mass;
            p1.Mass += m2; // 부피가 큰 쪽에 질량 흡수.
            p1.Speed = (p1.Speed * m1 + p2.Speed * m2) / (m1 + m2); // 충돌 후 운동량 계산.

            // 두 행성의 부피를 더하고 그 부피의 지름을 계산.
            double d = p1.Diameter;
            double r1 = d / 2.0, r2 = p2.Diameter / 2.0;
            double sumD = Math.Sqrt(Math.Pow(r1, 2.0) + Math.Pow(r2, 2.0)) * 2.0;
            p1.Diameter = sumD; // 새로운 정보 덮어 씌움.

            planets.Remove(p2); // 부피가 작은 쪽의 행성 제거.
        }

        public void Move(int w, int h) // 행성의 운동 구현.
        {
            int i = 0, c1 = planets.Count, c2 = c1 - 1;
            for (i = 0; i < c2; i++) // 전체 행성에 대하여 반복.
            {
                for (int j = i + 1; j < c1; j++)
                {
                    double x2 = planets[j].X, y2 = planets[j].Y;
                    double x1 = planets[i].X, y1 = planets[i].Y;
                    double m1 = planets[i].Mass, m2 = planets[j].Mass;
                    Vector v = new Vector(x2, y2) - new Vector(x1, y1); // 두 행성 사이의 거리 계산
                    double l = v.Length;
                    Vector f = (-28.0 * (m1 * m2 / Math.Pow(l, 2.0)) * (v / l)); // 두 행성 사이에 발생하는 중력 계산.
                    planets[i].Speed += -f / m1; // 행성1의 가속도 적용
                    planets[j].Speed += f / m2; // 행성2의 가속도 적용
                }
            }

            i = 0;
            while (i < planets.Count) // 상황에 따른 행성의 삭제 과정
            {
                double x1 = planets[i].X, y1 = planets[i].Y;
                double r1 = planets[i].Diameter / 2.0;
                if (x1 + r1 < 0 || y1 + r1 < 0 || w < x1 - r1 || h < y1 - r1) // 행성이 화면 밖을 나간 상황일 경우.
                {
                    planets.Remove(planets[i]); // 행성 삭제.
                    continue;
                }

                int j = 0;
                while (i < planets.Count && j < planets.Count) // 행성 간의 충돌 상황일 경우.
                {
                    if (i != j)
                    {
                        double r2 = planets[j].Diameter / 2.0;
                        double d = Math.Sqrt(Math.Pow(x1 - planets[j].X, 2.0) + Math.Pow(y1 - planets[j].Y, 2.0)); // 두 행성 간의 거리 계산.
                        if (d - r1 - r2 < planets[j].Speed.Length) // 두 행성의 거리가 충돌 거리일 경우.
                        {
                            if (r1 < r2) // 행성1의 부피가 더 작은 경우.
                            {
                                FusePlanet(planets[j], planets[i]);
                                break;
                            }
                            FusePlanet(planets[i], planets[j]); // 행성2의 부피가 더 작은 경우.
                            continue;
                        }
                    }
                    j++;
                }
                i++;
            }

            foreach (Planet p in planets) // 모든 행성들이 각자의 속도 방향으로 이동.
            {
                Vector v = p.Speed;
                p.X += v.X;
                p.Y += v.Y;
            }
        }
    }
}
