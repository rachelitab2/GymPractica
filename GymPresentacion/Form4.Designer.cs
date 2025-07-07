namespace GymPresentacion
{
    partial class Form4
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
            lblPanelPrinciapl = new Label();
            pictureBox1 = new PictureBox();
            PanelMemebresia = new Panel();
            PicPanelMemebresia = new PictureBox();
            PanelEntrenador = new Panel();
            PicPanelEntrenador = new PictureBox();
            PanelRutina = new Panel();
            PicPanelRutina = new PictureBox();
            lblTituloMem = new Label();
            lblDescripcionMem = new Label();
            lblTituloEntrenador = new Label();
            lblDescripcionEntrenador = new Label();
            lblTituloRutina = new Label();
            lblDescricionRutina = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMemebresia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPanelMemebresia).BeginInit();
            PanelEntrenador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPanelEntrenador).BeginInit();
            PanelRutina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPanelRutina).BeginInit();
            SuspendLayout();
            // 
            // lblPanelPrinciapl
            // 
            lblPanelPrinciapl.AutoSize = true;
            lblPanelPrinciapl.BackColor = Color.Transparent;
            lblPanelPrinciapl.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPanelPrinciapl.ForeColor = Color.IndianRed;
            lblPanelPrinciapl.Location = new Point(533, 236);
            lblPanelPrinciapl.Name = "lblPanelPrinciapl";
            lblPanelPrinciapl.Size = new Size(316, 52);
            lblPanelPrinciapl.TabIndex = 0;
            lblPanelPrinciapl.Text = "PanelPrincipal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources._7;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(511, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 198);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PanelMemebresia
            // 
            PanelMemebresia.BackColor = Color.Transparent;
            PanelMemebresia.Controls.Add(PicPanelMemebresia);
            PanelMemebresia.Cursor = Cursors.Hand;
            PanelMemebresia.Location = new Point(97, 324);
            PanelMemebresia.Name = "PanelMemebresia";
            PanelMemebresia.Size = new Size(250, 180);
            PanelMemebresia.TabIndex = 2;
            // 
            // PicPanelMemebresia
            // 
            PicPanelMemebresia.BackColor = Color.Transparent;
            PicPanelMemebresia.BackgroundImage = Properties.Resources._10;
            PicPanelMemebresia.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelMemebresia.Location = new Point(-112, -38);
            PicPanelMemebresia.Name = "PicPanelMemebresia";
            PicPanelMemebresia.Size = new Size(488, 247);
            PicPanelMemebresia.SizeMode = PictureBoxSizeMode.CenterImage;
            PicPanelMemebresia.TabIndex = 5;
            PicPanelMemebresia.TabStop = false;
            // 
            // PanelEntrenador
            // 
            PanelEntrenador.BackColor = Color.Transparent;
            PanelEntrenador.Controls.Add(PicPanelEntrenador);
            PanelEntrenador.Cursor = Cursors.Hand;
            PanelEntrenador.Location = new Point(542, 324);
            PanelEntrenador.Name = "PanelEntrenador";
            PanelEntrenador.Size = new Size(250, 180);
            PanelEntrenador.TabIndex = 3;
            // 
            // PicPanelEntrenador
            // 
            PicPanelEntrenador.BackColor = Color.Transparent;
            PicPanelEntrenador.BackgroundImage = Properties.Resources._8__1_;
            PicPanelEntrenador.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelEntrenador.Cursor = Cursors.Hand;
            PicPanelEntrenador.Location = new Point(-120, -38);
            PicPanelEntrenador.Name = "PicPanelEntrenador";
            PicPanelEntrenador.Size = new Size(520, 254);
            PicPanelEntrenador.SizeMode = PictureBoxSizeMode.CenterImage;
            PicPanelEntrenador.TabIndex = 7;
            PicPanelEntrenador.TabStop = false;
            // 
            // PanelRutina
            // 
            PanelRutina.BackColor = Color.Transparent;
            PanelRutina.Controls.Add(PicPanelRutina);
            PanelRutina.Cursor = Cursors.Hand;
            PanelRutina.Location = new Point(989, 324);
            PanelRutina.Name = "PanelRutina";
            PanelRutina.Size = new Size(250, 180);
            PanelRutina.TabIndex = 4;
            // 
            // PicPanelRutina
            // 
            PicPanelRutina.BackColor = Color.Transparent;
            PicPanelRutina.BackgroundImage = Properties.Resources._9__1_;
            PicPanelRutina.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelRutina.Cursor = Cursors.Hand;
            PicPanelRutina.Location = new Point(-116, -31);
            PicPanelRutina.Name = "PicPanelRutina";
            PicPanelRutina.Size = new Size(488, 261);
            PicPanelRutina.TabIndex = 6;
            PicPanelRutina.TabStop = false;
            PicPanelRutina.Click += PicPanelRutina_Click;
            // 
            // lblTituloMem
            // 
            lblTituloMem.AutoSize = true;
            lblTituloMem.BackColor = Color.Transparent;
            lblTituloMem.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMem.ForeColor = Color.IndianRed;
            lblTituloMem.Location = new Point(152, 515);
            lblTituloMem.Name = "lblTituloMem";
            lblTituloMem.Size = new Size(146, 32);
            lblTituloMem.TabIndex = 5;
            lblTituloMem.Text = "Membresia";
            // 
            // lblDescripcionMem
            // 
            lblDescripcionMem.AutoSize = true;
            lblDescripcionMem.BackColor = Color.Transparent;
            lblDescripcionMem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcionMem.ForeColor = Color.WhiteSmoke;
            lblDescripcionMem.Location = new Point(97, 543);
            lblDescripcionMem.Name = "lblDescripcionMem";
            lblDescripcionMem.Size = new Size(260, 19);
            lblDescripcionMem.TabIndex = 6;
            lblDescripcionMem.Text = "Gestionar membresías de clientes";
            // 
            // lblTituloEntrenador
            // 
            lblTituloEntrenador.AutoSize = true;
            lblTituloEntrenador.BackColor = Color.Transparent;
            lblTituloEntrenador.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEntrenador.ForeColor = Color.IndianRed;
            lblTituloEntrenador.Location = new Point(595, 515);
            lblTituloEntrenador.Name = "lblTituloEntrenador";
            lblTituloEntrenador.Size = new Size(175, 32);
            lblTituloEntrenador.TabIndex = 7;
            lblTituloEntrenador.Text = "Entrenadores";
            // 
            // lblDescripcionEntrenador
            // 
            lblDescripcionEntrenador.AutoSize = true;
            lblDescripcionEntrenador.BackColor = Color.Transparent;
            lblDescripcionEntrenador.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcionEntrenador.ForeColor = Color.WhiteSmoke;
            lblDescripcionEntrenador.Location = new Point(578, 547);
            lblDescripcionEntrenador.Name = "lblDescripcionEntrenador";
            lblDescripcionEntrenador.Size = new Size(198, 20);
            lblDescripcionEntrenador.TabIndex = 8;
            lblDescripcionEntrenador.Text = "Gestionar Entrenadores ";
            // 
            // lblTituloRutina
            // 
            lblTituloRutina.AutoSize = true;
            lblTituloRutina.BackColor = Color.Transparent;
            lblTituloRutina.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRutina.ForeColor = Color.IndianRed;
            lblTituloRutina.Location = new Point(1071, 515);
            lblTituloRutina.Name = "lblTituloRutina";
            lblTituloRutina.Size = new Size(108, 32);
            lblTituloRutina.TabIndex = 9;
            lblTituloRutina.Text = "Rutinas";
            // 
            // lblDescricionRutina
            // 
            lblDescricionRutina.AutoSize = true;
            lblDescricionRutina.BackColor = Color.Transparent;
            lblDescricionRutina.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricionRutina.ForeColor = Color.WhiteSmoke;
            lblDescricionRutina.Location = new Point(1049, 543);
            lblDescricionRutina.Name = "lblDescricionRutina";
            lblDescricionRutina.Size = new Size(150, 20);
            lblDescricionRutina.TabIndex = 10;
            lblDescricionRutina.Text = "Gestionar Rutinas";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__6_;
            ClientSize = new Size(1280, 646);
            Controls.Add(lblDescricionRutina);
            Controls.Add(lblTituloRutina);
            Controls.Add(lblDescripcionEntrenador);
            Controls.Add(lblTituloEntrenador);
            Controls.Add(lblDescripcionMem);
            Controls.Add(lblTituloMem);
            Controls.Add(PanelRutina);
            Controls.Add(PanelEntrenador);
            Controls.Add(PanelMemebresia);
            Controls.Add(pictureBox1);
            Controls.Add(lblPanelPrinciapl);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMemebresia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicPanelMemebresia).EndInit();
            PanelEntrenador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicPanelEntrenador).EndInit();
            PanelRutina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicPanelRutina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPanelPrinciapl;
        private PictureBox pictureBox1;
        private Panel PanelMemebresia;
        private Panel PanelEntrenador;
        private Panel PanelRutina;
        private PictureBox PicPanelMemebresia;
        private PictureBox PicPanelRutina;
        private PictureBox PicPanelEntrenador;
        private Label lblTituloMem;
        private Label lblDescripcionMem;
        private Label lblTituloEntrenador;
        private Label lblDescripcionEntrenador;
        private Label lblTituloRutina;
        private Label lblDescricionRutina;
    }
}