using System;
using System.Windows.Forms;
using DSI2021.Frontend;

namespace DSI2021 {
	public partial class MainMenu : Form {
		private Form activeForm = null;

		public MainMenu() {
			InitializeComponent();
		}

		private void OpenChildForm(Form childForm) {
			if (activeForm != null)
				activeForm.Close();

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			pnlPrincipal.Controls.Add(childForm);
			pnlPrincipal.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void ShowSubMenu(Panel submenu) {
			if (submenu.Visible is false) {
				HideSubmenu();
				submenu.Visible = true;
			} else {
				submenu.Visible = false;
			}
		}

		private void HideSubmenu() {
			pnlTipoDeEntrada.Visible = false;
			pnlVentaEntradas.Visible = false;
			pnlPrecioEntrada.Visible = false;
		}

		private void tmFechaHora_Tick(object sender, EventArgs e) {
			lblHora.Text = DateTime.Now.ToLongTimeString();
			lblFecha.Text = DateTime.Now.ToLongDateString();
		}

		private void btnRegistrarVentaEntradas_Click(object sender, EventArgs e) {
			OpenChildForm(new PantallaRegistroVenta());
		}

		private void btnVentaDeEntradas_Click(object sender, EventArgs e) {
			ShowSubMenu(pnlVentaEntradas);
		}

		private void btnPrecioDeEntrada_Click(object sender, EventArgs e) {
			ShowSubMenu(pnlPrecioEntrada);
		}

		private void btnTipoDeEntrada_Click(object sender, EventArgs e) {
			ShowSubMenu(pnlTipoDeEntrada);
		}

		private void btnEntradasActuales_Click(object sender, EventArgs e) {
			OpenChildForm(new frmEntradasActuales());
		}

		private void btnSalir(object sender, EventArgs e) {
			HideSubmenu();
			ConfirmarCierre();
		}

		private void ConfirmarCierre() {
			if (MessageBox.Show("¿Está seguro de que quiere salir de la aplicacion?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
				Application.Exit();
		}
	}
}
