using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public static class GestorRegistroVenta {
		private static int cantidadEntradas;
		private static bool conGuia;
		private static float montoAdicionalPorGuia;
		private static Sede sedeActual;
		private static List<Tarifa> tarifas;

		private static ServicioTarifa _servicioTarifa = new ServicioTarifa();
		private static ServicioSede _servicioSede = new ServicioSede();

		public static void Inicializar()
		{
			tarifas = _servicioTarifa.MostrarTarifasExistentes(new Sede { Id=1});
		}

		public static Hora CalcularDuracionVisita() {
			return _servicioSede.MostrarDuracionDeVisita(sedeActual);
		}

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
