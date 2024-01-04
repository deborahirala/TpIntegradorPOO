namespace Proyecto_Integrador_Club
{
    partial class frmListados
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
            dtgvListado = new DataGridView();
            grbListado = new GroupBox();
            rbtTodos = new RadioButton();
            rbtVencidos = new RadioButton();
            btnVolver = new Button();
            btnSalir = new Button();
            NSocio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Vencimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvListado).BeginInit();
            grbListado.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvListado
            // 
            dtgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListado.Columns.AddRange(new DataGridViewColumn[] { NSocio, Nombre, DNI, Vencimiento });
            dtgvListado.Location = new Point(20, 91);
            dtgvListado.Name = "dtgvListado";
            dtgvListado.ReadOnly = true;
            dtgvListado.RowTemplate.Height = 25;
            dtgvListado.Size = new Size(590, 227);
            dtgvListado.TabIndex = 0;
             // 
            // grbListado
            // 
            grbListado.Controls.Add(rbtTodos);
            grbListado.Controls.Add(rbtVencidos);
            grbListado.Location = new Point(20, 8);
            grbListado.Name = "grbListado";
            grbListado.Size = new Size(329, 68);
            grbListado.TabIndex = 1;
            grbListado.TabStop = false;
            grbListado.Text = "Listar:";
             // 
            // rbtTodos
            // 
            rbtTodos.AutoSize = true;
            rbtTodos.Location = new Point(205, 29);
            rbtTodos.Name = "rbtTodos";
            rbtTodos.Size = new Size(110, 19);
            rbtTodos.TabIndex = 1;
            rbtTodos.TabStop = true;
            rbtTodos.Text = "Todos los socios";
            rbtTodos.UseVisualStyleBackColor = true;
            rbtTodos.CheckedChanged += rbtTodos_CheckedChanged;
            // 
            // rbtVencidos
            // 
            rbtVencidos.AutoSize = true;
            rbtVencidos.Checked = true;
            rbtVencidos.Location = new Point(13, 30);
            rbtVencidos.Name = "rbtVencidos";
            rbtVencidos.Size = new Size(169, 19);
            rbtVencidos.TabIndex = 0;
            rbtVencidos.TabStop = true;
            rbtVencidos.Text = "Socios con cuotas vencidas";
            rbtVencidos.UseVisualStyleBackColor = true;
            rbtVencidos.CheckedChanged += rbtVencidos_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(439, 333);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(535, 333);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // NSocio
            // 
            NSocio.HeaderText = "Nro Socio";
            NSocio.Name = "NSocio";
            NSocio.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Vencimiento
            // 
            Vencimiento.HeaderText = "Vencimiento de cuota";
            Vencimiento.Name = "Vencimiento";
            Vencimiento.ReadOnly = true;
            // 
            // frmListados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 382);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Controls.Add(grbListado);
            Controls.Add(dtgvListado);
            Name = "frmListados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Listados";
            Load += frmListados_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListado).EndInit();
            grbListado.ResumeLayout(false);
            grbListado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvListado;
        private GroupBox grbListado;
        private RadioButton rbtVencidos;
        private RadioButton rbtTodos;
        private Button btnVolver;
        private Button btnSalir;
        private DataGridViewTextBoxColumn NSocio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Vencimiento;
    }
}