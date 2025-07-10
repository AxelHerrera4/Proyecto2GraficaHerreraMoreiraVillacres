using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Visualizador3D
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderbtn;
        private Form currentChildForm;

        //Fields to rotate
        private Timer rotationTimer; 
        private float currentAngle = 0f;
        private Bitmap originalImage;
        private PictureBox rotatingPictureBox;


        //Constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderbtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            InitializeRotatingImage();
        }

        private void InitializeRotatingImage()
        {
            try
            {
                originalImage = new Bitmap(Properties.Resources._3D_Logo_PNG_Pic);
            }
            catch
            {
                originalImage = new Bitmap(300, 300);
                using (Graphics g = Graphics.FromImage(originalImage))
                {
                    g.FillEllipse(Brushes.SkyBlue, 0, 0, 300, 300);
                    using (var font = new Font("Arial", 30))
                    {
                        g.DrawString("3D", font, Brushes.White, 90, 120);
                    }
                }
            }

            rotatingPictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Visible = true,
                Image = originalImage
            };

            panelDesktop.Controls.Add(rotatingPictureBox);
            rotatingPictureBox.BringToFront();

            rotationTimer = new Timer { Interval = 60 };
            rotationTimer.Tick += RotateImage;
            rotationTimer.Start();
        }

        private void RotateImage(object sender, EventArgs e)
        {
            currentAngle += 4f;
            if (currentAngle >= 360) currentAngle = 0;

            if (originalImage != null && rotatingPictureBox.Visible)
            {
                Bitmap rotatedImage = RotateImage(originalImage, currentAngle);

                // Disposición segura de la imagen anterior
                Image previousImage = rotatingPictureBox.Image;
                rotatingPictureBox.Image = rotatedImage;
                if (previousImage != null && previousImage != originalImage)
                {
                    previousImage.Dispose();
                }
            }
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        //Struct
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(37, 36, 81);    // Cubo
            public static Color color2 = Color.FromArgb(221, 44, 0);   // Esfera
            public static Color color3 = Color.FromArgb(0, 128, 0);   // Cilindro
            public static Color color4 = Color.FromArgb(255, 193, 7);   // Cono
        }

        //Methods 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(220, 240, 250);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                //Icon Current Button
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.GhostWhite;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            panelDesktop.Tag = childForm;
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

            
            rotatingPictureBox.Visible = false;

        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new Forms.FormCube());
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
            OpenChildForm(new Forms.FormSphere());
        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new Forms.FormCylinder());
        }

        private void coneButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            OpenChildForm(new Forms.FormCone());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null; 
            }

            Reset();

            rotatingPictureBox.Visible = true;
            rotatingPictureBox.BringToFront();

            RotateImage(null, EventArgs.Empty);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            rotationTimer?.Stop();
            if (rotatingPictureBox.Image != null && rotatingPictureBox.Image != originalImage)
                rotatingPictureBox.Image.Dispose();
            originalImage?.Dispose();
            base.OnFormClosing(e);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderbtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = Color.SkyBlue;
            lblTitleChildForm.Text = "Inicio";
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconCloseBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizeBox_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconMinimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
