namespace Proyecto_Integrador_Club
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnSalir = new Button();
            panel2 = new Panel();
            txtPuerto = new TextBox();
            label7 = new Label();
            txtServidor = new TextBox();
            label5 = new Label();
            txtBD = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnConectar = new Button();
            txtPasswordBD = new TextBox();
            label3 = new Label();
            txtUsuarioBD = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(378, 53);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 41);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 53);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(208, 53);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(29, 71);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "Admin";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(208, 71);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(144, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "1234";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 11);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 5;
            label1.Text = "Ingreso al sistema";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(15, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 118);
            panel1.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(494, 366);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtPuerto);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtServidor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtBD);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnConectar);
            panel2.Controls.Add(txtPasswordBD);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsuarioBD);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(15, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 201);
            panel2.TabIndex = 8;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(384, 76);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(144, 23);
            txtPuerto.TabIndex = 11;
            txtPuerto.Text = "3306";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 58);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Puerto";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(208, 76);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(144, 23);
            txtServidor.TabIndex = 9;
            txtServidor.Text = "localhost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 58);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "Base de Datos";
            // 
            // txtBD
            // 
            txtBD.Location = new Point(29, 76);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(144, 23);
            txtBD.TabIndex = 8;
            txtBD.Text = "Proyecto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 58);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 7;
            label6.Text = "Servidor";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 14);
            label2.Name = "label2";
            label2.Size = new Size(297, 30);
            label2.TabIndex = 5;
            label2.Text = "Conexión a la Base de Datos";
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConectar.Location = new Point(384, 123);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(144, 41);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtPasswordBD
            // 
            txtPasswordBD.Location = new Point(208, 141);
            txtPasswordBD.Name = "txtPasswordBD";
            txtPasswordBD.Size = new Size(144, 23);
            txtPasswordBD.TabIndex = 4;
            txtPasswordBD.Text = "1234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Usuario";
            // 
            // txtUsuarioBD
            // 
            txtUsuarioBD.Location = new Point(29, 141);
            txtUsuarioBD.Name = "txtUsuarioBD";
            txtUsuarioBD.Size = new Size(144, 23);
            txtUsuarioBD.TabIndex = 3;
            txtUsuarioBD.Text = "root";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 123);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 402);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Ingreso al sistema";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label1;
        private Panel panel1;
        private Button btnSalir;
        private Panel panel2;
        private Label label2;
        private Button btnConectar;
        private TextBox txtPasswordBD;
        private Label label3;
        private TextBox txtUsuarioBD;
        private Label label4;
        private TextBox txtPuerto;
        private Label label7;
        private TextBox txtServidor;
        private Label label5;
        private TextBox txtBD;
        private Label label6;
    }
}