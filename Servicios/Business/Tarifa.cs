using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Tarifa {
		private DateTime? fechaInicioVigencia;
		private DateTime? fechaFinVigencia;
		private int monto;
		private float montoAdicionalGuia;
		private TipoVisita tipoVisita;
		private TipoEntrada tipoEntrada;
		private int Id;


		public static implicit operator Tarifa(AccesoADatos.Tarifa tarifaBd) {
			var nuevo = new Tarifa();
			nuevo.Id = tarifaBd.Id;
			nuevo.fechaFinVigencia = tarifaBd.FechaFinVigencia;
			nuevo.fechaInicioVigencia = tarifaBd.FechaInicioVigencia;
			nuevo.tipoEntrada = tarifaBd.TipoEntrada;
			nuevo.tipoVisita = tarifaBd.TipoVisita;
			nuevo.monto = 10;
			nuevo.montoAdicionalGuia = 10;
			return nuevo;
		}

		public bool EsVigente(DateTime fecha) {

			return (fechaFinVigencia == null || fecha < fechaFinVigencia) && fecha > fechaInicioVigencia;
		}

		public int GetNumeroTarifa()
		{
			return Id;
		}

		public int GetMonto() {
			return monto;
		}

		public float GetMontoAdicional() {
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
