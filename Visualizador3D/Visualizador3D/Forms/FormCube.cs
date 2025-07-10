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
    public partial class FormCube : Form
    {
        private PictureBox picCubo;
        private Timer timer;
        private Cube3D cube;
        private Point lastMousePos;
        private bool isDragging = false;


        public FormCube()
        {
            InitializeComponent();
            this.Text = "Cubo 3D";
            this.Width = 800;
            this.Height = 600;
            this.DoubleBuffered = true;
            this.KeyPreview = true;


            picCubo = new PictureBox();
            picCubo.Dock = DockStyle.Fill;
            this.Controls.Add(picCubo);

            cube = new Cube3D();

            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += (s, e) => picCubo.Invalidate();
            timer.Start();

            picCubo.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                cube.Draw(e.Graphics, picCubo.ClientSize);
            };

            picCubo.MouseDown += (s, e) =>
            {
                isDragging = true;
                lastMousePos = e.Location;
                picCubo.Focus(); 
            };

            picCubo.MouseMove += (s, e) =>
            {
                if (isDragging)
                {
                    float dx = e.X - lastMousePos.X;
                    float dy = e.Y - lastMousePos.Y;
                    cube.Rotate(dy, dx, 0);
                    lastMousePos = e.Location;
                }
            };

            picCubo.MouseUp += (s, e) => isDragging = false;

            picCubo.MouseWheel += (s, e) =>
            {
                float zoomFactor = e.Delta > 0 ? 1.1f : 0.9f;
                cube.Zoom(zoomFactor);
            };

            this.KeyDown += (s, e) =>
            {
                float step = 10f;
                switch (e.KeyCode)
                {
                    case Keys.W: cube.Translate(0, step, 0); break;
                    case Keys.S: cube.Translate(0, -step, 0); break;
                    case Keys.A: cube.Translate(-step, 0, 0); break;
                    case Keys.D: cube.Translate(step, 0, 0); break;
                    case Keys.Q: cube.Translate(0, 0, step); break;
                    case Keys.E: cube.Translate(0, 0, -step); break;
                }
            };

        }


    }
}
