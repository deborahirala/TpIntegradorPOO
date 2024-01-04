namespace Proyecto_Integrador_Club
{
    partial class frmFactura
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
            btnImprimir = new Button();
            lblNombre = new Label();
            lblComprobante = new Label();
            panel1 = new Panel();
            lblNSocio = new Label();
            lblDNI = new Label();
            lblFechaPago = new Label();
            lblFechaInicio = new Label();
            lblVencimiento = new Label();
            panel2 = new Panel();
            lblMetodoPago = new Label();
            lblMonto = new Label();
            lblSocio = new Label();
            lblCuota = new Label();
            btnVolver = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(474, 285);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobante.Location = new Point(96, 15);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(432, 21);
            lblComprobante.TabIndex = 2;
            lblComprobante.Text = "CLUB DEPORTIVO - COMPROBANTE DE PAGO DE CUOTA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblComprobante);
            panel1.Location = new Point(20, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 52);
            panel1.TabIndex = 3;
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
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(22, 122);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 17);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(333, 50);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(90, 15);
            lblFechaPago.TabIndex = 6;
            lblFechaPago.Text = "Fecha de Pago: ";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(333, 136);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(89, 15);
            lblFechaInicio.TabIndex = 7;
            lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(333, 164);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(126, 15);
            lblVencimiento.TabIndex = 8;
            lblVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMetodoPago);
            panel2.Controls.Add(lblMonto);
            panel2.Controls.Add(lblSocio);
            panel2.Controls.Add(lblCuota);
            panel2.Controls.Add(lblNSocio);
            panel2.Controls.Add(lblVencimiento);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(lblFechaInicio);
            panel2.Controls.Add(lblFechaPago);
            panel2.Controls.Add(lblDNI);
            panel2.Location = new Point(20, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 203);
            panel2.TabIndex = 4;
             // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(333, 106);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 15);
            lblMetodoPago.TabIndex = 12;
            lblMetodoPago.Text = "Metodo de Pago:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(333, 78);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto:";
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
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCuota.Location = new Point(333, 17);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(50, 20);
            lblCuota.TabIndex = 9;
            lblCuota.Text = "Cuota";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(570, 285);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 325);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Comprobante de pago";
            Load += frmFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private Label lblNombre;
        private Label lblComprobante;
        private Panel panel1;
        private Label lblNSocio;
        private Label lblDNI;
        private Label lblFechaPago;
        private Label lblFechaInicio;
        private Label lblVencimiento;
        private Panel panel2;
        private Label lblCuota;
        private Label lblSocio;
        private Label lblMetodoPago;
        private Label lblMonto;
        private Button btnVolver;
    }
}