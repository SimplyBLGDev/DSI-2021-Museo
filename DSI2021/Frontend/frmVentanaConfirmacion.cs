using System.Windows.Forms;

namespace DSI2021.Frontend {
    public partial class frmVentanaConfirmacion : Form {
        public frmVentanaConfirmacion(int cantidadEntradas, decimal montoPorEntrada, decimal montoTotal, decimal montoPorGuia) {
            InitializeComponent();

            lblCantidadEntradas.Text = cantidadEntradas.ToString();
            lblMontoXEntrada.Text = "$" + montoPorEntrada.ToString();
            lblMontoTotal.Text = "$" + (montoTotal + montoPorGuia).ToString();
            lblMontoGuia.Text = "$" + montoPorGuia.ToString();
        }

		private void btnCancelar_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
		}

		private void btnConfirmar_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }      
    }
}
