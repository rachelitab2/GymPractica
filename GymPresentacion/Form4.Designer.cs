namespace GymPresentacion
{
    partial class btnDespliegue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnDespliegue));
            lblPanelPrinciapl = new Label();
            PicPanelMemebresia = new PictureBox();
            PicPanelEntrenador = new PictureBox();
            PicPanelRutina = new PictureBox();
            pictureBox1 = new PictureBox();
            MenuVertical = new Panel();
            pictureBox2 = new PictureBox();
            BarraTitular = new Panel();
            PicCerrarSesion = new PictureBox();
            Despliegue = new PictureBox();
            PicPanelUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicPanelMemebresia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelEntrenador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelRutina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Despliegue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblPanelPrinciapl
            // 
            lblPanelPrinciapl.AutoSize = true;
            lblPanelPrinciapl.BackColor = Color.Transparent;
            lblPanelPrinciapl.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPanelPrinciapl.ForeColor = Color.Lavender;
            lblPanelPrinciapl.Location = new Point(553, 96);
            lblPanelPrinciapl.Name = "lblPanelPrinciapl";
            lblPanelPrinciapl.Size = new Size(517, 73);
            lblPanelPrinciapl.TabIndex = 0;
            lblPanelPrinciapl.Text = "PanelPrincipal";
            // 
            // PicPanelMemebresia
            // 
            PicPanelMemebresia.BackColor = Color.Transparent;
            PicPanelMemebresia.BackgroundImage = Properties.Resources.image_removebg_preview__3_;
            PicPanelMemebresia.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelMemebresia.Location = new Point(81, 241);
            PicPanelMemebresia.Name = "PicPanelMemebresia";
            PicPanelMemebresia.Size = new Size(169, 104);
            PicPanelMemebresia.SizeMode = PictureBoxSizeMode.CenterImage;
            PicPanelMemebresia.TabIndex = 5;
            PicPanelMemebresia.TabStop = false;
            // 
            // PicPanelEntrenador
            // 
            PicPanelEntrenador.BackColor = Color.Transparent;
            PicPanelEntrenador.BackgroundImage = (Image)resources.GetObject("PicPanelEntrenador.BackgroundImage");
            PicPanelEntrenador.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelEntrenador.Cursor = Cursors.Hand;
            PicPanelEntrenador.Location = new Point(81, 360);
            PicPanelEntrenador.Name = "PicPanelEntrenador";
            PicPanelEntrenador.Size = new Size(169, 102);
            PicPanelEntrenador.SizeMode = PictureBoxSizeMode.CenterImage;
            PicPanelEntrenador.TabIndex = 7;
            PicPanelEntrenador.TabStop = false;
            // 
            // PicPanelRutina
            // 
            PicPanelRutina.BackColor = Color.Transparent;
            PicPanelRutina.BackgroundImage = Properties.Resources.image_removebg_preview__5_;
            PicPanelRutina.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelRutina.Cursor = Cursors.Hand;
            PicPanelRutina.Location = new Point(81, 468);
            PicPanelRutina.Name = "PicPanelRutina";
            PicPanelRutina.Size = new Size(169, 103);
            PicPanelRutina.TabIndex = 6;
            PicPanelRutina.TabStop = false;
            PicPanelRutina.Click += PicPanelRutina_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(572, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 436);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackgroundImage = Properties.Resources.Untitled_design__13_;
            MenuVertical.Controls.Add(PicPanelUsuario);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(PicPanelRutina);
            MenuVertical.Controls.Add(PicPanelEntrenador);
            MenuVertical.Controls.Add(PicPanelMemebresia);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(92, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 62);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // BarraTitular
            // 
            BarraTitular.BackgroundImage = Properties.Resources.Untitled_design__13_;
            BarraTitular.Controls.Add(PicCerrarSesion);
            BarraTitular.Controls.Add(Despliegue);
            BarraTitular.Dock = DockStyle.Top;
            BarraTitular.Location = new Point(250, 0);
            BarraTitular.Name = "BarraTitular";
            BarraTitular.Size = new Size(1050, 50);
            BarraTitular.TabIndex = 13;
            // 
            // PicCerrarSesion
            // 
            PicCerrarSesion.BackColor = Color.Transparent;
            PicCerrarSesion.BackgroundImage = Properties.Resources.image_removebg_preview__12_;
            PicCerrarSesion.BackgroundImageLayout = ImageLayout.Zoom;
            PicCerrarSesion.Location = new Point(922, 0);
            PicCerrarSesion.Name = "PicCerrarSesion";
            PicCerrarSesion.Size = new Size(128, 50);
            PicCerrarSesion.TabIndex = 15;
            PicCerrarSesion.TabStop = false;
            PicCerrarSesion.Click += PicCerrarSesion_Click;
            // 
            // Despliegue
            // 
            Despliegue.BackColor = Color.Transparent;
            Despliegue.BackgroundImage = Properties.Resources.image_removebg_preview__10_;
            Despliegue.BackgroundImageLayout = ImageLayout.Zoom;
            Despliegue.Cursor = Cursors.Hand;
            Despliegue.Location = new Point(-3, 0);
            Despliegue.Name = "Despliegue";
            Despliegue.Size = new Size(100, 50);
            Despliegue.TabIndex = 14;
            Despliegue.TabStop = false;
            Despliegue.Click += Despliegue_Click;
            // 
            // PicPanelUsuario
            // 
            PicPanelUsuario.BackColor = Color.Transparent;
            PicPanelUsuario.BackgroundImage = Properties.Resources.image_removebg_preview__13_;
            PicPanelUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            PicPanelUsuario.Location = new Point(82, 142);
            PicPanelUsuario.Name = "PicPanelUsuario";
            PicPanelUsuario.Size = new Size(168, 93);
            PicPanelUsuario.TabIndex = 15;
            PicPanelUsuario.TabStop = false;
            PicPanelUsuario.Click += PicPanelUsuario_Click;
            // 
            // btnDespliegue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1300, 650);
            Controls.Add(BarraTitular);
            Controls.Add(MenuVertical);
            Controls.Add(pictureBox1);
            Controls.Add(lblPanelPrinciapl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "btnDespliegue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)PicPanelMemebresia).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelEntrenador).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelRutina).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraTitular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)Despliegue).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPanelUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPanelPrinciapl;
        private PictureBox PicPanelMemebresia;
        private PictureBox PicPanelRutina;
        private PictureBox PicPanelEntrenador;
        private PictureBox pictureBox1;
        private Panel MenuVertical;
        private Panel BarraTitular;
        private PictureBox Despliegue;
        private PictureBox pictureBox2;
        private PictureBox PicCerrarSesion;
        private PictureBox PicPanelUsuario;
    }
}