namespace GymPresentacion
{
    partial class LogIn
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
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            cmbRol = new ComboBox();
            btnAcceder = new Button();
            lblTipoAcceso = new Label();
            panelLogin = new Panel();
            PicVerContrasena = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicVerContrasena).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(53, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Lavender;
            lblLogin.Location = new Point(467, 122);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(138, 25);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Contraseña";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Lavender;
            lblUsuario.Location = new Point(467, 38);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(98, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(467, 80);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.Size = new Size(243, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Location = new Point(467, 156);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.RightToLeft = RightToLeft.No;
            txtContrasena.Size = new Size(243, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(467, 238);
            cmbRol.Name = "cmbRol";
            cmbRol.RightToLeft = RightToLeft.No;
            cmbRol.Size = new Size(243, 28);
            cmbRol.TabIndex = 5;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.DodgerBlue;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(467, 304);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(243, 27);
            btnAcceder.TabIndex = 6;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblTipoAcceso
            // 
            lblTipoAcceso.AutoSize = true;
            lblTipoAcceso.BackColor = Color.Transparent;
            lblTipoAcceso.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblTipoAcceso.ForeColor = Color.Lavender;
            lblTipoAcceso.Location = new Point(467, 195);
            lblTipoAcceso.Name = "lblTipoAcceso";
            lblTipoAcceso.Size = new Size(140, 25);
            lblTipoAcceso.TabIndex = 7;
            lblTipoAcceso.Text = "TipoAcceso";
            lblTipoAcceso.Click += lblTipoAcceso_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(PicVerContrasena);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(btnAcceder);
            panelLogin.Controls.Add(lblTipoAcceso);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(cmbRol);
            panelLogin.Location = new Point(2, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(877, 387);
            panelLogin.TabIndex = 8;
            // 
            // PicVerContrasena
            // 
            PicVerContrasena.BackColor = Color.Transparent;
            PicVerContrasena.Image = Properties.Resources.image_removebg_preview__17_;
            PicVerContrasena.Location = new Point(716, 156);
            PicVerContrasena.Name = "PicVerContrasena";
            PicVerContrasena.Size = new Size(77, 44);
            PicVerContrasena.SizeMode = PictureBoxSizeMode.Zoom;
            PicVerContrasena.TabIndex = 9;
            PicVerContrasena.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(881, 395);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += Form5LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicVerContrasena).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private ComboBox cmbRol;
        private Button btnAcceder;
        private Label lblTipoAcceso;
        private Panel panelLogin;
        private PictureBox PicVerContrasena;
    }
}