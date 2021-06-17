using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI2021.Business;
using DSI2021.Frontend;

namespace DSI2021.Frontend {
    public partial class PantallaRegistroVenta : Form {
        public PantallaRegistroVenta() {
            InitializeComponent();
        }

        private void btnGenerar(object sender, EventArgs e) {
            Abrir(new frmVentanaConfirmacion());
        }

        public void Abrir(Form formulario) {
            formulario.ShowDialog();
            Hide();
        }

        private void PantallaRegistroVenta_Load(object sender, EventArgs e) {
            List<Tarifa> tarifasValidas = GestorRegistroVenta.BuscarTarifasVigentes();
            MostrarTarifas(tarifasValidas);
        }

        public void MostrarTarifas(List<Tarifa> tarifas) {
            foreach (Tarifa tarifa in tarifas) {
                var monto = tarifa.GetMonto();
                var montoAdicional = tarifa.GetMontoAdicional();
                var tipoEntrada = tarifa.GetTipoEntrada().GetNombre();
                var tipoVisita = tarifa.GetTipoVisita().GetNombre();

                tablaTarifas.Rows.Add(monto, montoAdicional, tipoEntrada, tipoVisita);
            }
        }
    }
}
