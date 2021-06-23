using Servicios.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSI2021.Frontend {
    public partial class frmEntradasActuales : Form {
        public frmEntradasActuales() {
            InitializeComponent();
        }

        private void frmEntradasActuales_Load(object sender, EventArgs e) {
            List<Entrada> entradas = GestorRegistroVenta.ListarEntradasSedeEnFecha();

            entradas.ForEach(entrada => {
                int newRowIx = tablaEntradas.Rows.Add(entrada.GetNumero(), entrada.GetFechaVenta().ToString("HH:mm")
                    , entrada.GetMonto(), entrada.GetTarifa().GetTipoEntrada().GetNombre(), entrada.GetTarifa().GetTipoVisita().GetNombre());
                tablaEntradas.Rows[newRowIx].Tag = entrada;
            });

            lblCupoMaximo.Text = GestorRegistroVenta.MostrarCantidadMaximaVisitantes().ToString();
            lblCupoActual.Text = GestorRegistroVenta.MostrarCantidadDeVisitantes().ToString();
        }
    }
}
