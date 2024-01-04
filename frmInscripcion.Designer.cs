namespace Proyecto_Integrador_Club
{
    partial class frmInscripcion
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            dtpFechaInscripcion = new DateTimePicker();
            lblFechaInscripcion = new Label();
            chkAptoFisico = new CheckBox();
            rbtSocio = new RadioButton();
            rbtNoSocio = new RadioButton();
            grbTipoUsuario = new GroupBox();
            btnInscribir = new Button();
            btnVolver = new Button();
            panel1 = new Panel();
            btnCarnet = new Button();
            btnNuevaInscripcion = new Button();
            grbTipoUsuario.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(265, 107);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 3;
             txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(265, 89);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Location = new Point(265, 168);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(200, 23);
            dtpFechaInscripcion.TabIndex = 6;
            // 
            // lblFechaInscripcion
            // 
            lblFechaInscripcion.AutoSize = true;
            lblFechaInscripcion.Location = new Point(265, 150);
            lblFechaInscripcion.Name = "lblFechaInscripcion";
            lblFechaInscripcion.Size = new Size(115, 15);
            lblFechaInscripcion.TabIndex = 7;
            lblFechaInscripcion.Text = "Fecha de Inscripción";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(17, 218);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(85, 19);
            chkAptoFisico.TabIndex = 9;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // rbtSocio
            // 
            rbtSocio.AutoSize = true;
            rbtSocio.Checked = true;
            rbtSocio.Location = new Point(31, 22);
            rbtSocio.Name = "rbtSocio";
            rbtSocio.Size = new Size(54, 19);
            rbtSocio.TabIndex = 10;
            rbtSocio.TabStop = true;
            rbtSocio.Text = "Socio";
            rbtSocio.UseVisualStyleBackColor = true;
            rbtSocio.CheckedChanged += rbtSocio_CheckedChanged;
            // 
            // rbtNoSocio
            // 
            rbtNoSocio.AutoSize = true;
            rbtNoSocio.Location = new Point(117, 22);
            rbtNoSocio.Name = "rbtNoSocio";
            rbtNoSocio.Size = new Size(73, 19);
            rbtNoSocio.TabIndex = 11;
            rbtNoSocio.Text = "No Socio";
            rbtNoSocio.UseVisualStyleBackColor = true;
            rbtNoSocio.CheckedChanged += rbtNoSocio_CheckedChanged;
            // 
            // grbTipoUsuario
            // 
            grbTipoUsuario.Controls.Add(rbtNoSocio);
            grbTipoUsuario.Controls.Add(rbtSocio);
            grbTipoUsuario.Location = new Point(17, 17);
            grbTipoUsuario.Name = "grbTipoUsuario";
            grbTipoUsuario.Size = new Size(209, 55);
            grbTipoUsuario.TabIndex = 12;
            grbTipoUsuario.TabStop = false;
            grbTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(251, 262);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(97, 32);
            btnInscribir.TabIndex = 13;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(435, 346);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCarnet);
            panel1.Controls.Add(btnInscribir);
            panel1.Controls.Add(grbTipoUsuario);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblFechaInscripcion);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(dtpFechaInscripcion);
            panel1.Controls.Add(chkAptoFisico);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(30, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 315);
            panel1.TabIndex = 16;
            // 
            // btnCarnet
            // 
            btnCarnet.Enabled = false;
            btnCarnet.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarnet.Location = new Point(138, 262);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(97, 32);
            btnCarnet.TabIndex = 14;
            btnCarnet.Text = "Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // btnNuevaInscripcion
            // 
            btnNuevaInscripcion.Location = new Point(309, 346);
            btnNuevaInscripcion.Name = "btnNuevaInscripcion";
            btnNuevaInscripcion.Size = new Size(120, 23);
            btnNuevaInscripcion.TabIndex = 17;
            btnNuevaInscripcion.Text = "Nueva Inscripción";
            btnNuevaInscripcion.UseVisualStyleBackColor = true;
            btnNuevaInscripcion.Click += btnNuevaInscripcion_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 389);
            Controls.Add(btnNuevaInscripcion);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Inscripción";
            Load += frmInscripcion_Load;
            grbTipoUsuario.ResumeLayout(false);
            grbTipoUsuario.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtEmail;
        private Label lblEmail;
        private DateTimePicker dtpFechaInscripcion;
        private Label lblFechaInscripcion;
        private CheckBox chkAptoFisico;
        private RadioButton rbtSocio;
        private RadioButton rbtNoSocio;
        private GroupBox grbTipoUsuario;
        private Button btnInscribir;
        private Button btnVolver;
        private Panel panel1;
        private Button btnNuevaInscripcion;
        private Button btnCarnet;
    }
}