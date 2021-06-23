using System;

namespace Base.Business {
	public class Tarifa {
		private DateTime? fechaInicioVigencia;
		private DateTime? fechaFinVigencia;
		private decimal monto;
		private decimal montoAdicionalGuia;
		private TipoVisita tipoVisita;
		private TipoEntrada tipoEntrada;
		private int Id;

		public static implicit operator Tarifa(AccesoADatos.Tarifa tarifaBd) {
			Tarifa nuevo = new Tarifa();
			nuevo.Id = tarifaBd.Id;
			nuevo.fechaFinVigencia = tarifaBd.FechaFinVigencia;
			nuevo.fechaInicioVigencia = tarifaBd.FechaInicioVigencia;
			nuevo.tipoEntrada = tarifaBd.TipoEntrada;
			nuevo.tipoVisita = tarifaBd.TipoVisita;
			nuevo.monto = tarifaBd.Monto ?? 0;
			nuevo.montoAdicionalGuia = tarifaBd.MontoAdicionalGuia ?? 0;
			return nuevo;
		}

		// Patron Experto: se estaria cumpliendo este patron ya que la responsabilidad se encuentra
		// en la clase que tiene los datos, es decir, ubicamos el comportamiento lo mas cerca posible de donde
		// se encuentran los datos necesarios para que este se ejecute.
		public bool EsVigente(DateTime fecha) {
			return (fechaFinVigencia == null || fecha < fechaFinVigencia) && fecha > fechaInicioVigencia;
		}

		public int GetNumeroTarifa() {
			return Id;
		}

		public decimal GetMonto() {
			return monto;
		}

		public decimal GetMontoAdicional() {
			return montoAdicionalGuia;
		}


		public TipoEntrada GetTipoEntrada() {
			return tipoEntrada;
		}

		public TipoVisita GetTipoVisita() {
			return tipoVisita;
		}
	}
}
