using Servicios.Business;
using System.Windows.Forms;

namespace DSI2021.Frontend
{
    public partial class frmVentanaConfirmacion : Form
    {
        public frmVentanaConfirmacion(int cantidadEntradas, int montoPorEntrada, int montoTotal)
        {
            InitializeComponent();

            lblCantidadEntradas.Text = cantidadEntradas.ToString();
            lblMontoXEntrada.Text = "$" + montoPorEntrada.ToString();
            lblMontoTotal.Text = "$" + montoTotal.ToString();
        }

		private void btnCancelar_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
		}

		private void btnConfirmar_Click(object sender, System.EventArgs e) {
            
		}
	}
}
