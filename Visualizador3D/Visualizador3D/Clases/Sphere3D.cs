using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador3D.Clases
{
    internal class Sphere3D
    {
        private List<Point3D> points = new List<Point3D>();
        private float angleX = 0f, angleY = 0f, angleZ = 0f;
        private float offsetX = 0f, offsetY = 0f, offsetZ = 0f;
        private float zoom = 1.0f;

        public Sphere3D()
        {
            float radius = 100;
            int latSteps = 20, lonSteps = 20;
            for (int i = 0; i <= latSteps; i++)
            {
                double theta = i * Math.PI / latSteps;
                for (int j = 0; j <= lonSteps; j++)
                {
                    double phi = j * 2 * Math.PI / lonSteps;
                    float x = (float)(radius * Math.Sin(theta) * Math.Cos(phi));
                    float y = (float)(radius * Math.Cos(theta));
                    float z = (float)(radius * Math.Sin(theta) * Math.Sin(phi));
                    points.Add(new Point3D(x, y, z));
                }
            }
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
            using (Brush brush = new SolidBrush(Color.Red))
            {
                foreach (var pt in points)
                {
                    var rotated = pt.Rotate(angleX, angleY, angleZ);
                    rotated.X += offsetX;
                    rotated.Y += offsetY;
                    rotated.Z += offsetZ;
                    var proj = rotated.Project(canvasSize, zoom);
                    g.FillEllipse(brush, proj.X - 1, proj.Y - 1, 3, 3);
                }
            }
        }
    }
}
