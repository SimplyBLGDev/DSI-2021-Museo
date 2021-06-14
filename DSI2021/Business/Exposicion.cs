using DSI2021.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	class Exposicion {
		private string nombre;
		private DateTime fechaInicio;
		private DateTime fechaFin;
		private Hora horaApertura;
		private Hora horaCierre;

		public Hora CalcularDuracionVisita() {
			return horaCierre - horaApertura;
		}

		public bool EsVigente(DateTime fecha) {
			return fecha < fechaFin && fecha > fechaInicio;
		}
	}
}
