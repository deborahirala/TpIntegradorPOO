using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Proyecto_Integrador_Club.Datos;
using MySql.Data.MySqlClient;

namespace Proyecto_Integrador_Club
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal Principal = new frmPrincipal();
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                Datos.Conexion.baseDatos = txtBD.Text;
                Datos.Conexion.clave = txtPasswordBD.Text;
                Datos.Conexion.usuario = txtUsuarioBD.Text;
                Datos.Conexion.servidor = txtServidor.Text;
                Datos.Conexion.puerto = txtPuerto.Text;

                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MessageBox.Show("Conexión a la Base de Datos exitosa. Ahora puede ingresar al sistema.", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIngresar.Enabled = true;
                btnConectar.Enabled = false;
                txtUsuarioBD.Enabled = false;
                txtPasswordBD.Enabled = false;
                txtServidor.Enabled = false;
                txtPuerto.Enabled = false;
                txtBD.Enabled = false;
            }

            catch (Exception ex)
            {
                // throw; 
                btnIngresar.Enabled = false;
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.ToString(), "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}