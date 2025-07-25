namespace GymPresentacion
{
    partial class Form6Usuarios
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
            lblNombreUusario = new Label();
            lblContrasena = new Label();
            lblRolUsuario = new Label();
            cmbRolUsuario = new ComboBox();
            txtNombreUsuario = new TextBox();
            txtContasena = new TextBox();
            dgvUsuarios = new DataGridView();
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            btnConsultarUsuario = new Button();
            pictureBox1 = new PictureBox();
            PicUsuarios = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblNombreUusario
            // 
            lblNombreUusario.AutoSize = true;
            lblNombreUusario.BackColor = Color.Transparent;
            lblNombreUusario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUusario.ForeColor = Color.Lavender;
            lblNombreUusario.Location = new Point(1013, 242);
            lblNombreUusario.Name = "lblNombreUusario";
            lblNombreUusario.Size = new Size(163, 20);
            lblNombreUusario.TabIndex = 0;
            lblNombreUusario.Text = "Nombre Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.Lavender;
            lblContrasena.Location = new Point(1013, 307);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(122, 20);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contrasena ";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.Transparent;
            lblRolUsuario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.Lavender;
            lblRolUsuario.Location = new Point(1013, 365);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(119, 20);
            lblRolUsuario.TabIndex = 2;
            lblRolUsuario.Text = "Rol Usuario";
            // 
            // cmbRolUsuario
            // 
            cmbRolUsuario.FormattingEnabled = true;
            cmbRolUsuario.Location = new Point(1157, 363);
            cmbRolUsuario.Name = "cmbRolUsuario";
            cmbRolUsuario.Size = new Size(293, 28);
            cmbRolUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(1198, 235);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(252, 27);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtContasena
            // 
            txtContasena.Location = new Point(1157, 300);
            txtContasena.Name = "txtContasena";
            txtContasena.Size = new Size(293, 27);
            txtContasena.TabIndex = 5;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.BackgroundColor = Color.Black;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(54, 170);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(817, 423);
            dgvUsuarios.TabIndex = 6;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.DodgerBlue;
            btnEliminarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.Black;
            btnEliminarUsuario.Location = new Point(361, 614);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(152, 52);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.DodgerBlue;
            btnEditarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnEditarUsuario.Location = new Point(557, 614);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(144, 52);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.DodgerBlue;
            btnAgregarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAgregarUsuario.Location = new Point(1194, 614);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(149, 52);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += BtnAgregar_Click;
            // 
            // btnConsultarUsuario
            // 
            btnConsultarUsuario.BackColor = Color.DodgerBlue;
            btnConsultarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnConsultarUsuario.Location = new Point(732, 614);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(139, 52);
            btnConsultarUsuario.TabIndex = 10;
            btnConsultarUsuario.Text = "Consultar";
            btnConsultarUsuario.UseVisualStyleBackColor = false;
            btnConsultarUsuario.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(675, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 161);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PicUsuarios
            // 
            PicUsuarios.BackColor = Color.Transparent;
            PicUsuarios.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicUsuarios.BackgroundImageLayout = ImageLayout.Zoom;
            PicUsuarios.Location = new Point(24, 102);
            PicUsuarios.Name = "PicUsuarios";
            PicUsuarios.Size = new Size(125, 62);
            PicUsuarios.TabIndex = 12;
            PicUsuarios.TabStop = false;
            PicUsuarios.Click += PicUsuarios_Click;
            // 
            // Form6Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1514, 736);
            Controls.Add(PicUsuarios);
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtContasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(cmbRolUsuario);
            Controls.Add(lblRolUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblNombreUusario);
            Name = "Form6Usuarios";
            Text = "Form6Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUusario;
        private Label lblContrasena;
        private Label lblRolUsuario;
        private ComboBox cmbRolUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContasena;
        private DataGridView dgvUsuarios;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private Button btnConsultarUsuario;
        private PictureBox pictureBox1;
        private PictureBox PicUsuarios;
    }
}