using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador3D.Clases
{
    internal class Cylinder3D
    {
        private List<Point3D> points = new List<Point3D>();
        private List<(int, int)> edges = new List<(int, int)>();
        private float angleX = 0f, angleY = 0f, angleZ = 0f;
        private float offsetX = 0f, offsetY = 0f, offsetZ = 0f;
        private float zoom = 1.0f;

        public Cylinder3D()
        {
            float radius = 100;
            float height = 200;
            int segments = 30;

            for (int i = 0; i < segments; i++)
            {
                double theta = 2 * Math.PI * i / segments;
                float x = (float)(radius * Math.Cos(theta));
                float z = (float)(radius * Math.Sin(theta));

                points.Add(new Point3D(x, -height / 2, z)); 
                points.Add(new Point3D(x, height / 2, z));  

                edges.Add((i * 2, i * 2 + 1));

                if (i > 0)
                {
                    edges.Add(((i - 1) * 2, i * 2));         
                    edges.Add(((i - 1) * 2 + 1, i * 2 + 1));
                }
            }

            edges.Add(((segments - 1) * 2, 0));
            edges.Add(((segments - 1) * 2 + 1, 1));
        }

        public void Rotate(float dx, float dy, float dz)
        {
            angleX += dx;
            angleY += dy;
            angleZ += dz;
        }

        public void Translate(float dx, float dy, float dz)
        {
            offsetX += dx;
            offsetY += dy;
            offsetZ += dz;
        }

        public void Zoom(float factor)
        {
            zoom *= factor;
        }

        public void Draw(Graphics g, Size canvasSize)
        {
            PointF[] projected = new PointF[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i].Rotate(angleX, angleY, angleZ);
                p.X += offsetX;
                p.Y += offsetY;
                p.Z += offsetZ;
                projected[i] = p.Project(canvasSize, zoom);
            }

            using (Pen pen = new Pen(Color.Green, 2))
            {
                foreach (var (a, b) in edges)
                    g.DrawLine(pen, projected[a], projected[b]);
            }
        }
    }
}
