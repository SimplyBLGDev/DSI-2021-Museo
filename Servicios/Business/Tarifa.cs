﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
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

		private int GetMonto() {
			return monto;
		}

		private float GetMontoAdicional() {
			return montoAdicionalGuia;
		}

	}
}