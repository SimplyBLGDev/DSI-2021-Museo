using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	public class Tarifa {
		private DateTime fechaInicioVigencia;
		private DateTime fechaFinVigencia;
		private int monto;
		private float montoAdicionalGuia;
		private TipoVisita tipoVisita;
		private TipoEntrada tipoEntrada;

		public bool EsVigente(DateTime fecha) {
			return fecha < fechaFinVigencia && fecha > fechaInicioVigencia;
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
