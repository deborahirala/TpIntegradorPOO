using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador_Club
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            frmListados Listados = new frmListados();

            Listados.Show();
            this.Hide();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            frmInscripcion Inscripcion = new frmInscripcion();

            Inscripcion.Show();
            this.Hide();
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            frmCuotas Cuotas = new frmCuotas();

            Cuotas.Show();
            this.Hide();
        }

         
    }
}
