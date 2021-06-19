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
		private static ServicioReservas _servicioReservas = new ServicioReservas();
		private static ServicioEntrada _servicioEntrada = new ServicioEntrada();

		public static void Inicializar()
		{
			//sedeActual = new Sede { Id = 1 };
			sedeActual = _servicioSede.MostrarInformacionSede(new Sede { Id = 1 });
			tarifas = _servicioTarifa.MostrarTarifasExistentes(sedeActual);
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


		public static bool ValidarCantidadMaxima(int cantidadEntradasUsuario)
		{
			var cantidadMaximaSede = sedeActual.GetCantidadMaximaVisitantes();
			var cantidadConfirmados = _servicioReservas.CantidadDeAlumnosConfirmados(sedeActual);
			var cantidadReservas = _servicioEntrada.CantidadEntradasReservadas(sedeActual);

			var superarCantidadMaxima = (cantidadConfirmados + cantidadReservas + cantidadEntradasUsuario) > cantidadMaximaSede;

			return superarCantidadMaxima;
		}
	}
}
