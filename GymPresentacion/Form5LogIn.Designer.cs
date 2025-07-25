namespace GymPresentacion
{
    partial class Form5LogIn
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(398, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 382);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Lavender;
            lblLogin.Location = new Point(496, 526);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(138, 25);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Lavender;
            lblUsuario.Location = new Point(506, 475);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(98, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(665, 477);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(243, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(665, 528);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(243, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(645, 580);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(263, 28);
            cmbRol.TabIndex = 5;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.DodgerBlue;
            btnAcceder.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(665, 646);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(132, 41);
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
            lblTipoAcceso.Location = new Point(494, 578);
            lblTipoAcceso.Name = "lblTipoAcceso";
            lblTipoAcceso.Size = new Size(140, 25);
            lblTipoAcceso.TabIndex = 7;
            lblTipoAcceso.Text = "TipoAcceso";
            // 
            // Form5LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1286, 754);
            Controls.Add(lblTipoAcceso);
            Controls.Add(btnAcceder);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Form5LogIn";
            Text = "Form2";
            Load += Form5LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}