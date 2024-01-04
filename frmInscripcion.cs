using Proyecto_Integrador_Club.Entidades;
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
    public partial class frmInscripcion : Form
    {
        string nroNuevoUsuarioClub = "";

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void imprimirCarnet(string nroSocio)
        {
            frmCarnet carnet = new frmCarnet();

            if (rbtSocio.Checked)
            {
                carnet.tipoUsuario = "Socio";

            }
            else
            {
                carnet.tipoUsuario = "No Socio";
            }
            carnet.nombre = "Nombre: " + txtNombre.Text;
            carnet.nSocio = "Nro: " + nroSocio;
            carnet.dni = "DNI: " + txtDNI.Text;
            carnet.fechaInicio = "Fecha de inscripción: " + dtpFechaInscripcion.Text;
            carnet.Show();
        }

        private void InscribirUsuarioClub(TipoUsuarioClub tipoUsuario)
        {
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtDNI.Text == "" || chkAptoFisico.Checked == false)
            {
                MessageBox.Show("Debe completar todos los campos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_UsuarioClub socio = new E_UsuarioClub();
                socio.Nombre = txtNombre.Text;
                if (txtDNI.Text.Length > 9)
                {
                    socio.DNI = Convert.ToInt32(txtDNI.Text.Substring(0, 9));
                }
                else
                {
                    socio.DNI = Convert.ToInt32(txtDNI.Text);
                }
                socio.Correo = txtEmail.Text;
                socio.FechaInscripcion = DateOnly.FromDateTime(dtpFechaInscripcion.Value);
                socio.AptoFisico = chkAptoFisico.Checked;

                respuesta = ClubDeportivo.RegistrarUsuarioClub(socio, tipoUsuario);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("USUARIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        nroNuevoUsuarioClub = respuesta;
                        btnCarnet.Enabled = true;
                        MessageBox.Show("Inscripción exitosa del " + tipoUsuario.ToString() + " Nro " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desactivarCampos();

                    }
                }
            }
        }

        private void desactivarCampos()
        {
            txtDNI.Enabled= false;
            txtEmail.Enabled= false;
            txtNombre.Enabled = false;
            dtpFechaInscripcion.Enabled = false;
            btnInscribir.Enabled = false;
            rbtNoSocio.Enabled = false;
            rbtSocio.Enabled = false;
            chkAptoFisico.Enabled = false;
        }
        private void activarCampos()
        {
            txtDNI.Enabled = true;
            txtEmail.Enabled = true;
            txtNombre.Enabled = true;
            dtpFechaInscripcion.Enabled = true;
            btnInscribir.Enabled = true;
            rbtNoSocio.Enabled = true;
            rbtSocio.Enabled = true;
            chkAptoFisico.Enabled = true;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (rbtSocio.Checked)
            {
                InscribirUsuarioClub(TipoUsuarioClub.Socio);
            }
            else
            {
                InscribirUsuarioClub(TipoUsuarioClub.NoSocio);
            }
        }

        private void btnNuevaInscripcion_Click(object sender, EventArgs e)
        {
            nroNuevoUsuarioClub = "";
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            chkAptoFisico.Checked = false;
            dtpFechaInscripcion.Value = DateTime.Today;
            btnCarnet.Enabled = false;
            btnInscribir.Enabled = true;
            txtNombre.Focus();

            activarCampos();
        }


        private void btnCarnet_Click(object sender, EventArgs e)
        {
            imprimirCarnet(nroNuevoUsuarioClub);
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla especial
            // Si no es un número ni una tecla especial, se cancela la pulsación
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            // Además, verifica si ya hay un punto o coma en la TextBox y, si es así, cancela la pulsación
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void rbtNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            btnCarnet.Enabled = false;
        }

        private void rbtSocio_CheckedChanged(object sender, EventArgs e)
        {
            btnCarnet.Enabled = false;
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
