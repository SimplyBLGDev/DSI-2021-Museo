using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	public static class GestorRegistroVenta {
		private static int cantidadEntradas;
		private static bool conGuia;
		private static float montoAdicionalPorGuia;
		private static Sede sedeActual;
		private static List<Tarifa> tarifas;

		public static DateTime GetFechaActual() {
			return DateTime.Now;
		}

		public static List<Tarifa> BuscarTarifasVigentes() {
			List<Tarifa> tarifasValidas = new List<Tarifa>();

			foreach (Tarifa tarifa in tarifas)
				if (tarifa.EsVigente(GetFechaActual()))
					tarifasValidas.Add(tarifa);

			return tarifasValidas;
		}
	}
}
