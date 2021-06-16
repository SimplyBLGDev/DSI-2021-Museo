using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class GestorRegistroVenta {
		private int cantidadEntradas;
		private bool conGuia;
		private float montoAdicionalPorGuia;
		private Sede sedeActual;
		private List<Tarifa> tarifas;

		public DateTime getFechaActual() {
			return DateTime.Now;
		}
	}
}
