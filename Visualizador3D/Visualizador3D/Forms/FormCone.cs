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
    public partial class FormCone : Form
    {
        private PictureBox picCono;
        private Timer timer;
        private Cone3D cone;
        private Point lastMousePos;
        private bool isDragging = false;
        public FormCone()
        {
            InitializeComponent();
            this.Text = "Cono 3D";
            this.Width = 800;
            this.Height = 600;
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            picCono = new PictureBox();
            picCono.Dock = DockStyle.Fill;
            this.Controls.Add(picCono);

            cone = new Cone3D();

            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += (s, e) => picCono.Invalidate();
            timer.Start();

            picCono.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                cone.Draw(e.Graphics, picCono.ClientSize);
            };

            picCono.MouseDown += (s, e) =>
            {
                isDragging = true;
                lastMousePos = e.Location;
                picCono.Focus();
            };

            picCono.MouseMove += (s, e) =>
            {
                if (isDragging)
                {
                    float dx = e.X - lastMousePos.X;
                    float dy = e.Y - lastMousePos.Y;
                    cone.Rotate(dy, dx, 0);
                    lastMousePos = e.Location;
                }
            };

            picCono.MouseUp += (s, e) => isDragging = false;

            picCono.MouseWheel += (s, e) =>
            {
                float zoomFactor = e.Delta > 0 ? 1.1f : 0.9f;
                cone.Zoom(zoomFactor);
            };

            this.KeyDown += (s, e) =>
            {
                float step = 10f;
                switch (e.KeyCode)
                {
                    case Keys.W: cone.Translate(0, step, 0); break;
                    case Keys.S: cone.Translate(0, -step, 0); break;
                    case Keys.A: cone.Translate(-step, 0, 0); break;
                    case Keys.D: cone.Translate(step, 0, 0); break;
                    case Keys.Q: cone.Translate(0, 0, step); break;
                    case Keys.E: cone.Translate(0, 0, -step); break;
                }
            };
        }
    }
}
