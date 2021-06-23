using Base.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSI2021.Frontend
{
	public partial class PantallaRegistroVenta : Form {

		Hora duracionVisita;
		int cantidadEntradas;

		public PantallaRegistroVenta() {
			InitializeComponent();
		}

		public void Abrir(Form formulario) {
			if (formulario.ShowDialog() == DialogResult.OK) {
				if (GestorRegistroVenta.ValidarCantidadDeEntradas(cantidadEntradas)) {
					MessageBox.Show("Supero al cantidad máxima de visitantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				GestorRegistroVenta.ConfirmarVenta(cantidadEntradas, GetTarifaSeleccionada());
				ImprimirEntradas();
			}

			Hide();
		}

		private void btnGenerar(object sender, EventArgs e) {
			decimal montoPorEntrada;
			decimal montoTotal;

			cantidadEntradas = GetCantidadEntradas();

			Tarifa tarifaSeleccionada = GetTarifaSeleccionada();
			if (tarifaSeleccionada == null) {
				MessageBox.Show("Seleccione una tarifa.");
				return;
			}
			montoPorEntrada = tarifaSeleccionada.GetMonto();
			montoTotal = montoPorEntrada * cantidadEntradas;

			Abrir(new frmVentanaConfirmacion(cantidadEntradas, montoPorEntrada, montoTotal, (tarifaSeleccionada.GetMontoAdicional() * cantidadEntradas)));
		}

		private int GetCantidadEntradas() {
			if (int.TryParse(txtCantEntradas.Text, out int cantEntradas))
				return cantEntradas;

			return 0;
		}
		
		private Tarifa GetTarifaSeleccionada() {
			return dgvTablaTarifas.SelectedRows[0]?.Tag as Tarifa;
		}

		private void PantallaRegistroVenta_Load(object sender, EventArgs e) {
			// Alta Cohesion: la pantalla llama directamente a el metodo opcionRegistrarVenta,
			// en vez de llamar al de la Sede

			GestorRegistroVenta.OpcionRegistrarVenta();
			List<Tarifa> tarifasValidas = GestorRegistroVenta.MostrarTarifas();
			MostrarTarifas(tarifasValidas);
		}

		public void MostrarTarifas(List<Tarifa> tarifas) {
			foreach (Tarifa tarifa in tarifas) {
				var id = tarifa.GetNumeroTarifa();
				var monto = tarifa.GetMonto();
				string montoAdicional = tarifa.GetMontoAdicional().ToString();
				if (montoAdicional == "0")
					montoAdicional = "-";
				var tipoEntrada = tarifa.GetTipoEntrada().GetNombre();
				var tipoVisita = tarifa.GetTipoVisita().GetNombre();

				int newRowIx = dgvTablaTarifas.Rows.Add(monto, montoAdicional, tipoEntrada, tipoVisita);
				dgvTablaTarifas.Rows[newRowIx].Tag = tarifa;
			}
		}

		private void dgvTablaTarifas_RowEnter(object sender, DataGridViewCellEventArgs e) {
			TomarSeleccionTarifa(e.RowIndex);
		}

		private void TomarSeleccionTarifa(int rowIndex) {
			var tarifaSeleccionda = (Tarifa)dgvTablaTarifas.Rows[rowIndex].Tag;

			if (tarifaSeleccionda != null) {
				duracionVisita = GestorRegistroVenta.CalcularDuracionVisitaCompleta(tarifaSeleccionda);
				MostrarDuracionVisita(duracionVisita);
			}
		}

		private void MostrarDuracionVisita(Hora duracionVisita) {
			lblDuracionVisita.Text = duracionVisita.ToString();

			lblDuracionVisita.Visible = duracionVisita.seconds > 0;
			lblTextoDuracionVisita.Visible = duracionVisita.seconds > 0;
		}

		private void ImprimirEntradas() {
			MessageBox.Show("Imprimir entradas");
		}
	}
}
