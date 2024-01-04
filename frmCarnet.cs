using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador_Club
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        public string nSocio;
        public string nombre;
        public string dni;
        public string fechaInicio;
        public string tipoUsuario;

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblSocio.Text = tipoUsuario;
            lblNombre.Text = nombre;
            lblDNI.Text = dni;
            lblNSocio.Text = nSocio;
            lblFechaInicio.Text = fechaInicio;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnVolver.Visible = false;
            PrintDocument pd = new PrintDocument();

            // Configurar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // Mostrar el cuadro de diálogo de impresión
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
                pd.Print();
            }

            btnImprimir.Visible = true;
            btnVolver.Visible = true;

        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
