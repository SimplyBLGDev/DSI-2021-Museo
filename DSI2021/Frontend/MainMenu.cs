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
            GestorRegistroVenta.Inicilizar();
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

    }
}
