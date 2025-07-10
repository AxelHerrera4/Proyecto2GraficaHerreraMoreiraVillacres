using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Drawing;

namespace Visualizador3D.Clases
{
    internal class Cube3D
    {
        private Point3D[] vertices;
        private int[,] edges;
        private float angleX = 0f, angleY = 0f, angleZ = 0f;
        private float offsetX = 0f, offsetY = 0f, offsetZ = 0f;
        private float zoom = 1.0f;

        public Cube3D()
        {
            float s = 100;
            vertices = new Point3D[]
            {
            new Point3D(-s, -s, -s), new Point3D(s, -s, -s),
            new Point3D(s,  s, -s), new Point3D(-s,  s, -s),
            new Point3D(-s, -s,  s), new Point3D(s, -s,  s),
            new Point3D(s,  s,  s), new Point3D(-s,  s,  s)
            };

            edges = new int[,]
            {
            {0,1},{1,2},{2,3},{3,0},
            {4,5},{5,6},{6,7},{7,4},
            {0,4},{1,5},{2,6},{3,7}
            };
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
            PointF[] projected = new PointF[vertices.Length];
            for (int i = 0; i < vertices.Length; i++)
            {
                Point3D v = vertices[i];
                Point3D rotated = v.Rotate(angleX, angleY, angleZ);
                rotated.X += offsetX;
                rotated.Y += offsetY;
                rotated.Z += offsetZ;
                projected[i] = rotated.Project(canvasSize, zoom);
            }

            using (Pen pen = new Pen(Color.Blue, 2))
            {
                for (int i = 0; i < edges.GetLength(0); i++)
                {
                    g.DrawLine(pen, projected[edges[i, 0]], projected[edges[i, 1]]);
                }
            }
        }
    }

    public struct Point3D
    {
        public float X, Y, Z;

        public Point3D(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        public Point3D Rotate(float angleX, float angleY, float angleZ)
        {
            double radX = angleX * Math.PI / 180;
            double radY = angleY * Math.PI / 180;
            double radZ = angleZ * Math.PI / 180;

            float x = X, y = Y, z = Z;

            float cosX = (float)Math.Cos(radX), sinX = (float)Math.Sin(radX);
            float cosY = (float)Math.Cos(radY), sinY = (float)Math.Sin(radY);
            float cosZ = (float)Math.Cos(radZ), sinZ = (float)Math.Sin(radZ);

            float y1 = y * cosX - z * sinX;
            float z1 = y * sinX + z * cosX;
            y = y1; z = z1;

            float x1 = x * cosY + z * sinY;
            z1 = -x * sinY + z * cosY;
            x = x1; z = z1;

            x1 = x * cosZ - y * sinZ;
            y1 = x * sinZ + y * cosZ;
            x = x1; y = y1;

            return new Point3D(x, y, z);
        }

        public PointF Project(Size canvasSize, float zoom)
        {
            float scale = (300 * zoom) / (Z + 500);
            float x2d = X * scale + canvasSize.Width / 2;
            float y2d = -Y * scale + canvasSize.Height / 2;
            return new PointF(x2d, y2d);
        }
    }
}
