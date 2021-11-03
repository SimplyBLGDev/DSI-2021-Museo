using Base.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSI2021.Frontend {
	public partial class PantallaRegistroVenta : Form {

		Hora duracionVisita;
		int cantidadEntradas;
		List<Exposicion> exposicionesSeleccionadas = new List<Exposicion>();

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

			CargarExposiciones();

			dgv_sede.Enabled = false;
		}

		private void CargarExposiciones() {
			exposicionesSeleccionadas = GestorRegistroVenta.MostrarExposiciones();
			MostrarExposiciones(exposicionesSeleccionadas);
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

		public void MostrarExposiciones(List<Exposicion> exposiciones) {
			dgv_sede.Rows.Clear();
			foreach (Exposicion exposicion in exposiciones) {
				int newRowIx = dgv_sede.Rows.Add(exposicion.GetNombre(),false);
				dgv_sede.Rows[newRowIx].Tag = exposicion;
			}
		}

		private void dgvTablaTarifas_RowEnter(object sender, DataGridViewCellEventArgs e) {
			TomarSeleccionTarifa(e.RowIndex);
		}

		private void TomarSeleccionTarifa(int rowIndex) {
			var tarifaSeleccionada = (Tarifa)dgvTablaTarifas.Rows[rowIndex].Tag;

			if (tarifaSeleccionada != null) {
				var esCompleta = tarifaSeleccionada.GetTipoVisita().EsCompleta();
				dgv_sede.Enabled = !esCompleta;
				ClearSedeSelections();

				exposicionesSeleccionadas = esCompleta? GestorRegistroVenta.MostrarExposiciones() : new List<Exposicion>();
				UpdateDuracionEstimada();
			}
		}

		private void ClearSedeSelections() {
			for (int i = 0; i < dgv_sede.Rows.Count; i++)
				dgv_sede.Rows[i].Cells[1].Value = false;
		}

		private void MostrarDuracionVisita(Hora duracionVisita) {
			lblDuracionVisita.Text = duracionVisita.ToString();

			lblDuracionVisita.Visible = duracionVisita.seconds > 0;
			lblTextoDuracionVisita.Visible = duracionVisita.seconds > 0;
		}

		private void ImprimirEntradas() {
			MessageBox.Show("Imprimir entradas");
		}

		private void SeleccionarExposicion(object sender, DataGridViewCellEventArgs e) {
			var exposicion = (Exposicion)dgv_sede.Rows[e.RowIndex].Tag;
			var seleccionada = !(bool)(dgv_sede.Rows[e.RowIndex]).Cells[1].Value;
			dgv_sede.Rows[e.RowIndex].Cells[1].Value = seleccionada;

			if (seleccionada)
				exposicionesSeleccionadas.Add(exposicion);
			else
				exposicionesSeleccionadas.Remove(exposicion);

			UpdateDuracionEstimada();
		}

		private void UpdateDuracionEstimada() {
			duracionVisita = GestorRegistroVenta.CalcularDuracionVisita(GetTarifaSeleccionada(), exposicionesSeleccionadas);
			MostrarDuracionVisita(duracionVisita);
		}
	}
}
