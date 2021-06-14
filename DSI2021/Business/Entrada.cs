using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	class Entrada {
		private Sede sede;
		private DateTime fechaVenta;
		private int monto;
		private int numero;

		public Sede GetSede() {
			return sede;
		}

		public bool ValidarHorarioEntrada(DateTime actual) {
			return actual.Date == fechaVenta.Date;
		}
	}
}
