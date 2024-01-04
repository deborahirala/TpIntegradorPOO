namespace Proyecto_Integrador_Club
{
    partial class frmCarnet
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
            btnVolver = new Button();
            panel2 = new Panel();
            lblSocio = new Label();
            lblNSocio = new Label();
            lblNombre = new Label();
            lblFechaInicio = new Label();
            lblDNI = new Label();
            panel1 = new Panel();
            lblComprobante = new Label();
            btnImprimir = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(342, 279);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblSocio);
            panel2.Controls.Add(lblNSocio);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(lblFechaInicio);
            panel2.Controls.Add(lblDNI);
            panel2.Location = new Point(12, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 203);
            panel2.TabIndex = 8;
             // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(22, 17);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(46, 20);
            lblSocio.TabIndex = 10;
            lblSocio.Text = "Socio";
            // 
            // lblNSocio
            // 
            lblNSocio.AutoSize = true;
            lblNSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNSocio.Location = new Point(22, 54);
            lblNSocio.Name = "lblNSocio";
            lblNSocio.Size = new Size(34, 17);
            lblNSocio.TabIndex = 4;
            lblNSocio.Text = "Nro:";
             // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
             // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(22, 162);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(118, 15);
            lblFechaInicio.TabIndex = 7;
            lblFechaInicio.Text = "Fecha de Inscripción:";
             // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(22, 126);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 17);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
             // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblComprobante);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 52);
            panel1.TabIndex = 7;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobante.Location = new Point(92, 14);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(220, 21);
            lblComprobante.TabIndex = 2;
            lblComprobante.Text = "CLUB DEPORTIVO - CARNET";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(250, 279);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 313);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Carnet";
            Load += frmCarnet_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Panel panel2;
        private Label lblSocio;
        private Label lblNSocio;
        private Label lblNombre;
        private Label lblFechaInicio;
        private Label lblDNI;
        private Panel panel1;
        private Label lblComprobante;
        private Button btnImprimir;
    }
}