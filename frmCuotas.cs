using MySql.Data.MySqlClient;
using Proyecto_Integrador_Club.Datos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Integrador_Club
{


    public partial class frmCuotas : Form
    {
        string NSocioSeleccionado = "";

        public frmCuotas()
        {
            InitializeComponent();
        }

        // función que trae los datos del socio seleccionado en el bcbx para mostrarlos en el la label del formulario
        public string DatosSocio(string NSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select Nombre, DNI from socio where NSocio = " + NSocio + ";";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return "Socio Nº" + NSocio + " - " + reader.GetString(0) + " - DNI " + reader.GetString(1);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return "";
        }
       
        // función para obtener datos del socio, utilizada para generar el comprobante de pago de la cuota
        public string InfoSocio(string NSocio, string Dato, string tabla)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select " + Dato + " from " + tabla + " where NSocio = " + NSocio + ";";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return "";
        }

        // desactiva los campos del formulario
        public void desactivarCampos()
        {
            dtpFechaInicio.Enabled = false;
            dtpFechaPago.Enabled = false;
            dtpFechaVencimiento.Enabled = false;
            rbtEfectivo.Enabled = false;
            rbtTarjeta.Enabled = false;
            txtMonto.Enabled = false;
            btnCobrar.Enabled = false;
        }
        
        // activa los campos del formulario
        public void activarCampos()
        {
            dtpFechaInicio.Enabled = true;
            dtpFechaPago.Enabled = true;
            dtpFechaVencimiento.Enabled = true;
            rbtEfectivo.Enabled = true;
            rbtTarjeta.Enabled = true;
            txtMonto.Enabled = true;
            btnCobrar.Enabled = true;
        }

        /* para cargar el combobox con el listado de socios*/
        private void cargaCbxSocios()
        {
            lblSocio.Text = "Seleccione un Socio: ";
            grbCuota.Text = "Cuota";
            lblFechaInicio.Visible = true;
            lblFechaInicio.Text = "Fecha de Inicio: ";
            lblFechaVencimiento.Visible = true;
            dtpFechaInicio.Visible = true;
            dtpFechaVencimiento.Visible = true;
            cbxNSocio.Items.Clear();
            cbxNSocio.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select NSocio, Nombre, DNI from socio;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbxNSocio.Items.Add(reader.GetString(0) + " (" + reader.GetString(1) + " DNI " + reader.GetString(2) + ")");
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        /* para cargar el combobox con el listado de no socios*/
        private void cargaCbxNoSocios()
        {
            lblSocio.Text = "Seleccione un NO Socio: ";

            grbCuota.Text = "Cuota Diaria";
            lblFechaInicio.Visible = true;
            lblFechaInicio.Text = "Fecha: ";
            lblFechaVencimiento.Visible = false;
            dtpFechaInicio.Visible = true;
            dtpFechaVencimiento.Visible = false;


            cbxNSocio.Items.Clear();
            cbxNSocio.Text = "";



            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select NSocio, Nombre, DNI from nosocio;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbxNSocio.Items.Add(reader.GetString(0) + " (" + reader.GetString(1) + " DNI " + reader.GetString(2) + ")");
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void frmCuotas_Load(object sender, EventArgs e)
        {
            desactivarCampos();
            cargaCbxSocios();
        }

        // guarda la cuota pagada en la base de datos
        private void guardarCuota(TipoUsuarioClub tipoUsuario)
        {
            string respuesta;
            E_Cuota cuota = new E_Cuota();
            cuota.NSocio = Convert.ToInt32(NSocioSeleccionado);
            cuota.Monto = Convert.ToInt32(txtMonto.Text);
            cuota.FechaPago = DateOnly.FromDateTime(dtpFechaPago.Value);
            cuota.MetodoPago = rbtEfectivo.Checked ? (int)MetodoPago.Efectivo : (int)MetodoPago.Tarjeta; 

            if (tipoUsuario == TipoUsuarioClub.Socio)
            {
                cuota.FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value);
                cuota.Vencimiento = DateOnly.FromDateTime(dtpFechaVencimiento.Value);
             }
            else
            {
                cuota.FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value);
                /* como es cuota diaria guardo misma fecha de inicio y vencimiento*/
                cuota.Vencimiento = DateOnly.FromDateTime(dtpFechaInicio.Value);
            }

            respuesta = ClubDeportivo.CobrarCuota(cuota, tipoUsuario);


            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 0)
                {
                    MessageBox.Show("EL NRO DE SOCIO/NO SOCIO NO EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cobro de cuota exitoso.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComprobante.Enabled = true;
                    btnCobrar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("error: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (NSocioSeleccionado == "" || txtMonto.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                if (rbtSocio.Checked)
                {
                    guardarCuota(TipoUsuarioClub.Socio);
                }
                else
                {
                    guardarCuota(TipoUsuarioClub.NoSocio);
                }
            }
            btnCobrar.Enabled = false;
            desactivarCampos();
            rbtNoSocio.Enabled = false;
            rbtSocio.Enabled=false;
            cbxNSocio.Enabled = false;
        }

        private void cbxNSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNSocio.SelectedIndex == -1)
            {
                desactivarCampos();
                if (rbtNoSocio.Checked)
                {
                    lblSocio.Text = "Seleccione un NO Socio: ";

                }
                else
                {
                    lblSocio.Text = "Seleccione un Socio: ";

                }

            }
            else
            {
                NSocioSeleccionado = cbxNSocio.Text.Substring(0, cbxNSocio.Text.IndexOf(" "));
                lblSocio.Text = DatosSocio(NSocioSeleccionado);
                activarCampos();
            }
        }

      

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.nSocio = "Nro: " + NSocioSeleccionado;



            if (rbtSocio.Checked)
            {
                factura.esSocio = true;
                factura.fechaInicio = "Fecha de inicio: " + dtpFechaInicio.Text;
                factura.vencimiento = "Fecha de vencimiento: " + dtpFechaVencimiento.Text;
                factura.dni = "DNI: " + InfoSocio(NSocioSeleccionado, "DNI", "socio");
                factura.nombre = "Nombre: " + InfoSocio(NSocioSeleccionado, "Nombre", "socio");

            }
            else
            {
                factura.dni = "DNI: " + InfoSocio(NSocioSeleccionado, "DNI", "nosocio");
                factura.nombre = "Nombre: " + InfoSocio(NSocioSeleccionado, "Nombre", "nosocio");
                factura.fechaInicio = "Fecha de actividad: " + dtpFechaInicio.Value.ToString("dd-MM-yyyy");

                factura.vencimiento = "";
                factura.esSocio = false;
            }


            factura.fechaPago = "Fecha de pago: " + dtpFechaPago.Text;
            factura.monto = "Monto: " + txtMonto.Text;

            if (rbtEfectivo.Checked)
            {
                factura.metodoPago = "Metodo de pago: Efectivo";

            }
            else
            {
                factura.metodoPago = "Metodo de pago: Tarjeta";
            }

            factura.Show();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            cbxNSocio.SelectedIndex = -1;
            btnComprobante.Enabled = false;
            btnCobrar.Enabled = true;
            activarCampos();
            rbtNoSocio.Enabled = true;
            rbtSocio.Enabled = true;
            cbxNSocio.Enabled = true;
            
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla especial
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Si no es un número ni una tecla especial, se cancela la pulsación
            }
            // Además, verifica si ya hay un punto o coma en la TextBox y, si es así, cancela la pulsación
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            btnComprobante.Enabled = false;
            
            if (rbtNoSocio.Checked)
            {
                cargaCbxNoSocios();
            }
            else
            {
                cargaCbxSocios();
            }

        }

        private void rbtSocio_CheckedChanged(object sender, EventArgs e)
        {
            btnComprobante.Enabled = false;

            if (rbtNoSocio.Checked)
            {
                cargaCbxNoSocios();
            }
            else
            {
                cargaCbxSocios();
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {
        }
    }

}
