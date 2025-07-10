using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualizador3D.Clases;

namespace Visualizador3D.Forms
{
    public partial class FormSphere : Form
    {
        private PictureBox picEsfera;
        private Timer timer;
        private Sphere3D sphere;
        private Point lastMousePos;
        private bool isDragging = false;
        public FormSphere()
        {
            InitializeComponent();
            this.Text = "Esfera 3D";
            this.Width = 800;
            this.Height = 600;
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            picEsfera = new PictureBox();
            picEsfera.Dock = DockStyle.Fill;
            this.Controls.Add(picEsfera);

            sphere = new Sphere3D();

            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += (s, e) => picEsfera.Invalidate();
            timer.Start();

            picEsfera.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                sphere.Draw(e.Graphics, picEsfera.ClientSize);
            };

            picEsfera.MouseDown += (s, e) =>
            {
                isDragging = true;
                lastMousePos = e.Location;
                picEsfera.Focus();
            };

            picEsfera.MouseMove += (s, e) =>
            {
                if (isDragging)
                {
                    float dx = e.X - lastMousePos.X;
                    float dy = e.Y - lastMousePos.Y;
                    sphere.Rotate(dy, dx, 0);
                    lastMousePos = e.Location;
                }
            };

            picEsfera.MouseUp += (s, e) => isDragging = false;

            picEsfera.MouseWheel += (s, e) =>
            {
                float zoomFactor = e.Delta > 0 ? 1.1f : 0.9f;
                sphere.Zoom(zoomFactor);
            };

            this.KeyDown += (s, e) =>
            {
                float step = 10f;
                switch (e.KeyCode)
                {
                    case Keys.W: sphere.Translate(0, step, 0); break;
                    case Keys.S: sphere.Translate(0, -step, 0); break;
                    case Keys.A: sphere.Translate(-step, 0, 0); break;
                    case Keys.D: sphere.Translate(step, 0, 0); break;
                    case Keys.Q: sphere.Translate(0, 0, step); break;
                    case Keys.E: sphere.Translate(0, 0, -step); break;
                }
            };
        }
    }
}
