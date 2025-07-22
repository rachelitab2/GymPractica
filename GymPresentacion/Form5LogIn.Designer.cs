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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            lblLogin.Location = new Point(494, 566);
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
            lblUsuario.Location = new Point(494, 513);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(98, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 515);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(645, 570);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 4;
            // 
            // Form5LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1286, 754);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Form5LogIn";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}