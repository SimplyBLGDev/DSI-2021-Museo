using Servicios;
using Servicios.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI2021.Frontend;

namespace DSI2021 {
	public partial class MainMenu : Form {
		public MainMenu() {
			InitializeComponent();

			var servicio = new ServicioSede();
            GestorRegistroVenta.Inicializar();
		}

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
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

        private void btnRegistrarVentaEntradas_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaRegistroVenta());
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void hideSubmenu()
        {
            pnlTipoDeEntrada.Visible = false;
            pnlVentaEntradas.Visible = false;
            pnlPrecioEntrada.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible is false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnVentaDeEntradas_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlVentaEntradas);
        }

        private void btnPrecioDeEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlPrecioEntrada);
        }

        private void btnTipoDeEntrada_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTipoDeEntrada);
        }

        private void btnEntradasActuales_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSalir(object sender, EventArgs e)
        {
            hideSubmenu();
            GestorRegistroVenta.mensajeCerrar();
        }
    }
}
