namespace Proyecto_Integrador_Club
{
    partial class frmPrincipal
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
            lblIngreso = new Label();
            btnSalir = new Button();
            btnInscripciones = new Button();
            btnCuotas = new Button();
            btnListados = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 9);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(50, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(382, 232);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.FlatAppearance.BorderColor = Color.Black;
            btnInscripciones.FlatAppearance.BorderSize = 2;
            btnInscripciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscripciones.Location = new Point(90, 25);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(263, 30);
            btnInscripciones.TabIndex = 2;
            btnInscripciones.Text = "Inscripción de Socios / No Socios";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnCuotas
            // 
            btnCuotas.FlatAppearance.BorderColor = Color.Black;
            btnCuotas.FlatAppearance.BorderSize = 2;
            btnCuotas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuotas.Location = new Point(128, 70);
            btnCuotas.Name = "btnCuotas";
            btnCuotas.Size = new Size(187, 30);
            btnCuotas.TabIndex = 3;
            btnCuotas.Text = "Cobro de Cuotas";
            btnCuotas.UseVisualStyleBackColor = true;
            btnCuotas.Click += btnCuotas_Click;
            // 
            // btnListados
            // 
            btnListados.FlatAppearance.BorderColor = Color.Black;
            btnListados.FlatAppearance.BorderSize = 2;
            btnListados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnListados.Location = new Point(128, 115);
            btnListados.Name = "btnListados";
            btnListados.Size = new Size(187, 30);
            btnListados.TabIndex = 4;
            btnListados.Text = "Listado de Vencimientos";
            btnListados.UseVisualStyleBackColor = true;
            btnListados.Click += btnListados_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInscripciones);
            panel1.Controls.Add(btnCuotas);
            panel1.Controls.Add(btnListados);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 173);
            panel1.TabIndex = 6;
             // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 278);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Menú Principal";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnInscripciones;
        private Button btnCuotas;
        private Button btnListados;
        private Panel panel1;
    }
}