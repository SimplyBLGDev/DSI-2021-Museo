using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSI2021.Frontend
{
    public partial class PantallaRegistroVenta : Form
    {

        Hora duracionVisita;
        int cantidadEntradas;

        /// <summary>
        /// habilitar pantalla
        /// </summary>
        public PantallaRegistroVenta()
        {
            InitializeComponent();
            //
        }

        public void Abrir(Form formulario)
        {
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                if (GestorRegistroVenta.ValidarCantidadDeEntradas(cantidadEntradas))
                {
                    MessageBox.Show("Supero al cantidad maxima de visitanres");
                    return;
                }

                GestorRegistroVenta.ConfirmarVenta(cantidadEntradas, GetTarifaSeleccionada());
            }

            Hide();
        }

        private void btnGenerar(object sender, EventArgs e)
        {
            decimal montoPorEntrada;
            decimal montoTotal;

            cantidadEntradas = GetCantidadEntradas();

            Tarifa tarifaSeleccionada = GetTarifaSeleccionada();
            if (tarifaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una tarifa.");
                return;
            }
            montoPorEntrada = tarifaSeleccionada.GetMonto();
            montoTotal = montoPorEntrada * cantidadEntradas;

            Abrir(new frmVentanaConfirmacion(cantidadEntradas, montoPorEntrada, montoTotal, (tarifaSeleccionada.GetMontoAdicional() * cantidadEntradas)));
        }

        private int GetCantidadEntradas()
        {
            int cantEntradas = 0;
            if (int.TryParse(txtCantEntradas.Text, out cantEntradas))
                return cantEntradas;

            return 0;
        }

        private Tarifa GetTarifaSeleccionada()
        {
            return dgvTablaTarifas.SelectedRows[0]?.Tag as Tarifa;
        }

        private void PantallaRegistroVenta_Load(object sender, EventArgs e)
        {
            GestorRegistroVenta.OpcionRegitrarVenta();
            List<Tarifa> tarifasValidas = GestorRegistroVenta.MostrarTarifas();
            MostrarTarifas(tarifasValidas);

            //duracionVisita = GestorRegistroVenta.CalcularDuracionVisitaCompleta();
            //lblDuracionVisita.Text = duracionVisita.ToString();
        }

        public void MostrarTarifas(List<Tarifa> tarifas)
        {
            foreach (Tarifa tarifa in tarifas)
            {
                var id = tarifa.GetNumeroTarifa();
                var monto = tarifa.GetMonto();
                var montoAdicional = tarifa.GetMontoAdicional();
                var tipoEntrada = tarifa.GetTipoEntrada().GetNombre();
                var tipoVisita = tarifa.GetTipoVisita().GetNombre();

                int newRowIx = dgvTablaTarifas.Rows.Add(monto, montoAdicional , tipoEntrada, tipoVisita);
                dgvTablaTarifas.Rows[newRowIx].Tag = tarifa;
            }
        }

        private void dgvTablaTarifas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var tarifaSeleccionda = (Tarifa)dgvTablaTarifas.Rows[e.RowIndex].Tag;

            if (tarifaSeleccionda != null)
            {
                duracionVisita = GestorRegistroVenta.CalcularDuracionVisitaCompleta(tarifaSeleccionda);
                lblDuracionVisita.Text = duracionVisita.ToString();

                lblDuracionVisita.Visible = duracionVisita.seconds > 0;
                lblTextoDuracionVisita.Visible = duracionVisita.seconds > 0;
            }

        }


        private void Imprimir()
        { 
        
        }
    }
}
