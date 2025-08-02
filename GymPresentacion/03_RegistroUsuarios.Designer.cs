namespace GymPresentacion
{
    partial class RegsitroUsuarios
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
            PicUsuariosInicio = new PictureBox();
            chkMostrarContrasena1 = new CheckBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuariosInicio).BeginInit();
            SuspendLayout();
            // 
            // lblNombreUusario
            // 
            lblNombreUusario.AutoSize = true;
            lblNombreUusario.BackColor = Color.Transparent;
            lblNombreUusario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUusario.ForeColor = Color.Lavender;
            lblNombreUusario.Location = new Point(886, 182);
            lblNombreUusario.Name = "lblNombreUusario";
            lblNombreUusario.Size = new Size(133, 17);
            lblNombreUusario.TabIndex = 0;
            lblNombreUusario.Text = "Nombre Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.Lavender;
            lblContrasena.Location = new Point(886, 230);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(102, 17);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contrasena ";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.Transparent;
            lblRolUsuario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.Lavender;
            lblRolUsuario.Location = new Point(886, 274);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(97, 17);
            lblRolUsuario.TabIndex = 2;
            lblRolUsuario.Text = "Rol Usuario";
            // 
            // cmbRolUsuario
            // 
            cmbRolUsuario.FormattingEnabled = true;
            cmbRolUsuario.Location = new Point(1012, 272);
            cmbRolUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbRolUsuario.Name = "cmbRolUsuario";
            cmbRolUsuario.Size = new Size(257, 23);
            cmbRolUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(1048, 176);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(221, 23);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtContasena
            // 
            txtContasena.Location = new Point(1012, 225);
            txtContasena.Margin = new Padding(3, 2, 3, 2);
            txtContasena.Name = "txtContasena";
            txtContasena.Size = new Size(257, 23);
            txtContasena.TabIndex = 5;
            txtContasena.UseSystemPasswordChar = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.BackgroundColor = Color.Lavender;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(298, 139);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(464, 317);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.DodgerBlue;
            btnEliminarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.Black;
            btnEliminarUsuario.Location = new Point(316, 460);
            btnEliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(133, 39);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "🗑️ Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.DodgerBlue;
            btnEditarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnEditarUsuario.Location = new Point(487, 460);
            btnEditarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(126, 39);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "✏️ Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.DodgerBlue;
            btnAgregarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAgregarUsuario.Location = new Point(1045, 460);
            btnAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(130, 39);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "➕ Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += BtnAgregar_Click;
            // 
            // btnConsultarUsuario
            // 
            btnConsultarUsuario.BackColor = Color.DodgerBlue;
            btnConsultarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnConsultarUsuario.Location = new Point(640, 460);
            btnConsultarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(122, 39);
            btnConsultarUsuario.TabIndex = 10;
            btnConsultarUsuario.Text = "🔍 Consultar";
            btnConsultarUsuario.UseVisualStyleBackColor = false;
            btnConsultarUsuario.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(316, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 122);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PicUsuariosInicio
            // 
            PicUsuariosInicio.BackColor = Color.Transparent;
            PicUsuariosInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicUsuariosInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicUsuariosInicio.Location = new Point(21, 76);
            PicUsuariosInicio.Margin = new Padding(3, 2, 3, 2);
            PicUsuariosInicio.Name = "PicUsuariosInicio";
            PicUsuariosInicio.Size = new Size(109, 46);
            PicUsuariosInicio.TabIndex = 12;
            PicUsuariosInicio.TabStop = false;
            PicUsuariosInicio.Click += PicUsuarios_Click;
            // 
            // chkMostrarContrasena1
            // 
            chkMostrarContrasena1.AutoSize = true;
            chkMostrarContrasena1.ForeColor = SystemColors.ButtonFace;
            chkMostrarContrasena1.Location = new Point(886, 341);
            chkMostrarContrasena1.Name = "chkMostrarContrasena1";
            chkMostrarContrasena1.Size = new Size(128, 19);
            chkMostrarContrasena1.TabIndex = 14;
            chkMostrarContrasena1.Text = "Mostrar contraseña";
            chkMostrarContrasena1.UseVisualStyleBackColor = true;
            chkMostrarContrasena1.CheckedChanged += chkMostrarContrasena1_CheckedChanged;
            // 
            // btnLimpiar
            // 
            checkActivoUsuario.AutoSize = true;
            checkActivoUsuario.BackColor = Color.Lavender;
            checkActivoUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            checkActivoUsuario.ForeColor = Color.Black;
            checkActivoUsuario.Location = new Point(1157, 448);
            checkActivoUsuario.Name = "checkActivoUsuario";
            checkActivoUsuario.Size = new Size(94, 31);
            checkActivoUsuario.TabIndex = 13;
            checkActivoUsuario.Text = "Activo";
            checkActivoUsuario.UseVisualStyleBackColor = false;
            // 
            // RegsitroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1514, 736);
            Controls.Add(checkActivoUsuario);
            Controls.Add(PicUsuariosInicio);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegsitroUsuarios";
            Text = "RegsitroUsuarios";
            Load += RegsitroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuariosInicio).EndInit();
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
        private PictureBox PicUsuariosInicio;
        private CheckBox chkMostrarContrasena1;
        private Button btnLimpiar;
    }
}