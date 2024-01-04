namespace Proyecto_Integrador_Club
{
    partial class frmCuotas
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
            grbTipoUsuario = new GroupBox();
            rbtNoSocio = new RadioButton();
            rbtSocio = new RadioButton();
            panel1 = new Panel();
            grbCuota = new GroupBox();
            lblFechaInicio = new Label();
            lblFechaVencimiento = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaVencimiento = new DateTimePicker();
            btnComprobante = new Button();
            lblSocio = new Label();
            cbxNSocio = new ComboBox();
            btnCobrar = new Button();
            txtMonto = new TextBox();
            grbMetodoPago = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            dtpFechaPago = new DateTimePicker();
            lblFechaPago = new Label();
            lblMonto = new Label();
            btnVolver = new Button();
            btnNuevoCobro = new Button();
            grbTipoUsuario.SuspendLayout();
            panel1.SuspendLayout();
            grbCuota.SuspendLayout();
            grbMetodoPago.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipoUsuario
            // 
            grbTipoUsuario.Controls.Add(rbtNoSocio);
            grbTipoUsuario.Controls.Add(rbtSocio);
            grbTipoUsuario.Location = new Point(18, 11);
            grbTipoUsuario.Name = "grbTipoUsuario";
            grbTipoUsuario.Size = new Size(200, 55);
            grbTipoUsuario.TabIndex = 13;
            grbTipoUsuario.TabStop = false;
            grbTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // rbtNoSocio
            // 
            rbtNoSocio.AutoSize = true;
            rbtNoSocio.Location = new Point(107, 22);
            rbtNoSocio.Name = "rbtNoSocio";
            rbtNoSocio.Size = new Size(73, 19);
            rbtNoSocio.TabIndex = 11;
            rbtNoSocio.Text = "No Socio";
            rbtNoSocio.UseVisualStyleBackColor = true;
            rbtNoSocio.CheckedChanged += rbtNoSocio_CheckedChanged;
            // 
            // rbtSocio
            // 
            rbtSocio.AutoSize = true;
            rbtSocio.Checked = true;
            rbtSocio.Location = new Point(21, 22);
            rbtSocio.Name = "rbtSocio";
            rbtSocio.Size = new Size(54, 19);
            rbtSocio.TabIndex = 10;
            rbtSocio.TabStop = true;
            rbtSocio.Text = "Socio";
            rbtSocio.UseVisualStyleBackColor = true;
            rbtSocio.CheckedChanged += rbtSocio_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(grbCuota);
            panel1.Controls.Add(btnComprobante);
            panel1.Controls.Add(lblSocio);
            panel1.Controls.Add(cbxNSocio);
            panel1.Controls.Add(btnCobrar);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(grbMetodoPago);
            panel1.Controls.Add(dtpFechaPago);
            panel1.Controls.Add(lblFechaPago);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(grbTipoUsuario);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 369);
            panel1.TabIndex = 14;
             // 
            // grbCuota
            // 
            grbCuota.Controls.Add(lblFechaInicio);
            grbCuota.Controls.Add(lblFechaVencimiento);
            grbCuota.Controls.Add(dtpFechaInicio);
            grbCuota.Controls.Add(dtpFechaVencimiento);
            grbCuota.Location = new Point(249, 133);
            grbCuota.Name = "grbCuota";
            grbCuota.Size = new Size(228, 169);
            grbCuota.TabIndex = 30;
            grbCuota.TabStop = false;
            grbCuota.Text = "Cuota";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(14, 33);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 15);
            lblFechaInicio.TabIndex = 18;
            lblFechaInicio.Text = "Fecha de Inicio";
            lblFechaInicio.Click += lblFechaInicio_Click;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(14, 98);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(123, 15);
            lblFechaVencimiento.TabIndex = 19;
            lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(14, 51);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 22;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(14, 116);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(200, 23);
            dtpFechaVencimiento.TabIndex = 24;
            
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(147, 331);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(91, 23);
            btnComprobante.TabIndex = 29;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(18, 73);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(148, 20);
            lblSocio.TabIndex = 16;
            lblSocio.Text = "Seleccione un Socio:";
            // 
            // cbxNSocio
            // 
            cbxNSocio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNSocio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxNSocio.FormattingEnabled = true;
            cbxNSocio.Location = new Point(18, 96);
            cbxNSocio.Name = "cbxNSocio";
            cbxNSocio.Size = new Size(301, 23);
            cbxNSocio.TabIndex = 28;
            cbxNSocio.SelectedIndexChanged += cbxNSocio_SelectedIndexChanged;
            cbxNSocio.SelectedValueChanged += cbxNSocio_SelectedIndexChanged;
            cbxNSocio.TextChanged += cbxNSocio_SelectedIndexChanged;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(249, 331);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(98, 23);
            btnCobrar.TabIndex = 15;
            btnCobrar.Text = "Registrar Cobro";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(18, 279);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 23);
            txtMonto.TabIndex = 26;
            txtMonto.TextChanged += txtMonto_TextChanged;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // grbMetodoPago
            // 
            grbMetodoPago.Controls.Add(rbtTarjeta);
            grbMetodoPago.Controls.Add(rbtEfectivo);
            grbMetodoPago.Location = new Point(18, 193);
            grbMetodoPago.Name = "grbMetodoPago";
            grbMetodoPago.Size = new Size(200, 51);
            grbMetodoPago.TabIndex = 25;
            grbMetodoPago.TabStop = false;
            grbMetodoPago.Text = "Método de Pago";
             // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(121, 21);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Checked = true;
            rbtEfectivo.Location = new Point(21, 21);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(18, 151);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(200, 23);
            dtpFechaPago.TabIndex = 21;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(18, 133);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 16;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(18, 261);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 15;
            lblMonto.Text = "Monto";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(422, 394);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 23);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNuevoCobro
            // 
            btnNuevoCobro.Location = new Point(313, 393);
            btnNuevoCobro.Name = "btnNuevoCobro";
            btnNuevoCobro.Size = new Size(98, 23);
            btnNuevoCobro.TabIndex = 31;
            btnNuevoCobro.Text = "Nuevo Cobro";
            btnNuevoCobro.UseVisualStyleBackColor = true;
            btnNuevoCobro.Click += btnNuevoCobro_Click;
            // 
            // frmCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 430);
            Controls.Add(btnNuevoCobro);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Name = "frmCuotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Cobro de cuotas";
            Load += frmCuotas_Load;
            grbTipoUsuario.ResumeLayout(false);
            grbTipoUsuario.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCuota.ResumeLayout(false);
            grbCuota.PerformLayout();
            grbMetodoPago.ResumeLayout(false);
            grbMetodoPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTipoUsuario;
        private RadioButton rbtNoSocio;
        private RadioButton rbtSocio;
        private Panel panel1;
        private Label lblFechaPago;
        private Label lblMonto;
        private Label lblFechaVencimiento;
        private Label lblFechaInicio;
        private GroupBox grbMetodoPago;
        private DateTimePicker dtpFechaVencimiento;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaPago;
        private TextBox txtMonto;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCobrar;
        private ComboBox cbxNSocio;
        private Label lblSocio;
        private Button btnComprobante;
        private Button btnVolver;
        private Button btnNuevoCobro;
        private GroupBox grbCuota;
    }
}