using MySql.Data.MySqlClient;
using Proyecto_Integrador_Club.Datos;
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
    public partial class frmListados : Form
    {
        bool listadoVencidos = true;

        public frmListados()
        {
            InitializeComponent();
        }

        private void frmListados_Load(object sender, EventArgs e)
        {
            CargaGrilla(ClubDeportivo.queryListadoVencidos);
        }

        public void CargaGrilla(string query)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                dtgvListado.Rows.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvListado.Rows.Add();
                        dtgvListado.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvListado.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvListado.Rows[renglon].Cells[2].Value = reader.GetString(2);

                         // si viene la fecha  
                        if (reader.GetString(3) != "")
                        { 
                            dtgvListado.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        }
                        //si viene sin datos sobre cuotas
                        else
                        {
                            dtgvListado.Rows[renglon].Cells[3].Value = "Sin datos";
                        }
                    }
                }
                else
                {
                    if (listadoVencidos)
                        MessageBox.Show("No hay socios con cuotas vencidas.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!listadoVencidos)
                        MessageBox.Show("No hay socios.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTodos.Checked)
            {
                listadoVencidos = false;
                CargaGrilla(ClubDeportivo.queryListadoTodos);
            }
        }


        private void rbtVencidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtVencidos.Checked)
            {
                listadoVencidos = true;
                CargaGrilla(ClubDeportivo.queryListadoVencidos);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
