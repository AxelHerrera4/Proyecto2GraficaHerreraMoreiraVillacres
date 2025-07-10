namespace Visualizador3D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.coneButton = new FontAwesome.Sharp.IconButton();
            this.cylinderButton = new FontAwesome.Sharp.IconButton();
            this.sphereButton = new FontAwesome.Sharp.IconButton();
            this.cubeButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMinimizeBox = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximizeBox = new FontAwesome.Sharp.IconPictureBox();
            this.iconCloseBox = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMenu.Controls.Add(this.coneButton);
            this.panelMenu.Controls.Add(this.cylinderButton);
            this.panelMenu.Controls.Add(this.sphereButton);
            this.panelMenu.Controls.Add(this.cubeButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 741);
            this.panelMenu.TabIndex = 0;
            // 
            // coneButton
            // 
            this.coneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.coneButton.FlatAppearance.BorderSize = 0;
            this.coneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coneButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coneButton.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.coneButton.IconColor = System.Drawing.Color.Black;
            this.coneButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.coneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coneButton.Location = new System.Drawing.Point(0, 320);
            this.coneButton.Name = "coneButton";
            this.coneButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.coneButton.Size = new System.Drawing.Size(220, 60);
            this.coneButton.TabIndex = 4;
            this.coneButton.Text = "Cono";
            this.coneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.coneButton.UseVisualStyleBackColor = true;
            this.coneButton.Click += new System.EventHandler(this.coneButton_Click);
            // 
            // cylinderButton
            // 
            this.cylinderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cylinderButton.FlatAppearance.BorderSize = 0;
            this.cylinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cylinderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cylinderButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.cylinderButton.IconColor = System.Drawing.Color.Black;
            this.cylinderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cylinderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cylinderButton.Location = new System.Drawing.Point(0, 260);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cylinderButton.Size = new System.Drawing.Size(220, 60);
            this.cylinderButton.TabIndex = 3;
            this.cylinderButton.Text = "Cilindro";
            this.cylinderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cylinderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinderButton_Click);
            // 
            // sphereButton
            // 
            this.sphereButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sphereButton.FlatAppearance.BorderSize = 0;
            this.sphereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sphereButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sphereButton.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            this.sphereButton.IconColor = System.Drawing.Color.Black;
            this.sphereButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sphereButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sphereButton.Location = new System.Drawing.Point(0, 200);
            this.sphereButton.Name = "sphereButton";
            this.sphereButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.sphereButton.Size = new System.Drawing.Size(220, 60);
            this.sphereButton.TabIndex = 2;
            this.sphereButton.Text = "Esfera";
            this.sphereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sphereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sphereButton.UseVisualStyleBackColor = true;
            this.sphereButton.Click += new System.EventHandler(this.sphereButton_Click);
            // 
            // cubeButton
            // 
            this.cubeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cubeButton.FlatAppearance.BorderSize = 0;
            this.cubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cubeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cubeButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.cubeButton.IconColor = System.Drawing.Color.Black;
            this.cubeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cubeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cubeButton.Location = new System.Drawing.Point(0, 140);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cubeButton.Size = new System.Drawing.Size(220, 60);
            this.cubeButton.TabIndex = 1;
            this.cubeButton.Text = "Cubo";
            this.cubeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cubeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Visualizador3D.Properties.Resources._3D_Logo_PNG_Pic;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 115);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.GhostWhite;
            this.panelTitleBar.Controls.Add(this.iconMinimizeBox);
            this.panelTitleBar.Controls.Add(this.iconMaximizeBox);
            this.panelTitleBar.Controls.Add(this.iconCloseBox);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1029, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconMinimizeBox
            // 
            this.iconMinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizeBox.BackColor = System.Drawing.Color.GhostWhite;
            this.iconMinimizeBox.ForeColor = System.Drawing.Color.Black;
            this.iconMinimizeBox.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimizeBox.IconColor = System.Drawing.Color.Black;
            this.iconMinimizeBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimizeBox.IconSize = 24;
            this.iconMinimizeBox.Location = new System.Drawing.Point(939, 0);
            this.iconMinimizeBox.Name = "iconMinimizeBox";
            this.iconMinimizeBox.Size = new System.Drawing.Size(32, 32);
            this.iconMinimizeBox.TabIndex = 4;
            this.iconMinimizeBox.TabStop = false;
            this.iconMinimizeBox.Click += new System.EventHandler(this.iconMinimizeBox_Click);
            // 
            // iconMaximizeBox
            // 
            this.iconMaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizeBox.BackColor = System.Drawing.Color.GhostWhite;
            this.iconMaximizeBox.ForeColor = System.Drawing.Color.Black;
            this.iconMaximizeBox.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximizeBox.IconColor = System.Drawing.Color.Black;
            this.iconMaximizeBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximizeBox.IconSize = 24;
            this.iconMaximizeBox.Location = new System.Drawing.Point(968, 0);
            this.iconMaximizeBox.Name = "iconMaximizeBox";
            this.iconMaximizeBox.Size = new System.Drawing.Size(32, 32);
            this.iconMaximizeBox.TabIndex = 3;
            this.iconMaximizeBox.TabStop = false;
            this.iconMaximizeBox.Click += new System.EventHandler(this.iconMaximizeBox_Click);
            // 
            // iconCloseBox
            // 
            this.iconCloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCloseBox.BackColor = System.Drawing.Color.GhostWhite;
            this.iconCloseBox.ForeColor = System.Drawing.Color.Black;
            this.iconCloseBox.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCloseBox.IconColor = System.Drawing.Color.Black;
            this.iconCloseBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCloseBox.IconSize = 24;
            this.iconCloseBox.Location = new System.Drawing.Point(997, 0);
            this.iconCloseBox.Name = "iconCloseBox";
            this.iconCloseBox.Size = new System.Drawing.Size(32, 32);
            this.iconCloseBox.TabIndex = 2;
            this.iconCloseBox.TabStop = false;
            this.iconCloseBox.Click += new System.EventHandler(this.iconCloseBox_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitleChildForm.Location = new System.Drawing.Point(68, 25);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(71, 32);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.SkyBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.SkyBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 35;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(27, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(35, 36);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.GhostWhite;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1029, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1029, 651);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Visualizador3D.Properties.Resources._3D_Logo_PNG_Pic;
            this.pictureBox1.Location = new System.Drawing.Point(345, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 741);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton cubeButton;
        private FontAwesome.Sharp.IconButton coneButton;
        private FontAwesome.Sharp.IconButton cylinderButton;
        private FontAwesome.Sharp.IconButton sphereButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconCloseBox;
        private FontAwesome.Sharp.IconPictureBox iconMinimizeBox;
        private FontAwesome.Sharp.IconPictureBox iconMaximizeBox;
    }
}

