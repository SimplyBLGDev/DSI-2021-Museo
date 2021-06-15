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

namespace DSI2021.Frontend
{
    public partial class PantallaRegistroVenta : Form
    {
        public PantallaRegistroVenta()
        {
            InitializeComponent();
        }
        public void Abrir(Form formulario)
        {
            formulario.ShowDialog();
            Hide();
        }

        private void PantallaRegistroVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar(object sender, EventArgs e)
        {
            Abrir(new frmVentanaConfirmacion());
        }
    }
}
