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
    public partial class FormCylinder : Form
    {
        private PictureBox picCilindro;
        private Timer timer;
        private Cylinder3D cylinder;
        private Point lastMousePos;
        private bool isDragging = false;

        public FormCylinder()
        {
            InitializeComponent();
            this.Text = "Cilindro 3D";
            this.Width = 800;
            this.Height = 600;
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            picCilindro = new PictureBox();
            picCilindro.Dock = DockStyle.Fill;
            this.Controls.Add(picCilindro);

            cylinder = new Cylinder3D();

            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += (s, e) => picCilindro.Invalidate();
            timer.Start();

            picCilindro.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                cylinder.Draw(e.Graphics, picCilindro.ClientSize);
            };

            picCilindro.MouseDown += (s, e) =>
            {
                isDragging = true;
                lastMousePos = e.Location;
                picCilindro.Focus();
            };

            picCilindro.MouseMove += (s, e) =>
            {
                if (isDragging)
                {
                    float dx = e.X - lastMousePos.X;
                    float dy = e.Y - lastMousePos.Y;
                    cylinder.Rotate(dy, dx, 0);
                    lastMousePos = e.Location;
                }
            };

            picCilindro.MouseUp += (s, e) => isDragging = false;

            picCilindro.MouseWheel += (s, e) =>
            {
                float zoomFactor = e.Delta > 0 ? 1.1f : 0.9f;
                cylinder.Zoom(zoomFactor);
            };

            this.KeyDown += (s, e) =>
            {
                float step = 10f;
                switch (e.KeyCode)
                {
                    case Keys.W: cylinder.Translate(0, step, 0); break;
                    case Keys.S: cylinder.Translate(0, -step, 0); break;
                    case Keys.A: cylinder.Translate(-step, 0, 0); break;
                    case Keys.D: cylinder.Translate(step, 0, 0); break;
                    case Keys.Q: cylinder.Translate(0, 0, step); break;
                    case Keys.E: cylinder.Translate(0, 0, -step); break;
                }
            };
        }
    }
}
